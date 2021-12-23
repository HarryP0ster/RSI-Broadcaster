using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using agora.rtc;
using System.Windows.Forms;


namespace RSI_X_Desktop
{
    public enum CHANNEL_TYPE
    {
        SRC,
        TRANSL,
        DEST,
        HOST,
    };
    public class AGChannelEventHandler : IAgoraRtcChannelEventHandler
    {
        internal List<uint> hostBroacsters = new();
        private IFormHostHolder form;
        public CHANNEL_TYPE chType { get; private set; }

        public AGChannelEventHandler(IFormHostHolder form_new, CHANNEL_TYPE new_chType)
        {
            form = form_new;
            chType = new_chType;
        }

        public override void OnJoinChannelSuccess(string channelId, uint uid, int elapsed)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.TRANSL:
                    AgoraObject.UpdateClientID(uid.ToString());
                    AgoraObject.UpdateRoomName(channelId);
                    break;
                case CHANNEL_TYPE.HOST:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }

        public override void OnRejoinChannelSuccess(string channelId, uint uid, int elapsed)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.TRANSL:
                    AgoraObject.UpdateClientID(uid.ToString());
                    AgoraObject.UpdateRoomName(channelId);
                    break;
                case CHANNEL_TYPE.HOST:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }


        public override void OnLeaveChannel(string channelId, RtcStats stats)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.HOST:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }

        public override void OnClientRoleChanged(string channelId, CLIENT_ROLE_TYPE oldRole,
            CLIENT_ROLE_TYPE newRole)
        {
        }

        public override void OnUserJoined(string channelId, uint uid, int elapsed)
        {
            switch (chType) 
            {
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.HOST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }

        public override void OnUserOffline(string channelId, uint uid, USER_OFFLINE_REASON_TYPE reason)
        {
            switch (chType)
            {
                case CHANNEL_TYPE.HOST:
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }
        
        public override void OnRemoteVideoStateChanged(string channelId, uint uid, REMOTE_VIDEO_STATE state,
            REMOTE_VIDEO_STATE_REASON reason, int elapsed)
        {
            
            //TODO: добавить очистку окон коллег через state == REMOTE_VIDEO_STATE_STOPPED
            switch (state) {
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_DECODING:
                    FirstFrameDecoding(channelId, uid, reason);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_STOPPED:
                    VideoStreamHasStopped(channelId, uid, reason);
                    break;
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_FROZEN:
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_FAILED:
                case REMOTE_VIDEO_STATE.REMOTE_VIDEO_STATE_STARTING:
                    break;
                default:
                    break;

            }

        }

        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|
        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|
        private void VideoStreamHasStopped(string channelId, uint uid, REMOTE_VIDEO_STATE_REASON reason)
        {
            UserInfo user;
            AgoraObject.Rtc.GetUserInfoByUid(uid, out user);

            switch (chType)
            {
                case CHANNEL_TYPE.HOST:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }

        private void FirstFrameDecoding(string channelId, uint uid, REMOTE_VIDEO_STATE_REASON reason)
        {
            UserInfo user;
            AgoraObject.Rtc.GetUserInfoByUid(uid, out user);

            VideoCanvas canv;

            switch (chType)
            {
                case CHANNEL_TYPE.HOST:
                case CHANNEL_TYPE.TRANSL:
                case CHANNEL_TYPE.DEST:
                case CHANNEL_TYPE.SRC:
                default:
                    break;
            }
        }
        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|
        //|ZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZZ|

        public string message = "";

        public override void
            OnStreamMessage(string channelId, uint uid, int streamId, byte[] data, uint length)
        {
            UserInfo name;
            string Message = AgoraObject.utf8enc.GetString(data);

            AgoraObject.Rtc.GetUserInfoByUid(uid, out name);
            string UserName = name.userAccount;
            var formInterpr = (form as Broadcaster);
            formInterpr.GetMessage(Message, UserName, chType);
        }
    }

}
