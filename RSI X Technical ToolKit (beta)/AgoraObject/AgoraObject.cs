using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

using agorartc;
using HWND = System.IntPtr;

namespace RSI_X_Desktop
{
    enum CurForm
    {
        workFormater,
        FormBroadcaster,
        FormAudience,
        FormEngineer,
        FormEngineer2,
        None
    }

    public enum HostType
    {
        Broadcaster,
        President,
        Secretary,
    }
    static class AgoraObject
    {

        public const string AppID = "31f0e571a89542b09049087e3283417f";

        public static bool IsJoin { get; private set; }
        public static bool IsLocalAudioMute { get; private set; }
        public static bool IsLocalVideoMute { get; private set; }
        public static bool IsScreenCapture { get { return ScreenCapture.IsCapture; } }
        public static bool IsAllRemoteAudioMute { get; private set; }
        public static bool IsAllRemoteVideoMute { get; private set; }
        public static HostType joinType = HostType.Broadcaster;

        public static bool IsAllTransLatersAudioMute { get; private set; }

        public static string CodeRoom { get; private set; } = "";
        public static string NickName { get; private set; } = "";
        public static string ClientID { get; private set; } = "";
        public static string RoomLang { get => RoomName.Split('_')[0]; }
        public static string RoomName { get; private set; } = ""; //Full name of the interpreters room without 8 digits


        public static string RoomTarg { get; private set; } = ""; //Full name of the target room without 8 digits
        public static CurForm CurrentForm = CurForm.None;

        internal static AgoraRtcEngine Rtc;

        internal static Tokens room = new Tokens();

        internal static AgoraRtcChannel m_channelHost;

        private static int _hostStreamID;
        internal static int hostStreamID { get => _hostStreamID; }
        internal static AGChannelEventHandler hostHandler;
        private static IFormHostHolder workForm;
        private static uint name;

        public static IFormHostHolder GetWorkForm
        {
            get
            {
                return (workForm == null || (workForm as Form).IsDisposed) ?
                    null :
                    workForm;
            }
        }

        public static bool m_channelSrcJoin { get; private set; } = false;
        public static bool m_channelTranslJoin { get; private set; } = false;
        public static bool m_channelHostJoin { get; private set; } = false;
        public static bool m_channelTargetJoin { get; private set; } = false;

        public readonly static System.Text.UTF8Encoding utf8enc = new();

        [DllImport("USER32.DLL")]
        static extern bool GetWindowRect(IntPtr hWnd, out System.Drawing.Rectangle lpRect);

        static AgoraObject()
        {
            Rtc = AgoraRtcEngine.CreateRtcEngine();
            Rtc.Initialize(new RtcEngineContext(AppID));
            Rtc.EnableVideo();

            //UpdateNickName(NickCenter.ToHostNick("BROADCASTER"));
            SetPublishProfile();
        }

        private static void SetPublishProfile()
        {
            Rtc.SetAudioProfile(AUDIO_PROFILE_TYPE.AUDIO_PROFILE_MUSIC_HIGH_QUALITY, AUDIO_SCENARIO_TYPE.AUDIO_SCENARIO_CHATROOM_GAMING);
            Rtc.SetVideoProfile(VIDEO_PROFILE_TYPE.VIDEO_PROFILE_LANDSCAPE_1080P_3, false);
        }
        private static void SetDefaultAudioProfile()
        {
            Rtc.SetAudioProfile(AUDIO_PROFILE_TYPE.AUDIO_PROFILE_MUSIC_STANDARD, AUDIO_SCENARIO_TYPE.AUDIO_SCENARIO_CHATROOM_GAMING);
        }
        internal static void GenerateNickName()
        {
            var rnd = new Random();
            name = (uint)rnd.Next();
            switch (joinType)
            {
                case HostType.President:
                    UpdateNickName(NickCenter.ToPresidentNick(name.ToString()));
                    break;
                case HostType.Secretary:
                    UpdateNickName(NickCenter.ToSecretaryNick(name.ToString()));
                    break;
                default:
                    UpdateNickName(NickCenter.ToHostNick(name.ToString()));
                    break;
            }
        }

        static public void UpdateNickName(string nick)
        { 
            NickName = nick;
            DebugWriter.WriteTime($"AgoraObject. New nickname {NickName}");
        }
        static public void UpdateRoomName(string name)
        { RoomName = name; }
        static public void UpdateClientID(string uid)
        { ClientID = uid; }

        #region token logic
        static public bool JoinRoom(string code)
        {
            CodeRoom = code;
            return room.TakeToken(code);
        }

        public static Tokens GetComplexToken() => room;
        public static string GetHostToken() => room.GetHostToken;
        public static string GetHostName() => room.GetHostName;
        public static List<string> GetLangCollection() => room.GetLanguages.Keys.ToList();
        #endregion

        #region Mute local audio/video
        static public ERROR_CODE MuteLocalAudioStream(bool mute)
        {
            ERROR_CODE res;

            res = Rtc.MuteLocalAudioStream(mute);

            if (res == (int)ERROR_CODE.ERR_OK)
                IsLocalAudioMute = mute;

            return res;
        }

