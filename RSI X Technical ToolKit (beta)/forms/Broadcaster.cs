using System;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using RSI_X_Desktop.forms;
using RSI_X_Desktop.forms.HelpingClass;
using agora.rtc;

namespace RSI_X_Desktop
{
    public partial class Broadcaster : Form, IFormHostHolder
    {
        private readonly forms.HelpingClass.FireBaseReader GetFireBase = new();
        internal static IntPtr LocalWinId;
        public IntPtr RemoteWnd { get => LocalWinId; }
        private PopUpForm devices;
        private ChatWnd chat = new ();
        internal Designer ExternWnd = new();
        BottomPanelWnd bottomPanel = new();

        public Broadcaster()
        {
            InitializeComponent();
            AgoraObject.SetWndEventHandler(this);
            LocalWinId = pictureBoxRemoteVideo.Handle;
            Devices.SetupOldDevices();

        }

        private void Conference_Load(object sender, EventArgs e)
        {
            AgoraObject.Rtc.EnableVideo();
            AgoraObject.Rtc.EnableAudio();
            AgoraObject.Rtc.SetChannelProfile(CHANNEL_PROFILE_TYPE.CHANNEL_PROFILE_LIVE_BROADCASTING);
            AgoraObject.Rtc.SetClientRole(CLIENT_ROLE_TYPE.CLIENT_ROLE_BROADCASTER);
            AgoraObject.Rtc.EnableLocalVideo(true);

            this.DoubleBuffered = true;
            AgoraObject.JoinChannel();

            AgoraObject.MuteLocalAudioStream(false);
            AgoraObject.MuteLocalVideoStream(false);

            SetLocalVideoPreview();
            StreamLayout.ColumnStyles[1].SizeType = SizeType.Absolute;
            StreamLayout.ColumnStyles[0].Width = 100;
            StreamLayout.ColumnStyles[1].Width = 0;

            GetFireBase.SetChannelName(
                AgoraObject.GetComplexToken().GetHostName);
            chat.HandleCreated += (s, e) => {
                chat.UpdateFireBase(GetFireBase);
                GetFireBase.Connect();
            };

            /*
            * Chat initial loading, this way it'd load messages
            * in the background from the very moment you enter a channel
            */
            chat.TopLevel = false;
            chat.Dock = DockStyle.Fill;
            panel1.Controls.Add(chat);
            chat.Show();
            chat.Hide(); //You need to hide it, otherwise Animator'd get confused

            bottomPanel.Width = Width;
            bottomPanel.Height = 125;
            bottomPanel.Location = new Point(Location.X, Location.Y + Height);
            bottomPanel.Show(this);
            bottomPanel.Enabled = false;
            ExternWnd.Show(this);

            pictureBoxRemoteVideo.Click += Mouse_Click;
            pictureBoxRemoteVideo.MouseMove += Mouse_MouseMove;
            PanelNothing.Click += Mouse_Click;
            PanelNothing.MouseMove += Mouse_MouseMove;
        }

        public void SetLocalVideoPreview()
        {
            pictureBoxRemoteVideo.Refresh();

            var canv = new VideoCanvas((ulong)LocalWinId, 0);
            canv.renderMode = ((int)RENDER_MODE_TYPE.RENDER_MODE_FIT);
            ImageSender.SetLocalCanvas(this);

            AgoraObject.Rtc.SetupLocalVideo(canv);
            AgoraObject.Rtc.StartPreview();

            pictureBoxRemoteVideo.BackgroundImage = null;
        }
        public void RefreshLocalWnd()
        {
            pictureBoxRemoteVideo.Refresh();
        }
        public void InvokeSetLocalFrame(Bitmap bmp) 
        {
            if (IsDisposed || Disposing) return;
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate
                {
                    SetLocalFrame(bmp);
                });
            else { SetLocalFrame(bmp); }
            
        }
        private void SetLocalFrame(Bitmap bmp)
        {
            pictureBoxRemoteVideo.BackColor = bmp != null ?
                Color.Silver : Color.FromArgb(85, 85, 85);

            //pictureBoxRemoteVideo.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxRemoteVideo.Image = bmp;
        }

