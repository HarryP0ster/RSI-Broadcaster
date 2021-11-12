namespace RSI_X_Desktop.forms
{
    partial class Broadcaster
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Broacaster = new ReaLTaiizor.Forms.FormTheme();
            this.SuspendLayout();
            // 
            // Broacaster
            // 
            this.Broacaster.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.Broacaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Broacaster.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Broacaster.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.Broacaster.Location = new System.Drawing.Point(0, 0);
            this.Broacaster.Name = "Broacaster";
            this.Broacaster.Padding = new System.Windows.Forms.Padding(3, 28, 3, 28);
            this.Broacaster.Sizable = true;
            this.Broacaster.Size = new System.Drawing.Size(800, 450);
            this.Broacaster.SmartBounds = false;
            this.Broacaster.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultLocation;
            this.Broacaster.TabIndex = 0;
            this.Broacaster.Text = "formTheme1";
            // 
            // Broadcaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Broacaster);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(126, 50);
            this.Name = "Broadcaster";
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Forms.FormTheme Broacaster;
    }
}