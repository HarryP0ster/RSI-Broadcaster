﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using RSI_X_Desktop.forms.HelpingClass;

namespace RSI_X_Desktop.forms
{
    public partial class EntranceForm : DevExpress.XtraEditors.XtraForm
    {
        LoginWnd loginWnd;
        TableLayoutPanel LoginTable = new();
        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, Int32 wMsg, bool wParam, Int32 lParam);
        public EntranceForm()
        {
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            InitializeComponent();
        }

        private void ShowLogin()
        {
            formTheme1.Controls.Remove(panel1);
            formTheme1.Controls.Add(LoginTable);
            loginWnd.Show(this);
        }

        private void EntranceForm_Load(object sender, EventArgs e)
        {
            LoginRegion();
            JoinBtn.Location = new Point(Width / 2 - JoinBtn.Width / 2, Height - Height / 2);
            JoinBtn.BringToFront();
            timer1.Start();
            Controls.Remove(LoginBackground);
            InitLoginTable();
            timer1_Tick(null, null);
        }

        private void EntranceForm_VisibleChanged(object sender, EventArgs e)
        {
            if (loginWnd != null)
            {
                loginWnd.Visible = Visible;
                loginWnd.loginInput.Visible = Visible;
            }
        }

        private void InitLoginTable()
        {
            LoginTable.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100));
            LoginTable.RowStyles.Add(new RowStyle(SizeType.Percent, 87));
            LoginTable.RowStyles.Add(new RowStyle(SizeType.Percent, 13));
            backButton.Dock = DockStyle.Left;
            LoginBackground.Anchor = AnchorStyles.Bottom;
            LoginBackground.Visible = true;
            backButton.Visible = true;
            backButton.BackColor = Color.Transparent;
            LoginTable.Controls.Add(LoginBackground, 0, 0);
            LoginTable.Controls.Add(backButton, 0, 1);
            LoginTable.Dock = DockStyle.Fill;
            LoginTable.BackgroundImage = Properties.Resources.BckgFade;
            LoginTable.BackgroundImageLayout = ImageLayout.Stretch;
            LoginTable.BackColor = Color.FromArgb(97, 54, 79);
            LoginTable.Paint += panel1_Paint;
        }

        private void JoinBtn_Click(object sender, EventArgs e)
        {
            ShowLogin();
        }

        private void EntranceForm_Shown(object sender, EventArgs e)
        {
            (loginWnd = new LoginWnd()).Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel1.SuspendLayout();
            TimeLabel.Text = DateTime.Now.ToString("HH:mm");
            string i = DateTime.Now.ToString("MM");
            string dm = "";
            switch (i)
            {
                case "01": dm = "January"; break;
                case "02": dm = "February"; break;
                case "03": dm = "March"; break;
                case "04": dm = "April"; break;
                case "05": dm = "May"; break;
                case "06": dm = "June"; break;
                case "07": dm = "July"; break;
                case "08": dm = "August"; break;
                case "09": dm = "September"; break;
                case "10": dm = "October"; break;
                case "11": dm = "November"; break;
                case "12": dm = "December"; break;
            }
            LocalTimeLabel.Text = DateTime.Now.DayOfWeek.ToString() + ", " + dm + " " + DateTime.Now.ToString("dd, yyyy");
            panel1.ResumeLayout(false);
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            loginWnd.Hide();
            SendMessage(this.Handle, 11, false, 0);
            formTheme1.Controls.Remove(LoginTable);
            formTheme1.Controls.Add(panel1);
            SendMessage(this.Handle, 11, true, 0);
            Refresh();
        }

        private void LoginRegion()
        {
            Region reg = new();
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            int d = 60;
            System.Drawing.Rectangle r = new System.Drawing.Rectangle(3, -4, LoginBackground.Width - 6, LoginBackground.Height - 3);
            path.AddArc(r.X, r.Y, d, d, 180, 90);
            path.AddArc(r.X + r.Width - d, r.Y, d, d, 270, 90);
            path.AddArc(r.X + r.Width - d, r.Y + r.Height - d, d, d , 0, 90);
            path.AddArc(r.X, r.Y + r.Height - d, d, d, 90, 90);
            reg = new Region(path);

            LoginBackground.Region = reg;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Font CommonFont = Constants.Bahnschrift12;
            Brush br = new SolidBrush(Color.LightGray);

            e.Graphics.TranslateTransform((sender as Control).Width - 140, (sender as Control).Height - 30);

            e.Graphics.DrawString("Build date DD :: MM :: YY", CommonFont, br, 0, 0);
        }
    }
}