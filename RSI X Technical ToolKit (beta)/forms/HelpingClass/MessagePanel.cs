﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReaLTaiizor.Controls;

namespace RSI_X_Desktop.forms.HelpingClass
{
    public partial class MessagePanelL : System.Windows.Forms.TableLayoutPanel
    {
        public const string MyOwn = "Me";
        const int maxSymbol = 25;
        ChatBubbleLeft labelL;
        ChatBubbleRight labelR;
        Label Sender;
        Label Date;
        int actual_width = 20;
        Control Owner;

        public int ActualWidth
        {
            get => actual_width;
        }
        public MessagePanelL(string text, string sender, Control owner)
        {
            Owner = owner;
            this.AutoSize = true;
            Width = ((Control)owner).Width;
            Height = 65;
            Sender = new Label();

            Sender.Text = sender;
            Sender.AutoSize = true;
            Sender.TextAlign = ContentAlignment.BottomLeft;
            BackColor = Color.FromArgb(240, 240, 240);
            RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            RowStyles.Add(new RowStyle(SizeType.AutoSize, 100));

            //Date = new Label();

            if (sender == MyOwn)
            {
                ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                ColumnStyles[0].SizeType = SizeType.Percent;
                ColumnStyles[0].Width = 100;
                labelR = new ChatBubbleRight();
                labelR.SizeAuto = true;
                labelR.SizeAutoW = true;
                labelR.SizeAutoH = true;
                labelR.SizeChanged += Bubble_SizeChanged;
                labelR.Margin = new Padding(0, 0, 13, 0);
                Sender.TextAlign = ContentAlignment.BottomRight;

                if (text.Length > 0) labelR.Text += text[0];

                labelR.Text = text;

                for (int i = maxSymbol - 1; i < text.Length; i += maxSymbol)
                {
                    labelR.Text = labelR.Text.Insert(i, " \n");
                }

                labelR.Show();
                Name = "Right";
                Controls.Add(labelR, 1, 1);
                Controls.Add(Sender, 1, 0);
                labelR.SuspendLayout();
                labelR.Enabled = false;
                Sender.SuspendLayout();
            }
            else
            {
                labelL = new ChatBubbleLeft();
                labelL.SizeAuto = true;
                labelL.SizeAutoW = true;
                labelL.SizeAutoH = true;
                labelL.SizeChanged += Bubble_SizeChanged;

                if (text.Length > 0) labelL.Text += text[0];

                labelL.Text = text + " ";

                for (int i = maxSymbol - 1; i < text.Length; i += maxSymbol)
                {
                    labelL.Text = labelL.Text.Insert(i, " \n");
                }
                labelL.Show();
                Name = "Left";
                Controls.Add(labelL, 0, 1);
                Controls.Add(Sender, 0, 0);
                labelL.SuspendLayout();
                labelL.Enabled = false;
                Sender.SuspendLayout();
            }
        }

        public void Bubble_SizeChanged(object sender, EventArgs e)
        {
            actual_width = ((Control)sender).Width + 25;
            Location = new Point(5, Owner.Height - Height);
            (AgoraObject.GetWorkForm as Broadcaster).RebuildChatPanel(Owner);
        }
    }
}
