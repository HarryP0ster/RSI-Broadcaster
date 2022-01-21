
namespace RSI_X_Desktop.forms.HelpingClass
{
    partial class LoginWnd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginWnd));
            this.LoginTextBox = new DevExpress.XtraEditors.SvgImageBox();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.HostRadio = new System.Windows.Forms.RadioButton();
            this.PresidentRadio = new System.Windows.Forms.RadioButton();
            this.SecretaryRadio = new System.Windows.Forms.RadioButton();
            this.micRadio = new DevExpress.XtraEditors.SvgImageBox();
            this.camRadio = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox2 = new DevExpress.XtraEditors.SvgImageBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.NameLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.camRadio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // LoginTextBox
            // 
            this.LoginTextBox.BackColor = System.Drawing.Color.Transparent;
            this.LoginTextBox.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.TextBoxShadow;
            this.LoginTextBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel1.SetColumn(this.LoginTextBox, 0);
            this.LoginTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LoginTextBox.ItemAppearance.Normal.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(89)))), ((int)(((byte)(67)))), ((int)(((byte)(80)))));
            this.LoginTextBox.Location = new System.Drawing.Point(15, 180);
            this.LoginTextBox.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.LoginTextBox.Name = "LoginTextBox";
            this.tablePanel1.SetRow(this.LoginTextBox, 3);
            this.LoginTextBox.Size = new System.Drawing.Size(320, 90);
            this.LoginTextBox.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.LoginTextBox.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("LoginTextBox.SvgImage")));
            this.LoginTextBox.TabIndex = 1;
            this.LoginTextBox.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel1.Controls.Add(this.tableLayoutPanel1);
            this.tablePanel1.Controls.Add(this.micRadio);
            this.tablePanel1.Controls.Add(this.camRadio);
            this.tablePanel1.Controls.Add(this.svgImageBox2);
            this.tablePanel1.Controls.Add(this.pictureBox1);
            this.tablePanel1.Controls.Add(this.NameLabel);
            this.tablePanel1.Controls.Add(this.LoginTextBox);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F)});
            this.tablePanel1.Size = new System.Drawing.Size(350, 450);
            this.tablePanel1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tablePanel1.SetColumn(this.tableLayoutPanel1, 0);
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel1.Controls.Add(this.HostRadio, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.PresidentRadio, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.SecretaryRadio, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 125);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tablePanel1.SetRow(this.tableLayoutPanel1, 2);
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(350, 50);
            this.tableLayoutPanel1.TabIndex = 96;
            // 
            // HostRadio
            // 
            this.HostRadio.AutoSize = true;
            this.HostRadio.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.HostRadio.Checked = true;
            this.HostRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HostRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HostRadio.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HostRadio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.HostRadio.Location = new System.Drawing.Point(3, 3);
            this.HostRadio.Name = "HostRadio";
            this.HostRadio.Size = new System.Drawing.Size(110, 44);
            this.HostRadio.TabIndex = 0;
            this.HostRadio.TabStop = true;
            this.HostRadio.Text = "Broadcaster";
            this.HostRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.HostRadio.UseVisualStyleBackColor = true;
            this.HostRadio.CheckedChanged += new System.EventHandler(this.HostRadio_CheckedChanged);
            // 
            // PresidentRadio
            // 
            this.PresidentRadio.AutoSize = true;
            this.PresidentRadio.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.PresidentRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PresidentRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PresidentRadio.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PresidentRadio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.PresidentRadio.Location = new System.Drawing.Point(119, 3);
            this.PresidentRadio.Name = "PresidentRadio";
            this.PresidentRadio.Size = new System.Drawing.Size(110, 44);
            this.PresidentRadio.TabIndex = 1;
            this.PresidentRadio.TabStop = true;
            this.PresidentRadio.Text = "President";
            this.PresidentRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.PresidentRadio.UseVisualStyleBackColor = true;
            this.PresidentRadio.CheckedChanged += new System.EventHandler(this.PresidentRadio_CheckedChanged);
            // 
            // SecretaryRadio
            // 
            this.SecretaryRadio.AutoSize = true;
            this.SecretaryRadio.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SecretaryRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SecretaryRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SecretaryRadio.Font = new System.Drawing.Font("Bahnschrift SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SecretaryRadio.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SecretaryRadio.Location = new System.Drawing.Point(235, 3);
            this.SecretaryRadio.Name = "SecretaryRadio";
            this.SecretaryRadio.Size = new System.Drawing.Size(112, 44);
            this.SecretaryRadio.TabIndex = 2;
            this.SecretaryRadio.TabStop = true;
            this.SecretaryRadio.Text = "Secretary";
            this.SecretaryRadio.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SecretaryRadio.UseVisualStyleBackColor = true;
            this.SecretaryRadio.CheckedChanged += new System.EventHandler(this.SecretaryRadio_CheckedChanged);
            // 
            // micRadio
            // 
            this.tablePanel1.SetColumn(this.micRadio, 0);
            this.micRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.micRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.micRadio.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.micRadio.ItemAppearance.Normal.FillColor = System.Drawing.Color.White;
            this.micRadio.Location = new System.Drawing.Point(20, 328);
            this.micRadio.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.micRadio.Name = "micRadio";
            this.tablePanel1.SetRow(this.micRadio, 5);
            this.micRadio.Size = new System.Drawing.Size(327, 44);
            this.micRadio.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("micRadio.SvgImage")));
            this.micRadio.TabIndex = 95;
            this.micRadio.Text = "svgImageBox3";
            this.micRadio.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.micRadio.Click += new System.EventHandler(this.micRadio_Click);
            // 
            // camRadio
            // 
            this.tablePanel1.SetColumn(this.camRadio, 0);
            this.camRadio.Cursor = System.Windows.Forms.Cursors.Hand;
            this.camRadio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.camRadio.ImageAlignment = System.Drawing.ContentAlignment.MiddleLeft;
            this.camRadio.ItemAppearance.Normal.FillColor = System.Drawing.Color.White;
            this.camRadio.Location = new System.Drawing.Point(20, 278);
            this.camRadio.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.camRadio.Name = "camRadio";
            this.tablePanel1.SetRow(this.camRadio, 4);
            this.camRadio.Size = new System.Drawing.Size(327, 44);
            this.camRadio.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("camRadio.SvgImage")));
            this.camRadio.TabIndex = 94;
            this.camRadio.Text = "svgImageBox1";
            this.camRadio.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.camRadio.Click += new System.EventHandler(this.camRadio_Click);
            // 
            // svgImageBox2
            // 
            this.svgImageBox2.BackColor = System.Drawing.Color.Transparent;
            this.svgImageBox2.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.TextBoxShadow;
            this.svgImageBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel1.SetColumn(this.svgImageBox2, 0);
            this.svgImageBox2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.svgImageBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.svgImageBox2.Location = new System.Drawing.Point(15, 380);
            this.svgImageBox2.Margin = new System.Windows.Forms.Padding(15, 5, 15, 5);
            this.svgImageBox2.Name = "svgImageBox2";
            this.tablePanel1.SetRow(this.svgImageBox2, 6);
            this.svgImageBox2.Size = new System.Drawing.Size(320, 65);
            this.svgImageBox2.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.svgImageBox2.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox2.SvgImage")));
            this.svgImageBox2.TabIndex = 93;
            this.svgImageBox2.UseDirectXPaint = DevExpress.Utils.DefaultBoolean.True;
            this.svgImageBox2.Click += new System.EventHandler(this.svgImageBox2_Click);
            // 
            // pictureBox1
            // 
            this.tablePanel1.SetColumn(this.pictureBox1, 0);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RSI_X_Desktop.Properties.Resources.logotype;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(5);
            this.pictureBox1.Name = "pictureBox1";
            this.tablePanel1.SetRow(this.pictureBox1, 0);
            this.pictureBox1.Size = new System.Drawing.Size(340, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.tablePanel1.SetColumn(this.NameLabel, 0);
            this.NameLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NameLabel.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NameLabel.ForeColor = System.Drawing.Color.White;
            this.NameLabel.Location = new System.Drawing.Point(3, 75);
            this.NameLabel.Name = "NameLabel";
            this.tablePanel1.SetRow(this.NameLabel, 1);
            this.NameLabel.Size = new System.Drawing.Size(344, 50);
            this.NameLabel.TabIndex = 3;
            this.NameLabel.Text = "RSI X BROADCASTER";
            this.NameLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // LoginWnd
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(46)))), ((int)(((byte)(62)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(350, 450);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IconOptions.Icon = ((System.Drawing.Icon)(resources.GetObject("LoginWnd.IconOptions.Icon")));
            this.Name = "LoginWnd";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.LoginWnd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LoginTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.micRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.camRadio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox2;
        internal DevExpress.XtraEditors.SvgImageBox LoginTextBox;
        private DevExpress.XtraEditors.SvgImageBox micRadio;
        private DevExpress.XtraEditors.SvgImageBox camRadio;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.RadioButton HostRadio;
        private System.Windows.Forms.RadioButton PresidentRadio;
        private System.Windows.Forms.RadioButton SecretaryRadio;
    }
}