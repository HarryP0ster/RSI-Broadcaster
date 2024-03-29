﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using DevExpress.Utils.Svg;
using System.Windows.Forms;

namespace RSI_X_Desktop.forms.HelpingClass
{
    enum PANEL
    {
        GENERAL = 0,
        SUPPORT
    }
    public partial class ChatForm : DevExpress.XtraEditors.XtraForm
    {
        private static ChatForm instance_;

        const int TAB_COUNT = 2;
        int[] scroll_offset = new int[TAB_COUNT * 2];
        List<Control>[] messages_list = new List<Control>[TAB_COUNT];
        bool[] ScrollEnabled = new bool[2] { false, false };
        ReaLTaiizor.Controls.PoisonScrollBar[] chat_scrolls = new ReaLTaiizor.Controls.PoisonScrollBar[2];
        Control[] scrolls = new Control[TAB_COUNT];

        FireBaseReader FireBase;

        PANEL CurPanel;
        Padding MarginNormal = new Padding(10);
        Padding Hovered = new Padding(8);

        ToolTip GlobalTip = new();
        ToolTip SupportTip = new();

        public ChatForm()
        {
            InitializeComponent();

            scrolls[(int)PANEL.GENERAL] = GeneralScroll;
            scrolls[(int)PANEL.SUPPORT] = SupportScroll;
            GeneralScroll.Enabled = false;
            SupportScroll.Enabled = false;

            GlobalTip.SetToolTip(General, "Global chat");
            SupportTip.SetToolTip(Support, "Technical chat");

            Font font = Constants.Leelawadee14;
            int dpi = this.DeviceDpi;

            if (dpi >= (int)Constants.DPI.P175)
                font = Constants.Leelawadee10;
            else if (dpi >= (int)Constants.DPI.P150)
                font = Constants.Leelawadee12;
            else if (dpi >= (int)Constants.DPI.P125)
                font = Constants.Leelawadee12;
            else if (dpi >= (int)Constants.DPI.P100)
                font = Constants.Leelawadee14;
            ChatTextBox.Font = font;

            foreach (Control ctr in Controls)
            {
                ctr.KeyDown += Enter_KeyDown;
                try
                {
                    ctr.MouseWheel += Scrolled;
                }
                catch
                {

                }
            }
            for (int i = 0; i < TAB_COUNT; i++)
            {
                messages_list[i] = new List<Control>();
                scroll_offset[i] = 0;
            }
            chat_scrolls[0] = GeneralScroll;
            chat_scrolls[1] = SupportScroll;

            PGeneral.Resize += Chat_SizeChanged;
            PSupport.Resize += Chat_SizeChanged;

            instance_ = this;
        }

        private void ChatForm_Load(object sender, EventArgs e)
        {
            General_Click(null, null);
        }
        private void ChatWnd_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (FireBase != null)
                FireBase.OnNewMessage -= chat_NewMessageSupInvoke;
            Dispose();
        }

        private void Scrolled(object sender, System.Windows.Forms.MouseEventArgs e)
        {
            if (e.Delta > 0)
            {
                if (scroll_offset[(int)CurPanel] + 1 <= chat_scrolls[(int)CurPanel].Maximum && ScrollEnabled[(int)CurPanel])
                    scroll_offset[(int)CurPanel]++;
                else
                    return;
            }
            else
            {
                if (scroll_offset[(int)CurPanel] - 1 >= 0 && ScrollEnabled[(int)CurPanel])
                    scroll_offset[(int)CurPanel]--;
                else
                    return;
            }

            switch ((int)CurPanel)
            {
                case (int)PANEL.GENERAL:
                    chat_scrolls[(int)PANEL.GENERAL].Value = chat_scrolls[(int)PANEL.GENERAL].Maximum - scroll_offset[(int)PANEL.GENERAL];
                    Chat_SizeChanged(PGeneral, new EventArgs());
                    break;
                case (int)PANEL.SUPPORT:
                    chat_scrolls[(int)PANEL.SUPPORT].Value = chat_scrolls[(int)PANEL.SUPPORT].Maximum - scroll_offset[(int)PANEL.SUPPORT];
                    Chat_SizeChanged(PSupport, new EventArgs());
                    break;
            }
        }

        private void Enter_KeyDown(object sender, KeyEventArgs e)
        {
            if (ChatTextBox.Text != "" && e.KeyCode == Keys.Enter) 
            {
                chatButtonRight2_Click(sender, null);
                ChatTextBox.Text = "";
            }
        }

