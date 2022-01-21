using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RSI_X_Desktop.forms.HelpingClass
{
    public partial class LoginWnd : DevExpress.XtraEditors.XtraForm
    {
        internal InputWnd loginInput;
        bool EnableCam = true;
        bool EnableMic = true;
        public LoginWnd()
        {
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            InitializeComponent();

            int dpi = HostRadio.DeviceDpi;
            Font font = Constants.Bahnschrift12;

            if (dpi >= (int)Constants.DPI.P175)
                font = Constants.BahnschriftBold8;
            else if (dpi >= (int)Constants.DPI.P150)
                font = Constants.BahnschriftBold8;
            else if (dpi >= (int)Constants.DPI.P125)
                font = Constants.BahnschriftBold10;
            else if (dpi >= (int)Constants.DPI.P100)
                font = Constants.BahnschriftBold12;

            HostRadio.Font = font;
            PresidentRadio.Font = font;
            SecretaryRadio.Font = font;
        }

        private void LoginWnd_Load(object sender, EventArgs e)
        {
            Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2, Owner.Location.Y + Owner.Height / 2 - Height / 2);
            Owner.LocationChanged += delegate { Location = new Point(Owner.Location.X + Owner.Width / 2 - Width / 2, Owner.Location.Y + Owner.Height / 2 - Height / 2); };
            (loginInput = new()).Show(this);
            SuspendLayout();

            loginInput.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
        }

        private void svgImageBox2_Click(object sender, EventArgs e)
        {
            string code = loginInput.NewTextBox.Text.Remove(4, 1);
            if (AgoraObject.JoinRoom(code))
            {
                loginInput.Hide();
                Owner.Hide();
                Hide();
                Broadcaster broadcaster = new();
                AgoraObject.CurrentForm = CurForm.FormBroadcaster;
                AgoraObject.MuteLocalVideoStream(!EnableCam);
                AgoraObject.MuteLocalAudioStream(!EnableMic);
                broadcaster.Show(Owner);
            }
            else
                loginInput.NewTextBox.Clear();
        }

        private void camRadio_Click(object sender, EventArgs e)
        {
            EnableCam = !EnableCam;

            camRadio.ItemAppearance.Normal.FillColor = EnableCam ? Color.White : Color.Empty;
        }

        private void micRadio_Click(object sender, EventArgs e)
        {
            EnableMic = !EnableMic;

            micRadio.ItemAppearance.Normal.FillColor = EnableMic ? Color.White : Color.Empty;
        }

        private void HostRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                AgoraObject.joinType = HostType.Broadcaster;
        }

        private void PresidentRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                AgoraObject.joinType = HostType.President;
        }

        private void SecretaryRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (((RadioButton)sender).Checked)
                AgoraObject.joinType = HostType.Secretary;
        }
    }
}