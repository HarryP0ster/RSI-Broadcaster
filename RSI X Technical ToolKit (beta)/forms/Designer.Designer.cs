
namespace RSI_X_Desktop.forms
{
    partial class Designer
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Designer));
            this.MainLayout = new DevExpress.Utils.Layout.TablePanel();
            this.CenterPanel = new DevExpress.Utils.Layout.TablePanel();
            this.IconsPanel = new DevExpress.Utils.Layout.TablePanel();
            this.Chat = new DevExpress.XtraEditors.SvgImageBox();
            this.devicesLabel = new DevExpress.XtraEditors.SvgImageBox();
            this.signOff = new DevExpress.XtraEditors.SvgImageBox();
            this.ScreenShare = new DevExpress.XtraEditors.SvgImageBox();
            this.videoLabel = new DevExpress.XtraEditors.SvgImageBox();
            this.audioLabel = new DevExpress.XtraEditors.SvgImageBox();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.RoomNameLabel = new ReaLTaiizor.Controls.SkyLabel();
            this.LeftSidePanel = new DevExpress.XtraEditors.SidePanel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MainLayout)).BeginInit();
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CenterPanel)).BeginInit();
            this.CenterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconsPanel)).BeginInit();
            this.IconsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.signOff)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenShare)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.LeftSidePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.SuspendLayout();
            // 
            // MainLayout
            // 
            this.MainLayout.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.MainLayout.Appearance.Options.UseBackColor = true;
            this.MainLayout.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 90F)});
            this.MainLayout.Controls.Add(this.CenterPanel);
            this.MainLayout.Controls.Add(this.LeftSidePanel);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(0, 0);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 22F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 26F)});
            this.MainLayout.Size = new System.Drawing.Size(1280, 800);
            this.MainLayout.TabIndex = 0;
            // 
            // CenterPanel
            // 
            this.MainLayout.SetColumn(this.CenterPanel, 1);
            this.CenterPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.CenterPanel.Controls.Add(this.IconsPanel);
            this.CenterPanel.Controls.Add(this.tablePanel1);
            this.CenterPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CenterPanel.Location = new System.Drawing.Point(128, 22);
            this.CenterPanel.Margin = new System.Windows.Forms.Padding(0);
            this.CenterPanel.Name = "CenterPanel";
            this.MainLayout.SetRow(this.CenterPanel, 1);
            this.CenterPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 85F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F)});
            this.CenterPanel.Size = new System.Drawing.Size(1152, 778);
            this.CenterPanel.TabIndex = 2;
            // 
            // IconsPanel
            // 
            this.CenterPanel.SetColumn(this.IconsPanel, 0);
            this.IconsPanel.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 5F)});
            this.IconsPanel.Controls.Add(this.Chat);
            this.IconsPanel.Controls.Add(this.devicesLabel);
            this.IconsPanel.Controls.Add(this.signOff);
            this.IconsPanel.Controls.Add(this.ScreenShare);
            this.IconsPanel.Controls.Add(this.videoLabel);
            this.IconsPanel.Controls.Add(this.audioLabel);
            this.IconsPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.IconsPanel.Location = new System.Drawing.Point(0, 661);
            this.IconsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.IconsPanel.Name = "IconsPanel";
            this.CenterPanel.SetRow(this.IconsPanel, 1);
            this.IconsPanel.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.IconsPanel.Size = new System.Drawing.Size(1152, 117);
            this.IconsPanel.TabIndex = 2;
            // 
            // Chat
            // 
            this.IconsPanel.SetColumn(this.Chat, 9);
            this.Chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Chat.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Chat.Location = new System.Drawing.Point(1071, 0);
            this.Chat.Margin = new System.Windows.Forms.Padding(0);
            this.Chat.Name = "Chat";
            this.IconsPanel.SetRow(this.Chat, 0);
            this.Chat.Size = new System.Drawing.Size(81, 117);
            this.Chat.TabIndex = 5;
            this.Chat.Text = "svgImageBox6";
            // 
            // devicesLabel
            // 
            this.IconsPanel.SetColumn(this.devicesLabel, 8);
            this.devicesLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.devicesLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.devicesLabel.Location = new System.Drawing.Point(968, 0);
            this.devicesLabel.Margin = new System.Windows.Forms.Padding(0);
            this.devicesLabel.Name = "devicesLabel";
            this.IconsPanel.SetRow(this.devicesLabel, 0);
            this.devicesLabel.Size = new System.Drawing.Size(103, 117);
            this.devicesLabel.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("devicesLabel.SvgImage")));
            this.devicesLabel.TabIndex = 4;
            this.devicesLabel.Text = "devicesLabel";
            this.devicesLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.videoLabel_MouseMove);
            // 
            // signOff
            // 
            this.IconsPanel.SetColumn(this.signOff, 5);
            this.signOff.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signOff.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signOff.Location = new System.Drawing.Point(524, 0);
            this.signOff.Margin = new System.Windows.Forms.Padding(0);
            this.signOff.Name = "signOff";
            this.IconsPanel.SetRow(this.signOff, 0);
            this.signOff.Size = new System.Drawing.Size(241, 117);
            this.signOff.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.signOff.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("signOff.SvgImage")));
            this.signOff.TabIndex = 3;
            this.signOff.Text = "signOff";
            this.signOff.Click += new System.EventHandler(this.HomeBtn_Click);
            // 
            // ScreenShare
            // 
            this.IconsPanel.SetColumn(this.ScreenShare, 2);
            this.ScreenShare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ScreenShare.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScreenShare.Location = new System.Drawing.Point(200, 0);
            this.ScreenShare.Margin = new System.Windows.Forms.Padding(0);
            this.ScreenShare.Name = "ScreenShare";
            this.IconsPanel.SetRow(this.ScreenShare, 0);
            this.ScreenShare.Size = new System.Drawing.Size(120, 117);
            this.ScreenShare.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ScreenShare.SvgImage")));
            this.ScreenShare.TabIndex = 2;
            this.ScreenShare.Text = "svgImageBox3";
            this.ScreenShare.Click += new System.EventHandler(this.btnScreenShare_Click);
            // 
            // videoLabel
            // 
            this.IconsPanel.SetColumn(this.videoLabel, 1);
            this.videoLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.videoLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.videoLabel.ItemAppearance.Normal.BorderThickness = 0F;
            this.videoLabel.Location = new System.Drawing.Point(80, 0);
            this.videoLabel.Margin = new System.Windows.Forms.Padding(0);
            this.videoLabel.Name = "videoLabel";
            this.IconsPanel.SetRow(this.videoLabel, 0);
            this.videoLabel.Size = new System.Drawing.Size(120, 117);
            this.videoLabel.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("videoLabel.SvgImage")));
            this.videoLabel.TabIndex = 1;
            this.videoLabel.Text = "videoLabel";
            this.videoLabel.Click += new System.EventHandler(this.labelVideo_Click);
            this.videoLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.videoLabel_MouseMove);
            // 
            // audioLabel
            // 
            this.IconsPanel.SetColumn(this.audioLabel, 0);
            this.audioLabel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.audioLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.audioLabel.ItemAppearance.Normal.BorderThickness = 0F;
            this.audioLabel.Location = new System.Drawing.Point(0, 0);
            this.audioLabel.Margin = new System.Windows.Forms.Padding(0);
            this.audioLabel.Name = "audioLabel";
            this.IconsPanel.SetRow(this.audioLabel, 0);
            this.audioLabel.Size = new System.Drawing.Size(80, 117);
            this.audioLabel.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("audioLabel.SvgImage")));
            this.audioLabel.TabIndex = 0;
            this.audioLabel.Text = "audioLabel";
            this.audioLabel.Click += new System.EventHandler(this.labelMicrophone_Click);
            this.audioLabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.audioLabel_MouseMove);
            // 
            // tablePanel1
            // 
            this.CenterPanel.SetColumn(this.tablePanel1, 0);
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Controls.Add(this.RoomNameLabel);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(3, 3);
            this.tablePanel1.Name = "tablePanel1";
            this.CenterPanel.SetRow(this.tablePanel1, 0);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 7F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.AutoSize, 26F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 93F)});
            this.tablePanel1.Size = new System.Drawing.Size(1146, 655);
            this.tablePanel1.TabIndex = 1;
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.tablePanel1.SetColumn(this.RoomNameLabel, 0);
            this.RoomNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RoomNameLabel.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomNameLabel.ForeColor = System.Drawing.Color.White;
            this.RoomNameLabel.Location = new System.Drawing.Point(35, 43);
            this.RoomNameLabel.Margin = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.tablePanel1.SetRow(this.RoomNameLabel, 1);
            this.RoomNameLabel.Size = new System.Drawing.Size(168, 39);
            this.RoomNameLabel.TabIndex = 6;
            this.RoomNameLabel.Text = "Room Name";
            this.RoomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // LeftSidePanel
            // 
            this.LeftSidePanel.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.LeftSidePanel.Appearance.Options.UseBackColor = true;
            this.MainLayout.SetColumn(this.LeftSidePanel, 0);
            this.LeftSidePanel.Controls.Add(this.Logo);
            this.LeftSidePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LeftSidePanel.Location = new System.Drawing.Point(0, 22);
            this.LeftSidePanel.Margin = new System.Windows.Forms.Padding(0);
            this.LeftSidePanel.Name = "LeftSidePanel";
            this.LeftSidePanel.Padding = new System.Windows.Forms.Padding(5, 35, 20, 0);
            this.MainLayout.SetRow(this.LeftSidePanel, 1);
            this.LeftSidePanel.Size = new System.Drawing.Size(128, 778);
            this.LeftSidePanel.TabIndex = 0;
            this.LeftSidePanel.Text = "sidePanel1";
            // 
            // Logo
            // 
            this.Logo.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.logotype;
            this.Logo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Logo.Dock = System.Windows.Forms.DockStyle.Top;
            this.Logo.Image = global::RSI_X_Desktop.Properties.Resources.logotype;
            this.Logo.Location = new System.Drawing.Point(5, 35);
            this.Logo.Margin = new System.Windows.Forms.Padding(0);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(103, 68);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Logo.TabIndex = 1;
            this.Logo.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Designer
            // 
            this.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 800);
            this.Controls.Add(this.MainLayout);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Designer";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Designer";
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(175)))), ((int)(((byte)(175)))), ((int)(((byte)(175)))));
            this.Load += new System.EventHandler(this.Designer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MainLayout)).EndInit();
            this.MainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CenterPanel)).EndInit();
            this.CenterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconsPanel)).EndInit();
            this.IconsPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.devicesLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.signOff)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ScreenShare)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.videoLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.audioLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.LeftSidePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel MainLayout;
        private DevExpress.XtraEditors.SidePanel LeftSidePanel;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.Utils.Layout.TablePanel CenterPanel;
        internal ReaLTaiizor.Controls.SkyLabel RoomNameLabel;
        private DevExpress.Utils.Layout.TablePanel IconsPanel;
        private DevExpress.XtraEditors.SvgImageBox Chat;
        private DevExpress.XtraEditors.SvgImageBox devicesLabel;
        private DevExpress.XtraEditors.SvgImageBox signOff;
        private DevExpress.XtraEditors.SvgImageBox ScreenShare;
        private DevExpress.XtraEditors.SvgImageBox videoLabel;
        private DevExpress.XtraEditors.SvgImageBox audioLabel;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.Timer timer1;
    }
}