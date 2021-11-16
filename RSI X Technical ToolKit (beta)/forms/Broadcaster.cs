using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using RSI_X_Desktop.forms;
using agorartc;

namespace RSI_X_Desktop
{
    public partial class Broadcaster : Form, IFormHostHolder
    {
        internal static IntPtr LocalWinId;
        public IntPtr RemoteWnd { get => LocalWinId; }
        private Devices devices;
        private ScreenSharing sharingDig;
        private ChatWnd chat = new ChatWnd();

        private bool IsSharingScreen = false;

        public Broadcaster()
        {
            InitializeComponent();
            AgoraObject.SetWndEventHandler(this);
            LocalWinId = pictureBoxRemoteVideo.Handle;
        }

        private void Conference_Load(object sender, EventArgs e)
        {
            AgoraObject.Rtc.EnableVideo();
            AgoraObject.Rtc.SetChannelProfile(CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_LIVE_BROADCASTING);
            AgoraObject.Rtc.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);
            AgoraObject.Rtc.EnableLocalVideo(true);

            this.DoubleBuffered = true;
            var ret = AgoraObject.JoinChannel(
                AgoraObject.GetComplexToken().GetHostName,
                AgoraObject.GetComplexToken().GetToken);

            AgoraObject.MuteLocalAudioStream(false);
            AgoraObject.MuteLocalVideoStream(false);
            SetLocalVideoPreview();
        }
        public void SetLocalVideoPreview()
        {
            AgoraObject.Rtc.EnableLocalVideo(true);
            pictureBoxRemoteVideo.Refresh();

            var canv = new VideoCanvas((ulong)LocalWinId, 0);
            canv.renderMode = ((int)RENDER_MODE_TYPE.RENDER_MODE_FIT);

            AgoraObject.Rtc.SetupLocalVideo(canv);
            AgoraObject.Rtc.StartPreview();
        }
        public void UpdateLocalWnd()
        {
            pictureBoxRemoteVideo.Refresh();
        }
        private void Broadcaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            AgoraObject.LeaveChannel();
            Owner.Show();
        }
        private void btnScreenShare_Click(object sender, EventArgs e)
        {
            IsSharingScreen = !IsSharingScreen;

            if (IsSharingScreen)
            {
                if (sharingDig != null && !sharingDig.IsDisposed && sharingDig.Visible)
                    sharingDig.Close();

                sharingDig = new()
                {
                    StartPosition = FormStartPosition.CenterParent,
                    Visible = true,
                    //FormBorderStyle = FormBorderStyle.FixedSingle
                };
                //AgoraObject.EnableScreenCapture();
            }
            else
            {
                AgoraObject.Rtc.StopScreenCapture();
                ((PictureBox)sender).BackgroundImage = Properties.Resources.screen_share;
            }
        }
        private void CloseAppButton_Click(object sender, EventArgs e)
        {
            Owner.Close();
        }
        private void CloseButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void labelSettings_Click(object sender, EventArgs e)
        {
            if (chat.Visible == true)
            {
                ChatClosed(chat);
            }

            if (devices == null || devices.IsDisposed)
            {
                devices = new Devices();
                devices.Location = new Point(150, 0);
                CallSidePanel(devices);
                devices.typeOfAlligment(true);
                //devices.SetAudienceSettings();
                labelSettings.ForeColor = Color.Red;
            }
            else
            {
                DevicesClosed(devices);
                labelSettings.ForeColor = Color.White;
            }
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            labelSettings_Click(SettingButton, e);
        }
        private void CallSidePanel(Form wnd) 
        {
            wnd.Show();
        }
        public void GetMessage(string message, string nickname, CHANNEL_TYPE channel)
        {
            if (chat != null && chat.IsHandleCreated)
                chat.chat_NewMessageInvoke(message, nickname, channel);
        }
        private void ChatClosed(Form wnd) 
        {
            wnd.Close();
        }
        public void DevicesClosed(Form wnd) 
        { 
            wnd.Close();
        }
        //private void trackBar1_ValueChanged()
        //{
        //    Devices.SetVolume(trackBar1.Value);
        //    if (devices != null && devices.IsDisposed == false)
        //        devices.UpdateSoundTrackBar();
        //}
        public void SetTrackBarVolume(int volume)
        {
            trackBar1.Value = volume;
        }

        private void labelVolume_Click(object sender, EventArgs e)
        {
            trackBar1.Show();
        }
    }
}