        static public ERROR_CODE MuteLocalVideoStream(bool mute)
        {
            ERROR_CODE res;

            res = Rtc.MuteLocalVideoStream(mute);

            if (res == (int)ERROR_CODE.ERR_OK)
                IsLocalVideoMute = mute;

            return res;
        }
        #endregion

        #region  mute remote video\audio
        static public void MuteAllRemoteAudioStream(bool mute)
        {
            Rtc.MuteAllRemoteAudioStreams(mute);
            m_channelHost?.MuteAllRemoteAudioStreams(mute);

            IsAllRemoteAudioMute = mute;
        }

        static public void MuteAllRemoteVideoStream(bool mute)
        {
            Rtc.MuteAllRemoteVideoStreams(mute);
            m_channelHost?.MuteAllRemoteVideoStreams(mute);

            IsAllRemoteVideoMute = mute;
        }
        #endregion

        static public void SetWndEventHandler(IFormHostHolder form)
        {
            Rtc.InitEventHandler(new AGEngineEventHandler(form));
            hostHandler = new AGChannelEventHandler(form, CHANNEL_TYPE.HOST);
            workForm = form;
        }

        #region Screen/Window capture
        public static bool EnableWindowCapture(HWND index)
        {
            //Rectangle region = new Rectangle();
            //System.Drawing.Rectangle Rectangle2 = new();
            //GetWindowRect((System.IntPtr)index, out Rectangle2);
            //int wdth = Rectangle2.Width;
            //int hgt = Rectangle2.Height;
            //ScreenCaptureParameters capParam = new ScreenCaptureParameters(wdth, hgt)
            //{

            //};
            //region.x = 0;
            //region.y = 0;
            //region.width = wdth;
            //region.height = hgt;
            //capParam.bitrate = 1200;
            //capParam.frameRate = 30;
            //Rtc.StartScreenCaptureByWindowId((ulong)index, region, capParam);
            return true;
        }
        public static void StartScreenCapture(ScreenCaptureParameters? capParam = null)
        {
            if (capParam == null)
                capParam = forms.PopUpForm.GetVideoParam();
            ScreenCapture.StartScreenCapture(capParam.Value);
        }
        public static void StopScreenCapture()
        {
            ScreenCapture.StopScreenCapture();
        }
        #endregion

        #region Engine channel
        static public void JoinChannel()
        {
            JoinChannel(room.GetHostName, room.GetHostToken);
        }
        static public ERROR_CODE JoinChannel(string chName, string token)
        {
            ERROR_CODE res;
            
            res = Rtc.JoinChannelWithUserAccount(token, chName, NickName);

            if (res == (int)ERROR_CODE.ERR_OK)
                IsJoin = true;

            Rtc.MuteLocalAudioStream(IsLocalAudioMute);
            Rtc.MuteLocalVideoStream(IsLocalVideoMute);

            Rtc.CreateDataStream(out _hostStreamID, true, true);
            //_hostStreamID = Rtc.CreateDataStream(new() 
            //{ 
            //    ordered=true,
            //    syncWithAudio=true,
            //});

            Rtc.StartPreview();
            return res;
        }
        static public ERROR_CODE LeaveChannel()
        {
            var res = Rtc.LeaveChannel();

            if (res == (int)ERROR_CODE.ERR_OK)
                IsJoin = false;

            return res;
        }
        #endregion

        #region Channel host
        public static bool JoinChannelHost(langHolder lh_holder)
        {
            return JoinChannelHost(lh_holder.langFull, lh_holder.token, 0, "");
        }
        public static bool JoinChannelHost(string lpChannelName, string token, uint nUID, string info)
        {
            ERROR_CODE ret;
            LeaveHostChannel();

            m_channelHost = Rtc.CreateChannel(lpChannelName);
            m_channelHost.InitChannelEventHandler(hostHandler);
            m_channelHost.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);
            m_channelHost.SetDefaultMuteAllRemoteVideoStreams(false);

            ChannelMediaOptions options = new();
            options.autoSubscribeAudio = true;
            options.autoSubscribeVideo = true;

            ret = m_channelHost.JoinChannelWithUserAccount(token, NickName, options);
            //ERROR_CODE_TYPE ret = m_channelHost.JoinChannel(token, info, nUID, options);

            m_channelHostJoin = (0 == ret);
            //var code = m_channelHost.CreateDataStream(out _hostStreamID, true, true);

            return 0 == ret;
        }
        public static void LeaveHostChannel()
        {
            if (m_channelHostJoin)
                m_channelHost?.LeaveChannel();
            m_channelHostJoin = false;
        }
        #endregion

        internal static void UpdateTargRoom(string langFull)
        {
            if (langFull != string.Empty)
                langFull = langFull.Remove(3, 2);

            RoomTarg = langFull;
        }

        public static void SendMessageToHost(string msg)
        {
            Rtc.SendStreamMessage(_hostStreamID, utf8enc.GetBytes(msg));
        }

        public static void SoftRelease() 
        {
            m_channelHost?.InitChannelEventHandler(null);
            m_channelHost?.LeaveChannel();
            m_channelHost?.Dispose();
            m_channelHost = null;

            Rtc.InitEventHandler(null);
        }
        public static void Release()
        {
            SoftRelease();

            Rtc.LeaveChannel();
            Rtc.Dispose();
            Rtc = null;
        }
    }
}