        public void InvokeUpdateColors() 
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate
                {
                    UpdateColors();
                });
            else
            {
                UpdateColors();
            }
        }
        private void UpdateColors() 
        {
            //labelScreenShare.ForeColor = ScreenCapture.IsCapture ? Color.Red : Color.White; ;
        }
        public void ExitApp()
        {
            ExternWnd.Hide();
            bottomPanel.Hide();
            Hide();

            AgoraObject.LeaveHostChannel();
            AgoraObject.MuteAllRemoteAudioStream(false);
            AgoraObject.MuteAllRemoteVideoStream(false);

            //PopUpForm.waveOutSetVolume(IntPtr.Zero, uint.MaxValue);

            Owner.Show();
            Owner.Refresh();
        }

        private void CallSidePanel(Form Wnd)
        {
            Wnd.TopLevel = false;
            Wnd.Dock = DockStyle.Fill;
            panel1.Controls.Add(Wnd);
            panel1.BringToFront();
            if (panel1.Visible == false || Wnd.Visible == false)
            {
                panel1.Location = new Point(Size.Width, panel1.Location.Y);
                panel1.Show();
                Animator(panel1, -45, 0, 10, 1);
                Wnd.Show();
            }
        }

        public void Animator(System.Windows.Forms.Panel panel, int offset_x, int offset_y, int itterations, int delay)
        {
            Thread.Sleep(delay);
            panel.SuspendLayout();
            for (int ind = 0; ind < itterations; ind++)
            {
                StreamLayout.ColumnStyles[1].Width = StreamLayout.ColumnStyles[1].Width - offset_x;
                Update();
            }
            panel.ResumeLayout();
        }

        public void RebuildChatPanel(Control panel)
        {
            chat.Chat_SizeChanged(panel, new EventArgs());
        }
        private void ChatClosed(Form Wnd)
        {
            Animator(panel1, 45, 0, 10, 1);
            panel1.Hide();
            Wnd.Hide();
            Wnd.SuspendLayout();
            GC.Collect();
        }
        public void DevicesClosed(Form Wnd)
        {
            Animator(panel1, 45, 0, 10, 1);
            panel1.Hide();
            Wnd.Close();
            GC.Collect();
        }

        public void GetMessage(string message, string nickname, CHANNEL_TYPE channel)
        {
            if (chat != null && chat.IsHandleCreated)
                chat.chat_NewMessageInvoke(message, nickname, channel);
        }

        private void labelChat_Click(object sender, EventArgs e)
        {
            if (devices != null && !(devices.IsDisposed))
                DevicesClosed(devices);
            if (chat.Visible == false)
            {
                chat.ResumeLayout();
                chat.ButtonsVisibility(true);
                CallSidePanel(chat);
            }
            else
            {
                chat.ButtonsVisibility(false);
                ChatClosed(chat);
            }
        }
        private void labelSettings_Click(object sender, EventArgs e)
        {
            if (chat.Visible == true)
            {
                ChatClosed(chat);
            }

            if (devices == null || devices.IsDisposed)
            {
                BlurWnd blur = new();
                devices = new PopUpForm();
                blur.Show(this);
                devices.ShowDialog(this);
                SetLocalVideoPreview();
                devices.Dispose();
                blur.Dispose();
                Focus();
            }
            else
            {
                devices.Dispose();
            }
        }
        internal void SettingButton_Click(object sender, EventArgs e)
        {
            labelSettings_Click(sender, e);
        }
        private void nightControlBox1_MouseClick(object sender, MouseEventArgs e)
        {
            Point ptn = e.Location;
            if (!(ptn.X > 46 && ptn.X < 94)) return;
            this.BringToFront();
            if (this.Size.Width == 1280)
            {
                ResizeForm(Screen.PrimaryScreen.WorkingArea.Size, this);
                ResizeForm(Screen.PrimaryScreen.WorkingArea.Size, formTheme1);
            }
            else
            {
                ResizeForm(new Size(1280, 800), this);
                ResizeForm(new Size(1280, 800), formTheme1);
            }
        }
        
        private void Broadcaster_FormClosed(object sender, FormClosedEventArgs e)
        {
            ExternWnd.enableScreenShare(false);

            if (ImageSender.IsEnable)
            {
                ImageSender.configImageToSend(null);
                ImageSender.EnableImageSender(false);
                ImageSender.Dispose();
            }

            AgoraObject.SoftRelease();

            AgoraObject.LeaveChannel();
            AgoraObject.Rtc.EnableLocalVideo(false);
            AgoraObject.Rtc.DisableVideo();
            AgoraObject.Rtc.DisableAudio();
            Devices.Clear();

            if (!Owner.Visible) Application.Exit();
            GC.Collect();
        }

        private void ResizeForm(Size size, Form target)
        {
            target.MaximumSize = size;
            target.MinimumSize = size;
            target.Size = size;

            GC.Collect();
        }
        private void ResizeForm(Size size, ReaLTaiizor.Forms.FormTheme target)
        {
            target.MaximumSize = size;
            target.MinimumSize = size;
            target.Size = size;

            GC.Collect();
        }

        private void Mouse_Click(object sender, EventArgs e)
        {
            if (ExternWnd.LabelAudioRect.Contains(Cursor.Position))
                ExternWnd.labelMicrophone_Click(sender, e);
            else if (ExternWnd.LabelVideoRect.Contains(Cursor.Position))
                ExternWnd.labelVideo_Click(sender, e);
            else if (ExternWnd.DevicesLblRect.Contains(Cursor.Position))
                SettingButton_Click(sender, e);
            else if (ExternWnd.ScreenShareRectangle.Contains(Cursor.Position))
                ExternWnd.btnScreenShare_Click(sender, e);
            else if (ExternWnd.ChatRect.Contains(Cursor.Position))
                ExternWnd.Chat_Click(sender, e);

            if (ExternWnd.HomeBtnRect.Contains(Cursor.Position))
                ExternWnd.HomeBtn_Click(null, null);
        }
        private void Mouse_MouseMove(object sender, MouseEventArgs e)
        {
            if (Disposing || IsDisposed ||
                ExternWnd.Disposing || ExternWnd.IsDisposed)
            {
                Close();
                return;
            }

            bool cursorUpd = false;
            if (ExternWnd.LabelAudioRect.Contains(Cursor.Position))
            {
                ExternWnd.audioLabel_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.audioLabel_MouseLeave(sender, e);

            if (ExternWnd.LabelVideoRect.Contains(Cursor.Position))
            {
                ExternWnd.videoLabel_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.videoLabel_MouseLeave(sender, e);

            if (ExternWnd.DevicesLblRect.Contains(Cursor.Position))
            {
                ExternWnd.devicesLabel_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.devicesLabel_MouseLeave(sender, e);

            if (ExternWnd.ScreenShareRectangle.Contains(Cursor.Position))
            {
                ExternWnd.ScreenShare_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.ScreenShare_MouseLeave(sender, e);

            if (ExternWnd.ChatRect.Contains(Cursor.Position))
            {
                ExternWnd.Chat_MouseMove(sender, e);
                cursorUpd = true;
            }
            else
                ExternWnd.Chat_MouseLeave(sender, e);

            Cursor.Current = cursorUpd ? Cursors.Hand : Cursors.Default;
        }

        private void nightControlBox1_MouseMove(object sender, MouseEventArgs e)
        {
            GC.Collect();
        }
    }
}
