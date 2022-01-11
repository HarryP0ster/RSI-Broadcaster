using System;
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
        readonly int maxSymbol;
        newRightBubble buble;
        Font font;
        Label Sender;
        Control Owner;

        public MessagePanelL(string text, string sender, Control owner)
        {
            int dpi = this.DeviceDpi;

            if (dpi >= (int)Constants.DPI.P175){
                font = Constants.Bahnschrift10;
                maxSymbol = 14;
            }
            else if (dpi >= (int)Constants.DPI.P150){
                font = Constants.Bahnschrift12;
                maxSymbol = 15;
            }
            else if (dpi >= (int)Constants.DPI.P125){
                font = Constants.Bahnschrift14;
                maxSymbol = 20;
            }
            else if (dpi >= (int)Constants.DPI.P100) {
                font = Constants.Bahnschrift14;
                maxSymbol = 25;
            }

            Owner = owner;
            Owner.SizeChanged += delegate
            {
                Width = Owner.Width;
            };
            this.AutoSize = true;
            Width = Owner.Width;
            Height = 65;
            Sender = new Label();

            Sender.Text = sender;
            Sender.AutoSize = true;
            Sender.TextAlign = ContentAlignment.BottomLeft;
            Sender.Font = font;
            BackColor = Color.White;
            RowStyles.Add(new RowStyle(SizeType.Absolute, 25));
            RowStyles.Add(new RowStyle(SizeType.AutoSize, 100));

            //Date = new Label();

            for (int i = maxSymbol; i < text.Length; i += maxSymbol + 1)
                text = text.Insert(i, "\n");

            buble = new newRightBubble();
            if (sender == MyOwn)
            {
                ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
                ColumnStyles[0].SizeType = SizeType.Percent;
                ColumnStyles[0].Width = 100;
                buble.ForeColor = Color.White;
                buble.ArrowRight = true;
                buble.BubbleColor = Color.FromArgb(254, 1, 143);
                buble.Margin = new Padding(0, 0, 13, 0);
                Sender.TextAlign = ContentAlignment.BottomRight;
                Sender.Dock = DockStyle.Right;
                Sender.Text += "\t";
                Name = "Right";
                Controls.Add(buble, 1, 1);
                Controls.Add(Sender, 1, 0);
            }
            else
            {
                buble.BubbleColor = Color.FromArgb(217, 217, 217);
                buble.ArrowRight = false;

                Name = "Left";
                Controls.Add(buble, 0, 1);
                Controls.Add(Sender, 0, 0);
            }
            buble.Text = text;
            buble.Show();
            buble.SuspendLayout();
            buble.Enabled = false;
            Sender.SuspendLayout();
        }
    }
}
