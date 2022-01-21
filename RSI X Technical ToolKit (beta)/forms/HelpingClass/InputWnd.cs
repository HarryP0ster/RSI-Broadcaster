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
    public partial class InputWnd : Form
    {
        internal string RoomCode
        {
            get => NewTextBox.Text;
        }
        public InputWnd()
        {
            InitializeComponent();

            int dpi = NewTextBox.DeviceDpi;
            Font font = Constants.Bahnschrift24;

            if (dpi >= (int)Constants.DPI.P175)
                font = Constants.Bahnschrift16;
            else if (dpi >= (int)Constants.DPI.P150)
                font = Constants.Bahnschrift18;
            else if (dpi >= (int)Constants.DPI.P125)
                font = Constants.Bahnschrift20;
            else if (dpi >= (int)Constants.DPI.P100)
                font = Constants.Bahnschrift24;
            
            NewTextBox.Font = font;
        }

        private void InputWnd_Load(object sender, EventArgs e)
        {
            Location = Owner.Location;
            Owner.LocationChanged += delegate { Location = Owner.Location; };
            Owner.VisibleChanged += delegate { Visible = Owner.Visible; };
        }

        private void NewTextBox_Click(object sender, EventArgs e)
        {
        }

        private void InputWnd_Shown(object sender, EventArgs e)
        {
            NewTextBox.Focus();
        }
    }
}