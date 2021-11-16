
namespace RSI_X_Desktop
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.formTheme1 = new ReaLTaiizor.Forms.FormTheme();
            this.CloseAppButton = new ReaLTaiizor.Controls.SpaceButton();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.PanelBot = new ReaLTaiizor.Controls.LostPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.trackBar1 = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.labelChat = new System.Windows.Forms.Label();
            this.labelSettings = new System.Windows.Forms.Label();
            this.labelMicrophone = new System.Windows.Forms.Label();
            this.labelVideo = new System.Windows.Forms.Label();
            this.labelVolume = new System.Windows.Forms.Label();
            this.publishPB = new System.Windows.Forms.PictureBox();
            this.PanelTop = new ReaLTaiizor.Controls.LostPanel();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.CloseButton = new ReaLTaiizor.Controls.Button();
            this.SettingButton = new ReaLTaiizor.Controls.Button();
            this.ResetButton = new ReaLTaiizor.Controls.Button();
            this.parrotPictureBox2 = new ReaLTaiizor.Controls.ParrotPictureBox();
            this.RoomNameLabel = new ReaLTaiizor.Controls.SkyLabel();
            this.StreamLayout = new System.Windows.Forms.TableLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PanelNothing = new System.Windows.Forms.Panel();
            this.pictureBoxRemoteVideo = new System.Windows.Forms.PictureBox();
            this.HideButton = new ReaLTaiizor.Controls.SpaceButton();
            this.NewFullScreenButton = new ReaLTaiizor.Controls.SpaceButton();
            this.formTheme1.SuspendLayout();
            this.MainLayout.SuspendLayout();
            this.PanelBot.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publishPB)).BeginInit();
            this.PanelTop.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            this.StreamLayout.SuspendLayout();
            this.PanelNothing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoteVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // formTheme1
            // 
            this.formTheme1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(41)))), ((int)(((byte)(50)))));
            this.formTheme1.Controls.Add(this.CloseAppButton);
            this.formTheme1.Controls.Add(this.MainLayout);
            this.formTheme1.Controls.Add(this.HideButton);
            this.formTheme1.Controls.Add(this.NewFullScreenButton);
            this.formTheme1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formTheme1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.formTheme1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.formTheme1.Location = new System.Drawing.Point(0, 0);
            this.formTheme1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.formTheme1.Name = "formTheme1";
            this.formTheme1.Padding = new System.Windows.Forms.Padding(3, 18, 3, 18);
            this.formTheme1.Sizable = true;
            this.formTheme1.Size = new System.Drawing.Size(1097, 693);
            this.formTheme1.SmartBounds = false;
            this.formTheme1.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.formTheme1.TabIndex = 10;
            this.formTheme1.Text = "formTheme1";
            // 
            // CloseAppButton
            // 
            this.CloseAppButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseAppButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CloseAppButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseAppButton.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            this.CloseAppButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CloseAppButton.Image = null;
            this.CloseAppButton.Location = new System.Drawing.Point(1053, -3);
            this.CloseAppButton.Name = "CloseAppButton";
            this.CloseAppButton.NoRounding = false;
            this.CloseAppButton.Size = new System.Drawing.Size(30, 22);
            this.CloseAppButton.TabIndex = 93;
            this.CloseAppButton.Text = "X";
            this.CloseAppButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.CloseAppButton.Transparent = false;
            this.CloseAppButton.Click += new System.EventHandler(this.CloseAppButton_Click);
            // 
            // MainLayout
            // 
            this.MainLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.PanelBot, 0, 2);
            this.MainLayout.Controls.Add(this.PanelTop, 0, 0);
            this.MainLayout.Controls.Add(this.StreamLayout, 0, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(3, 18);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.MainLayout.Size = new System.Drawing.Size(1091, 657);
            this.MainLayout.TabIndex = 93;
            // 
            // PanelBot
            // 
            this.PanelBot.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelBot.Controls.Add(this.tableLayoutPanel2);
            this.PanelBot.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelBot.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PanelBot.ForeColor = System.Drawing.Color.White;
            this.PanelBot.Location = new System.Drawing.Point(3, 593);
            this.PanelBot.Name = "PanelBot";
            this.PanelBot.Padding = new System.Windows.Forms.Padding(4);
            this.PanelBot.ShowText = true;
            this.PanelBot.Size = new System.Drawing.Size(1085, 61);
            this.PanelBot.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 10;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 90F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 79F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 85F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 70F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 330F));
            this.tableLayoutPanel2.Controls.Add(this.trackBar1, 4, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelChat, 9, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelSettings, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelMicrophone, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelVideo, 2, 0);
            this.tableLayoutPanel2.Controls.Add(this.labelVolume, 3, 0);
            this.tableLayoutPanel2.Controls.Add(this.publishPB, 6, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1085, 61);
            this.tableLayoutPanel2.TabIndex = 10;
            // 
            // trackBar1
            // 
            this.trackBar1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.trackBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.trackBar1.BorderColor = System.Drawing.Color.White;
            this.trackBar1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBar1.DrawValueString = false;
            this.trackBar1.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBar1.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(85)))), ((int)(((byte)(104)))));
            this.trackBar1.JumpToMouse = true;
            this.trackBar1.Location = new System.Drawing.Point(371, 19);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Minimum = 0;
            this.trackBar1.MinimumSize = new System.Drawing.Size(40, 19);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(66, 22);
            this.trackBar1.TabIndex = 0;
            this.trackBar1.Text = "dungeonTrackBar1";
            this.trackBar1.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.trackBar1.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.trackBar1.Value = 100;
            this.trackBar1.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            this.trackBar1.ValueToSet = 100F;
            // 
            // labelChat
            // 
            this.labelChat.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.labelChat.AutoSize = true;
            this.labelChat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChat.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelChat.Location = new System.Drawing.Point(1030, 16);
            this.labelChat.Name = "labelChat";
            this.labelChat.Size = new System.Drawing.Size(52, 29);
            this.labelChat.TabIndex = 15;
            this.labelChat.Text = "CHAT";
            // 
            // labelSettings
            // 
            this.labelSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSettings.AutoSize = true;
            this.labelSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelSettings.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSettings.Location = new System.Drawing.Point(3, 1);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(84, 58);
            this.labelSettings.TabIndex = 16;
            this.labelSettings.Text = "SETTINGS";
            this.labelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelSettings.Click += new System.EventHandler(this.labelSettings_Click);
            // 
            // labelMicrophone
            // 
            this.labelMicrophone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelMicrophone.AutoSize = true;
            this.labelMicrophone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelMicrophone.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelMicrophone.Location = new System.Drawing.Point(93, 16);
            this.labelMicrophone.Name = "labelMicrophone";
            this.labelMicrophone.Size = new System.Drawing.Size(114, 29);
            this.labelMicrophone.TabIndex = 17;
            this.labelMicrophone.Text = "MICROPHONE";
            this.labelMicrophone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVideo
            // 
            this.labelVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVideo.AutoSize = true;
            this.labelVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVideo.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVideo.Location = new System.Drawing.Point(213, 1);
            this.labelVideo.Name = "labelVideo";
            this.labelVideo.Size = new System.Drawing.Size(73, 58);
            this.labelVideo.TabIndex = 18;
            this.labelVideo.Text = "CAMERA";
            this.labelVideo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelVolume
            // 
            this.labelVolume.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.labelVolume.AutoSize = true;
            this.labelVolume.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelVolume.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVolume.Location = new System.Drawing.Point(292, 1);
            this.labelVolume.Name = "labelVolume";
            this.labelVolume.Size = new System.Drawing.Size(73, 58);
            this.labelVolume.TabIndex = 19;
            this.labelVolume.Text = "VOLUME";
            this.labelVolume.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelVolume.Click += new System.EventHandler(this.labelVolume_Click);
            // 
            // publishPB
            // 
            this.publishPB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.publishPB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.publishPB.Image = global::RSI_X_Desktop.Properties.Resources.rsi_microphone_100;
            this.publishPB.Location = new System.Drawing.Point(537, 2);
            this.publishPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.publishPB.Name = "publishPB";
            this.publishPB.Size = new System.Drawing.Size(64, 57);
            this.publishPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.publishPB.TabIndex = 20;
            this.publishPB.TabStop = false;
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.PanelTop.Controls.Add(this.tableLayoutPanel3);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelTop.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PanelTop.ForeColor = System.Drawing.Color.White;
            this.PanelTop.Location = new System.Drawing.Point(3, 3);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Padding = new System.Windows.Forms.Padding(4);
            this.PanelTop.ShowText = true;
            this.PanelTop.Size = new System.Drawing.Size(1085, 59);
            this.PanelTop.TabIndex = 1;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 8;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 183F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 57F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 15F));
            this.tableLayoutPanel3.Controls.Add(this.CloseButton, 7, 0);
            this.tableLayoutPanel3.Controls.Add(this.SettingButton, 6, 0);
            this.tableLayoutPanel3.Controls.Add(this.ResetButton, 5, 0);
            this.tableLayoutPanel3.Controls.Add(this.parrotPictureBox2, 2, 0);
            this.tableLayoutPanel3.Controls.Add(this.RoomNameLabel, 3, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1085, 59);
            this.tableLayoutPanel3.TabIndex = 0;
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CloseButton.Image = global::RSI_X_Desktop.Properties.Resources.RSI_HR_EXIT1;
            this.CloseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CloseButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.CloseButton.Location = new System.Drawing.Point(1013, 12);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.PressedColor = System.Drawing.Color.Firebrick;
            this.CloseButton.Size = new System.Drawing.Size(68, 35);
            this.CloseButton.TabIndex = 7;
            this.CloseButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.SettingButton.BackColor = System.Drawing.Color.Transparent;
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.SettingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SettingButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.SettingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SettingButton.Image = global::RSI_X_Desktop.Properties.Resources.RSI_HR_SETTINGS3;
            this.SettingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.SettingButton.Location = new System.Drawing.Point(956, 12);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.PressedColor = System.Drawing.Color.Firebrick;
            this.SettingButton.Size = new System.Drawing.Size(49, 35);
            this.SettingButton.TabIndex = 9;
            this.SettingButton.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // ResetButton
            // 
            this.ResetButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ResetButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ResetButton.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.ResetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ResetButton.Image = global::RSI_X_Desktop.Properties.Resources.RSI_HR_HOME1;
            this.ResetButton.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ResetButton.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.ResetButton.Location = new System.Drawing.Point(899, 12);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.PressedColor = System.Drawing.Color.Firebrick;
            this.ResetButton.Size = new System.Drawing.Size(49, 35);
            this.ResetButton.TabIndex = 8;
            this.ResetButton.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // parrotPictureBox2
            // 
            this.parrotPictureBox2.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.logotype_compressed;
            this.parrotPictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.parrotPictureBox2.ColorLeft = System.Drawing.Color.DodgerBlue;
            this.parrotPictureBox2.ColorRight = System.Drawing.Color.DodgerBlue;
            this.parrotPictureBox2.CompositingQualityType = System.Drawing.Drawing2D.CompositingQuality.HighQuality;
            this.parrotPictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.parrotPictureBox2.FilterAlpha = 200;
            this.parrotPictureBox2.FilterEnabled = true;
            this.parrotPictureBox2.Image = null;
            this.parrotPictureBox2.InterpolationType = System.Drawing.Drawing2D.InterpolationMode.HighQualityBilinear;
            this.parrotPictureBox2.IsElipse = false;
            this.parrotPictureBox2.IsParallax = false;
            this.parrotPictureBox2.Location = new System.Drawing.Point(372, 3);
            this.parrotPictureBox2.Name = "parrotPictureBox2";
            this.parrotPictureBox2.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.parrotPictureBox2.Size = new System.Drawing.Size(96, 53);
            this.parrotPictureBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.parrotPictureBox2.TabIndex = 0;
            this.parrotPictureBox2.Text = "parrotPictureBox2";
            this.parrotPictureBox2.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // RoomNameLabel
            // 
            this.RoomNameLabel.AutoSize = true;
            this.RoomNameLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.RoomNameLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.RoomNameLabel.ForeColor = System.Drawing.Color.White;
            this.RoomNameLabel.Location = new System.Drawing.Point(474, 0);
            this.RoomNameLabel.Name = "RoomNameLabel";
            this.RoomNameLabel.Size = new System.Drawing.Size(237, 59);
            this.RoomNameLabel.TabIndex = 3;
            this.RoomNameLabel.Text = "RR (don\'t remove me)";
            this.RoomNameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // StreamLayout
            // 
            this.StreamLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StreamLayout.ColumnCount = 2;
            this.StreamLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.33334F));
            this.StreamLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.StreamLayout.Controls.Add(this.panel1, 1, 0);
            this.StreamLayout.Controls.Add(this.PanelNothing, 0, 0);
            this.StreamLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StreamLayout.Location = new System.Drawing.Point(3, 68);
            this.StreamLayout.Name = "StreamLayout";
            this.StreamLayout.RowCount = 1;
            this.StreamLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.StreamLayout.Size = new System.Drawing.Size(1085, 519);
            this.StreamLayout.TabIndex = 3;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(907, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(173, 513);
            this.panel1.TabIndex = 4;
            // 
            // PanelNothing
            // 
            this.PanelNothing.BackColor = System.Drawing.Color.Silver;
            this.PanelNothing.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.logotype_black;
            this.PanelNothing.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.PanelNothing.Controls.Add(this.pictureBoxRemoteVideo);
            this.PanelNothing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelNothing.Location = new System.Drawing.Point(3, 3);
            this.PanelNothing.Name = "PanelNothing";
            this.PanelNothing.Size = new System.Drawing.Size(898, 513);
            this.PanelNothing.TabIndex = 5;
            // 
            // pictureBoxRemoteVideo
            // 
            this.pictureBoxRemoteVideo.BackColor = System.Drawing.Color.Silver;
            this.pictureBoxRemoteVideo.BackgroundImage = global::RSI_X_Desktop.Properties.Resources.logotype_black;
            this.pictureBoxRemoteVideo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBoxRemoteVideo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxRemoteVideo.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxRemoteVideo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxRemoteVideo.Name = "pictureBoxRemoteVideo";
            this.pictureBoxRemoteVideo.Size = new System.Drawing.Size(898, 513);
            this.pictureBoxRemoteVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBoxRemoteVideo.TabIndex = 3;
            this.pictureBoxRemoteVideo.TabStop = false;
            // 
            // HideButton
            // 
            this.HideButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.HideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.HideButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.HideButton.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            this.HideButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HideButton.Image = null;
            this.HideButton.Location = new System.Drawing.Point(986, -3);
            this.HideButton.Name = "HideButton";
            this.HideButton.NoRounding = false;
            this.HideButton.Size = new System.Drawing.Size(30, 22);
            this.HideButton.TabIndex = 92;
            this.HideButton.Text = "-";
            this.HideButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.HideButton.Transparent = false;
            // 
            // NewFullScreenButton
            // 
            this.NewFullScreenButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.NewFullScreenButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.NewFullScreenButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.NewFullScreenButton.Customization = "Kioq/zIyMv8yMjL/Kioq/y8vL/8nJyf//v7+/yMjI/8qKir/";
            this.NewFullScreenButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewFullScreenButton.Image = null;
            this.NewFullScreenButton.Location = new System.Drawing.Point(1019, -3);
            this.NewFullScreenButton.Name = "NewFullScreenButton";
            this.NewFullScreenButton.NoRounding = false;
            this.NewFullScreenButton.Size = new System.Drawing.Size(30, 22);
            this.NewFullScreenButton.TabIndex = 91;
            this.NewFullScreenButton.Text = "❏ ";
            this.NewFullScreenButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.NewFullScreenButton.Transparent = false;
            // 
            // Broadcaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 693);
            this.Controls.Add(this.formTheme1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(94, 33);
            this.Name = "Broadcaster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formTheme1";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Broadcaster_FormClosed);
            this.Load += new System.EventHandler(this.Conference_Load);
            this.formTheme1.ResumeLayout(false);
            this.MainLayout.ResumeLayout(false);
            this.PanelBot.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.publishPB)).EndInit();
            this.PanelTop.ResumeLayout(false);
            this.tableLayoutPanel3.ResumeLayout(false);
            this.tableLayoutPanel3.PerformLayout();
            this.StreamLayout.ResumeLayout(false);
            this.PanelNothing.ResumeLayout(false);
            this.PanelNothing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRemoteVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private ReaLTaiizor.Forms.FormTheme formTheme1;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private ReaLTaiizor.Controls.LostPanel PanelBot;
        private ReaLTaiizor.Controls.LostPanel PanelTop;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private ReaLTaiizor.Controls.Button CloseButton;
        private ReaLTaiizor.Controls.Button SettingButton;
        private ReaLTaiizor.Controls.Button ResetButton;
        private ReaLTaiizor.Controls.ParrotPictureBox parrotPictureBox2;
        private ReaLTaiizor.Controls.SkyLabel RoomNameLabel;
        private System.Windows.Forms.TableLayoutPanel StreamLayout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel PanelNothing;
        private System.Windows.Forms.PictureBox pictureBoxRemoteVideo;
        private ReaLTaiizor.Controls.SpaceButton CloseAppButton;
        private ReaLTaiizor.Controls.SpaceButton HideButton;
        private ReaLTaiizor.Controls.SpaceButton NewFullScreenButton;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBar1;
        private System.Windows.Forms.Label labelChat;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.Label labelMicrophone;
        private System.Windows.Forms.Label labelVideo;
        private System.Windows.Forms.Label labelVolume;
        private System.Windows.Forms.PictureBox publishPB;
    }
}