        private void ChatTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (ChatTextBox.Text != "" && e.KeyCode == Keys.Enter)
                ChatTextBox.Text = "";
        }
        private void chatButtonRight2_Click(object sender, EventArgs e)
        {
            string msg = ChatTextBox.Text;
            if (ChatTextBox.Text != "" && ChatTextBox.ForeColor != Color.FromArgb(185, 185, 185))
            {
                if (msg[0] == '\n' || msg[0] == (char)13)
                {
                    ChatTextBox.Text = "";
                    return;
                }
                if (CurPanel == PANEL.GENERAL)
                {
                    AgoraObject.SendMessageToHost(msg);
                    AddOwnMessageGeneral(msg);
                }
                else
                {
                    FireBase.SendMessage(msg);
                }
                ChatTextBox.Text = "";
            }
        }

        public void chat_NewMessageInvoke(string message, string nickname, CHANNEL_TYPE channel)
        {
            if (InvokeRequired)
                Invoke((MethodInvoker)delegate
                { chat_NewMessage(message, nickname, channel); });
            else
                chat_NewMessage(message, nickname, channel);
        }
        private void chat_NewMessage(string message, string nickname, CHANNEL_TYPE channel)
        {
            switch (channel)
            {
                case CHANNEL_TYPE.HOST:
                    RelocateBubbles(new MessagePanelL(message, NickCenter.GetNickHostFromMsg(nickname), PGeneral), PGeneral, (int)PANEL.GENERAL);
                    break;
            }
        }

        public void chat_NewMessageSupInvoke(object sender, HelpingClass.FireBaseUpdateEventArgs arg)
        {
            if (instance_ == null || instance_.IsDisposed || instance_.Disposing)
                return;
            if (instance_.InvokeRequired)
                instance_.Invoke((MethodInvoker)delegate
                { instance_.chat_NewMessageSup(sender, arg); });
            else
                instance_.chat_NewMessageSup(sender, arg);
        }
        public void chat_NewMessageSup(object sender, HelpingClass.FireBaseUpdateEventArgs arg)
        {
            string senderNick;
            if (IsHandleCreated)
            {
                senderNick = NickCenter.GetNickHostFromMsg(arg.Msg.username);
                RelocateBubbles(new MessagePanelL(arg.Msg.msg, senderNick, PSupport), PSupport, (int)PANEL.SUPPORT);
            }
        }
        private void AddOwnMessageGeneral(string msg)
        {
            RelocateBubbles(new MessagePanelL(msg, MessagePanelL.MyOwn, PGeneral), PGeneral, (int)PANEL.GENERAL);
        }

        private void RelocateBubbles(Control new_ctr, Control panel, int index)
        {
            //panel.Controls.Add(new_ctr);
            messages_list[index].Add(new_ctr);
            if (ScrollEnabled[index])
            {
                chat_scrolls[index].Maximum = messages_list[index].Count - scroll_offset[TAB_COUNT + index];
            }
            chat_scrolls[index].Value = chat_scrolls[index].Maximum - scroll_offset[index];
            Chat_SizeChanged(panel, new EventArgs());
        }

        public void UpdateFireBase(FireBaseReader FireBaseReader)
        {
            FireBase = FireBaseReader;
            FireBase.OnNewMessage += chat_NewMessageSupInvoke;
        }
        public void DisconnectFireBase()
        {
            if (FireBase != null)
                FireBase.OnNewMessage -= chat_NewMessageSupInvoke;
            FireBase = null;
        }

        internal void Chat_SizeChanged(object sender, EventArgs e) //Actually Updates chat wnd
        {
            if (sender == PGeneral && CurPanel != PANEL.GENERAL) return;
            if (sender == PSupport && CurPanel != PANEL.SUPPORT) return;
            if (Visible)
            {
                Control prev_ctr = null;
                ((Control)sender).Controls.Clear();
                int ind = (int)CurPanel;

                var controls = messages_list[ind].ToArray();


                for (int i = messages_list[ind].Count - 1 - scroll_offset[ind]; i >= 0; i--)
                {
                    if (prev_ctr != null)
                        controls[i].Location = new Point(controls[i].Location.X, prev_ctr.Location.Y - controls[i].Height);
                    else
                        controls[i].Location = new Point(controls[i].Location.X, ((Control)sender).Height - controls[i].Height - 5);

                    prev_ctr = controls[i];

                    ((Control)sender).Controls.Add(controls[i]);
                    ((Control)sender).Controls[((Control)sender).Controls.Count - 1].Update();
                    if (controls[i].Location.Y > ((Control)sender).Height || controls[i].Location.Y < 0)
                    {
                        if (!ScrollEnabled[ind])
                        {
                            scroll_offset[TAB_COUNT + ind] = ((Control)sender).Controls.Count - 1;
                            ScrollEnabled[ind] = true;
                            chat_scrolls[ind].Maximum = messages_list[ind].Count - scroll_offset[TAB_COUNT + ind];
                            chat_scrolls[ind].Value = chat_scrolls[ind].Maximum - scroll_offset[ind];
                            scrolls[ind].Enabled = true;
                        }
                        return;
                    }
                }
            }
        }

        private void UpdateSelectedPanel()
        {
            if (CurPanel == PANEL.GENERAL)
            {
                General.SvgImage = SvgImage.FromFile("Resources\\GeneralChatSelected.svg");
                Support.SvgImage = SvgImage.FromFile("Resources\\SupportChat.svg");
            }
            else
            {
                General.SvgImage = SvgImage.FromFile("Resources\\GeneralChat.svg");
                Support.SvgImage = SvgImage.FromFile("Resources\\SupportChatSelected.svg");
            }
        }

        internal void ButtonsVisibility(bool state)
        {
            //bigTextBox2.Visible = state;
            //chatButtonRight2.Visible = state;
            //bigTextBox3.Visible = state;
            //chatButtonRight3.Visible = state;
        }

        private void SupportScroll_ValueChanged(object sender, int newValue)
        {
            scroll_offset[1] = SupportScroll.Maximum - newValue;
            Chat_SizeChanged(PSupport, new EventArgs());
        }

        private void GeneralScroll_ValueChanged(object sender, int newValue)
        {
            scroll_offset[0] = GeneralScroll.Maximum - newValue;
            Chat_SizeChanged(PGeneral, new EventArgs());
        }

        private void bigTextBox2_Enter(object sender, EventArgs e)
        {
            ChatTextBox.ForeColor = Color.Black;
            if (ChatTextBox.Text == "Type in your message")
                ChatTextBox.Text = "";
        }

        private void bigTextBox2_Leave(object sender, EventArgs e)
        {
            ChatTextBox.ForeColor = Color.FromArgb(185, 185, 185);
            if (ChatTextBox.Text == "")
                ChatTextBox.Text = "Type in your message";
        }

        private void General_Click(object sender, EventArgs e)
        {
            CurPanel = PANEL.GENERAL;
            TablePanels.Columns[1].Width = 0;
            TablePanels.Columns[0].Width = 100;
            timer1.Start();
            Chat_SizeChanged(PGeneral, new());
            General.Enabled = false;
        }

        private void Support_Click(object sender, EventArgs e)
        {
            CurPanel = PANEL.SUPPORT;
            TablePanels.Columns[0].Width = 0;
            TablePanels.Columns[1].Width = 100;
            timer1.Start();
            Chat_SizeChanged(PSupport, new());
            Support.Enabled = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Point oldPos = Cursor.Position;
            timer1.Stop();
            Cursor.Hide();
            Cursor.Position = PointToScreen(new Point(Width / 2, Height / 2));
            UpdateSelectedPanel();
            Cursor.Show();
            Cursor.Position = oldPos;
            System.Threading.Thread.Sleep(100);
            General.Enabled = true;
            Support.Enabled = true;
        }

        private void SendMsgBtn_MouseHover(object sender, MouseEventArgs e)
        {
            SendMsgBtn.Margin = Hovered;
        }

        private void SendMsgBtn_MouseLeave(object sender, MouseEventArgs e)
        {
            SendMsgBtn.Margin = MarginNormal;
        }

        private void ChatClose_MouseEnter(object sender, EventArgs e)
        {
            ChatClose.ItemAppearance.Normal.FillColor = Color.FromArgb(200, 200, 200);
        }

        private void ChatClose_MouseLeave(object sender, EventArgs e)
        {
            ChatClose.ItemAppearance.Normal.FillColor = Color.Gray;
        }

        private void ChatClose_Click(object sender, EventArgs e)
        {
            AgoraObject.GetWorkForm?.CloseChat();
        }
    }
}