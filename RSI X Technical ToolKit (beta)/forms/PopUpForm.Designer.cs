﻿
namespace RSI_X_Desktop.forms
{
    partial class PopUpForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PopUpForm));
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tablePanel4 = new DevExpress.Utils.Layout.TablePanel();
            this.testMic = new ReaLTaiizor.Controls.BigLabel();
            this.comboBoxAudioInput = new ReaLTaiizor.Controls.AloneComboBox();
            this.VolumeLabel = new ReaLTaiizor.Controls.BigLabel();
            this.Microphone = new ReaLTaiizor.Controls.DungeonLabel();
            this.trackBarSoundIn = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.ApplyBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.ConfirmBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.CancelBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
            this.BCloseGeneral = new ReaLTaiizor.Controls.Button();
            this.bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            this.tablePanel5 = new DevExpress.Utils.Layout.TablePanel();
            this.trackBarSoundOut = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.comboBoxAudioOutput = new ReaLTaiizor.Controls.AloneComboBox();
            this.testSpeaker = new ReaLTaiizor.Controls.BigLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.tablePanel6 = new DevExpress.Utils.Layout.TablePanel();
            this.comboBoxVideo = new ReaLTaiizor.Controls.AloneComboBox();
            this.tablePanel7 = new DevExpress.Utils.Layout.TablePanel();
            this.pictureBoxLocalVideoTest = new ReaLTaiizor.Controls.HopePictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).BeginInit();
            this.tablePanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApplyBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).BeginInit();
            this.tableLayoutPanel5.SuspendLayout();
            this.tableLayoutPanel8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).BeginInit();
            this.tablePanel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).BeginInit();
            this.tablePanel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel7)).BeginInit();
            this.tablePanel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalVideoTest)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel2
            // 
            this.tablePanel2.Appearance.BackColor = System.Drawing.Color.White;
            this.tablePanel2.Appearance.Options.UseBackColor = true;
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel2.Controls.Add(this.tablePanel3);
            this.tablePanel2.Controls.Add(this.tablePanel1);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 80F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 20F)});
            this.tablePanel2.Size = new System.Drawing.Size(500, 600);
            this.tablePanel2.TabIndex = 1;
            // 
            // tablePanel3
            // 
            this.tablePanel2.SetColumn(this.tablePanel3, 0);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F)});
            this.tablePanel3.Controls.Add(this.tablePanel7);
            this.tablePanel3.Controls.Add(this.tablePanel6);
            this.tablePanel3.Controls.Add(this.dungeonLabel2);
            this.tablePanel3.Controls.Add(this.dungeonLabel1);
            this.tablePanel3.Controls.Add(this.bigLabel3);
            this.tablePanel3.Controls.Add(this.trackBarSoundOut);
            this.tablePanel3.Controls.Add(this.tablePanel5);
            this.tablePanel3.Controls.Add(this.pictureBox1);
            this.tablePanel3.Controls.Add(this.tablePanel4);
            this.tablePanel3.Controls.Add(this.VolumeLabel);
            this.tablePanel3.Controls.Add(this.Microphone);
            this.tablePanel3.Controls.Add(this.trackBarSoundIn);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(3, 3);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel2.SetRow(this.tablePanel3, 0);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 15F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35F)});
            this.tablePanel3.Size = new System.Drawing.Size(494, 474);
            this.tablePanel3.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.tablePanel3.SetColumn(this.pictureBox1, 0);
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::RSI_X_Desktop.Properties.Resources.logotype_compressed;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.tablePanel3.SetRow(this.pictureBox1, 0);
            this.pictureBox1.Size = new System.Drawing.Size(118, 65);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // tablePanel4
            // 
            this.tablePanel3.SetColumn(this.tablePanel4, 1);
            this.tablePanel4.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel4.Controls.Add(this.testMic);
            this.tablePanel4.Controls.Add(this.comboBoxAudioInput);
            this.tablePanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel4.Location = new System.Drawing.Point(127, 74);
            this.tablePanel4.Name = "tablePanel4";
            this.tablePanel3.SetRow(this.tablePanel4, 1);
            this.tablePanel4.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel4.Size = new System.Drawing.Size(365, 41);
            this.tablePanel4.TabIndex = 8;
            // 
            // testMic
            // 
            this.testMic.AutoSize = true;
            this.testMic.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel4.SetColumn(this.testMic, 1);
            this.testMic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testMic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testMic.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.testMic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(243)))));
            this.testMic.Location = new System.Drawing.Point(276, 0);
            this.testMic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testMic.Name = "testMic";
            this.tablePanel4.SetRow(this.testMic, 0);
            this.testMic.Size = new System.Drawing.Size(87, 41);
            this.testMic.TabIndex = 2;
            this.testMic.Text = "Test!";
            this.testMic.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAudioInput
            // 
            this.comboBoxAudioInput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel4.SetColumn(this.comboBoxAudioInput, 0);
            this.comboBoxAudioInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAudioInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAudioInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioInput.EnabledCalc = true;
            this.comboBoxAudioInput.FormattingEnabled = true;
            this.comboBoxAudioInput.ItemHeight = 20;
            this.comboBoxAudioInput.Location = new System.Drawing.Point(2, 7);
            this.comboBoxAudioInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAudioInput.Name = "comboBoxAudioInput";
            this.tablePanel4.SetRow(this.comboBoxAudioInput, 0);
            this.comboBoxAudioInput.Size = new System.Drawing.Size(270, 26);
            this.comboBoxAudioInput.TabIndex = 1;
            // 
            // VolumeLabel
            // 
            this.VolumeLabel.AutoSize = true;
            this.VolumeLabel.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel3.SetColumn(this.VolumeLabel, 0);
            this.VolumeLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VolumeLabel.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VolumeLabel.ForeColor = System.Drawing.Color.Black;
            this.VolumeLabel.Location = new System.Drawing.Point(2, 118);
            this.VolumeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.VolumeLabel.Name = "VolumeLabel";
            this.tablePanel3.SetRow(this.VolumeLabel, 2);
            this.VolumeLabel.Size = new System.Drawing.Size(120, 47);
            this.VolumeLabel.TabIndex = 7;
            this.VolumeLabel.Text = "Volume";
            this.VolumeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Microphone
            // 
            this.Microphone.AutoSize = true;
            this.Microphone.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel3.SetColumn(this.Microphone, 0);
            this.Microphone.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Microphone.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Microphone.ForeColor = System.Drawing.Color.Gray;
            this.Microphone.Location = new System.Drawing.Point(2, 71);
            this.Microphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Microphone.Name = "Microphone";
            this.tablePanel3.SetRow(this.Microphone, 1);
            this.Microphone.Size = new System.Drawing.Size(120, 47);
            this.Microphone.TabIndex = 6;
            this.Microphone.Text = "Audio input";
            this.Microphone.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarSoundIn
            // 
            this.trackBarSoundIn.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSoundIn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackBarSoundIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tablePanel3.SetColumn(this.trackBarSoundIn, 1);
            this.trackBarSoundIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSoundIn.DrawValueString = false;
            this.trackBarSoundIn.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBarSoundIn.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundIn.JumpToMouse = true;
            this.trackBarSoundIn.Location = new System.Drawing.Point(126, 130);
            this.trackBarSoundIn.Margin = new System.Windows.Forms.Padding(2, 3, 45, 3);
            this.trackBarSoundIn.Maximum = 100;
            this.trackBarSoundIn.Minimum = 0;
            this.trackBarSoundIn.MinimumSize = new System.Drawing.Size(34, 21);
            this.trackBarSoundIn.Name = "trackBarSoundIn";
            this.tablePanel3.SetRow(this.trackBarSoundIn, 2);
            this.trackBarSoundIn.Size = new System.Drawing.Size(324, 22);
            this.trackBarSoundIn.TabIndex = 4;
            this.trackBarSoundIn.Text = "dungeonTrackBar1";
            this.trackBarSoundIn.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundIn.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundIn.Value = 100;
            this.trackBarSoundIn.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By100;
            this.trackBarSoundIn.ValueToSet = 1F;
            // 
            // tablePanel1
            // 
            this.tablePanel2.SetColumn(this.tablePanel1, 0);
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 50F)});
            this.tablePanel1.Controls.Add(this.ApplyBtn);
            this.tablePanel1.Controls.Add(this.ConfirmBtn);
            this.tablePanel1.Controls.Add(this.CancelBtn);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(3, 483);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel2.SetRow(this.tablePanel1, 1);
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel1.Size = new System.Drawing.Size(494, 114);
            this.tablePanel1.TabIndex = 0;
            // 
            // ApplyBtn
            // 
            this.tablePanel1.SetColumn(this.ApplyBtn, 3);
            this.ApplyBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ApplyBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ApplyBtn.ItemAppearance.Normal.BorderColor = System.Drawing.Color.White;
            this.ApplyBtn.ItemAppearance.Normal.BorderThickness = 1F;
            this.ApplyBtn.Location = new System.Drawing.Point(337, 15);
            this.ApplyBtn.Margin = new System.Windows.Forms.Padding(15);
            this.ApplyBtn.Name = "ApplyBtn";
            this.tablePanel1.SetRow(this.ApplyBtn, 0);
            this.ApplyBtn.Size = new System.Drawing.Size(120, 84);
            this.ApplyBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.ApplyBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ApplyBtn.SvgImage")));
            this.ApplyBtn.TabIndex = 2;
            this.ApplyBtn.Text = "svgImageBox3";
            // 
            // ConfirmBtn
            // 
            this.tablePanel1.SetColumn(this.ConfirmBtn, 2);
            this.ConfirmBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ConfirmBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ConfirmBtn.ItemAppearance.Normal.BorderColor = System.Drawing.Color.White;
            this.ConfirmBtn.ItemAppearance.Normal.BorderThickness = 1F;
            this.ConfirmBtn.Location = new System.Drawing.Point(187, 15);
            this.ConfirmBtn.Margin = new System.Windows.Forms.Padding(15);
            this.ConfirmBtn.Name = "ConfirmBtn";
            this.tablePanel1.SetRow(this.ConfirmBtn, 0);
            this.ConfirmBtn.Size = new System.Drawing.Size(120, 84);
            this.ConfirmBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.ConfirmBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("ConfirmBtn.SvgImage")));
            this.ConfirmBtn.TabIndex = 1;
            this.ConfirmBtn.Text = "svgImageBox2";
            // 
            // CancelBtn
            // 
            this.tablePanel1.SetColumn(this.CancelBtn, 1);
            this.CancelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelBtn.ItemAppearance.Normal.BorderThickness = 1F;
            this.CancelBtn.Location = new System.Drawing.Point(37, 15);
            this.CancelBtn.Margin = new System.Windows.Forms.Padding(15);
            this.CancelBtn.Name = "CancelBtn";
            this.tablePanel1.SetRow(this.CancelBtn, 0);
            this.CancelBtn.Size = new System.Drawing.Size(120, 84);
            this.CancelBtn.SizeMode = DevExpress.XtraEditors.SvgImageSizeMode.Squeeze;
            this.CancelBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("CancelBtn.SvgImage")));
            this.CancelBtn.TabIndex = 0;
            this.CancelBtn.Text = "svgImageBox1";
            // 
            // tableLayoutPanel5
            // 
            this.tableLayoutPanel5.ColumnCount = 1;
            this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel5.Controls.Add(this.tableLayoutPanel8, 0, 8);
            this.tableLayoutPanel5.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel5.Name = "tableLayoutPanel5";
            this.tableLayoutPanel5.RowCount = 9;
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel5.Size = new System.Drawing.Size(200, 100);
            this.tableLayoutPanel5.TabIndex = 0;
            // 
            // tableLayoutPanel8
            // 
            this.tableLayoutPanel8.ColumnCount = 2;
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Controls.Add(this.BCloseGeneral, 1, 0);
            this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.tableLayoutPanel8.Location = new System.Drawing.Point(3, 163);
            this.tableLayoutPanel8.Name = "tableLayoutPanel8";
            this.tableLayoutPanel8.RowCount = 1;
            this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel8.Size = new System.Drawing.Size(194, 14);
            this.tableLayoutPanel8.TabIndex = 7;
            // 
            // BCloseGeneral
            // 
            this.BCloseGeneral.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BCloseGeneral.BackColor = System.Drawing.Color.Transparent;
            this.BCloseGeneral.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCloseGeneral.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseGeneral.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCloseGeneral.Image = null;
            this.BCloseGeneral.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCloseGeneral.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseGeneral.Location = new System.Drawing.Point(111, 3);
            this.BCloseGeneral.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BCloseGeneral.Name = "BCloseGeneral";
            this.BCloseGeneral.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BCloseGeneral.Size = new System.Drawing.Size(80, 1);
            this.BCloseGeneral.TabIndex = 6;
            this.BCloseGeneral.Text = "Close";
            this.BCloseGeneral.TextAlignment = System.Drawing.StringAlignment.Center;
            // 
            // bigLabel2
            // 
            this.bigLabel2.AutoSize = true;
            this.bigLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel2.Location = new System.Drawing.Point(2, 0);
            this.bigLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel2.Name = "bigLabel2";
            this.bigLabel2.Size = new System.Drawing.Size(109, 29);
            this.bigLabel2.TabIndex = 0;
            this.bigLabel2.Text = "Your system";
            // 
            // tablePanel5
            // 
            this.tablePanel3.SetColumn(this.tablePanel5, 1);
            this.tablePanel5.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel5.Controls.Add(this.testSpeaker);
            this.tablePanel5.Controls.Add(this.comboBoxAudioOutput);
            this.tablePanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel5.Location = new System.Drawing.Point(127, 168);
            this.tablePanel5.Name = "tablePanel5";
            this.tablePanel3.SetRow(this.tablePanel5, 3);
            this.tablePanel5.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel5.Size = new System.Drawing.Size(365, 41);
            this.tablePanel5.TabIndex = 10;
            // 
            // trackBarSoundOut
            // 
            this.trackBarSoundOut.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSoundOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackBarSoundOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.tablePanel3.SetColumn(this.trackBarSoundOut, 1);
            this.trackBarSoundOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSoundOut.DrawValueString = false;
            this.trackBarSoundOut.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBarSoundOut.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundOut.JumpToMouse = true;
            this.trackBarSoundOut.Location = new System.Drawing.Point(126, 224);
            this.trackBarSoundOut.Margin = new System.Windows.Forms.Padding(2, 3, 45, 3);
            this.trackBarSoundOut.Maximum = 100;
            this.trackBarSoundOut.Minimum = 0;
            this.trackBarSoundOut.MinimumSize = new System.Drawing.Size(34, 21);
            this.trackBarSoundOut.Name = "trackBarSoundOut";
            this.tablePanel3.SetRow(this.trackBarSoundOut, 4);
            this.trackBarSoundOut.Size = new System.Drawing.Size(324, 22);
            this.trackBarSoundOut.TabIndex = 11;
            this.trackBarSoundOut.Text = "dungeonTrackBar1";
            this.trackBarSoundOut.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundOut.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(143)))));
            this.trackBarSoundOut.Value = 100;
            this.trackBarSoundOut.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By100;
            this.trackBarSoundOut.ValueToSet = 1F;
            // 
            // bigLabel3
            // 
            this.bigLabel3.AutoSize = true;
            this.bigLabel3.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel3.SetColumn(this.bigLabel3, 0);
            this.bigLabel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigLabel3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel3.ForeColor = System.Drawing.Color.Black;
            this.bigLabel3.Location = new System.Drawing.Point(2, 212);
            this.bigLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel3.Name = "bigLabel3";
            this.tablePanel3.SetRow(this.bigLabel3, 4);
            this.bigLabel3.Size = new System.Drawing.Size(120, 47);
            this.bigLabel3.TabIndex = 12;
            this.bigLabel3.Text = "Volume";
            this.bigLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel3.SetColumn(this.dungeonLabel1, 0);
            this.dungeonLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dungeonLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.Gray;
            this.dungeonLabel1.Location = new System.Drawing.Point(2, 165);
            this.dungeonLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.tablePanel3.SetRow(this.dungeonLabel1, 3);
            this.dungeonLabel1.Size = new System.Drawing.Size(120, 47);
            this.dungeonLabel1.TabIndex = 13;
            this.dungeonLabel1.Text = "Audio output";
            this.dungeonLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxAudioOutput
            // 
            this.comboBoxAudioOutput.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel5.SetColumn(this.comboBoxAudioOutput, 0);
            this.comboBoxAudioOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAudioOutput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAudioOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioOutput.EnabledCalc = true;
            this.comboBoxAudioOutput.FormattingEnabled = true;
            this.comboBoxAudioOutput.ItemHeight = 20;
            this.comboBoxAudioOutput.Location = new System.Drawing.Point(2, 7);
            this.comboBoxAudioOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAudioOutput.Name = "comboBoxAudioOutput";
            this.tablePanel5.SetRow(this.comboBoxAudioOutput, 0);
            this.comboBoxAudioOutput.Size = new System.Drawing.Size(270, 26);
            this.comboBoxAudioOutput.TabIndex = 2;
            // 
            // testSpeaker
            // 
            this.testSpeaker.AutoSize = true;
            this.testSpeaker.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel5.SetColumn(this.testSpeaker, 1);
            this.testSpeaker.Cursor = System.Windows.Forms.Cursors.Hand;
            this.testSpeaker.Dock = System.Windows.Forms.DockStyle.Fill;
            this.testSpeaker.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point);
            this.testSpeaker.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(1)))), ((int)(((byte)(243)))));
            this.testSpeaker.Location = new System.Drawing.Point(276, 0);
            this.testSpeaker.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.testSpeaker.Name = "testSpeaker";
            this.tablePanel5.SetRow(this.testSpeaker, 0);
            this.testSpeaker.Size = new System.Drawing.Size(87, 41);
            this.testSpeaker.TabIndex = 3;
            this.testSpeaker.Text = "Test!";
            this.testSpeaker.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.tablePanel3.SetColumn(this.dungeonLabel2, 0);
            this.dungeonLabel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dungeonLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.Gray;
            this.dungeonLabel2.Location = new System.Drawing.Point(2, 259);
            this.dungeonLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.tablePanel3.SetRow(this.dungeonLabel2, 5);
            this.dungeonLabel2.Size = new System.Drawing.Size(120, 47);
            this.dungeonLabel2.TabIndex = 14;
            this.dungeonLabel2.Text = "Camera";
            this.dungeonLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tablePanel6
            // 
            this.tablePanel3.SetColumn(this.tablePanel6, 1);
            this.tablePanel6.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 75F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 25F)});
            this.tablePanel6.Controls.Add(this.comboBoxVideo);
            this.tablePanel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel6.Location = new System.Drawing.Point(127, 262);
            this.tablePanel6.Name = "tablePanel6";
            this.tablePanel3.SetRow(this.tablePanel6, 5);
            this.tablePanel6.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel6.Size = new System.Drawing.Size(365, 41);
            this.tablePanel6.TabIndex = 15;
            // 
            // comboBoxVideo
            // 
            this.comboBoxVideo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tablePanel6.SetColumn(this.comboBoxVideo, 0);
            this.comboBoxVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxVideo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideo.EnabledCalc = true;
            this.comboBoxVideo.FormattingEnabled = true;
            this.comboBoxVideo.ItemHeight = 20;
            this.comboBoxVideo.Location = new System.Drawing.Point(2, 7);
            this.comboBoxVideo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxVideo.Name = "comboBoxVideo";
            this.tablePanel6.SetRow(this.comboBoxVideo, 0);
            this.comboBoxVideo.Size = new System.Drawing.Size(270, 26);
            this.comboBoxVideo.TabIndex = 1;
            // 
            // tablePanel7
            // 
            this.tablePanel3.SetColumn(this.tablePanel7, 1);
            this.tablePanel7.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 30F)});
            this.tablePanel7.Controls.Add(this.pictureBoxLocalVideoTest);
            this.tablePanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel7.Location = new System.Drawing.Point(127, 309);
            this.tablePanel7.Name = "tablePanel7";
            this.tablePanel3.SetRow(this.tablePanel7, 6);
            this.tablePanel7.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 10F)});
            this.tablePanel7.Size = new System.Drawing.Size(365, 162);
            this.tablePanel7.TabIndex = 16;
            // 
            // pictureBoxLocalVideoTest
            // 
            this.pictureBoxLocalVideoTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.tablePanel7.SetColumn(this.pictureBoxLocalVideoTest, 1);
            this.pictureBoxLocalVideoTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLocalVideoTest.Location = new System.Drawing.Point(40, 13);
            this.pictureBoxLocalVideoTest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxLocalVideoTest.Name = "pictureBoxLocalVideoTest";
            this.pictureBoxLocalVideoTest.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.tablePanel7.SetRow(this.pictureBoxLocalVideoTest, 1);
            this.pictureBoxLocalVideoTest.Size = new System.Drawing.Size(207, 136);
            this.pictureBoxLocalVideoTest.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pictureBoxLocalVideoTest.TabIndex = 2;
            this.pictureBoxLocalVideoTest.TabStop = false;
            this.pictureBoxLocalVideoTest.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // PopUpForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(500, 600);
            this.Controls.Add(this.tablePanel2);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.None;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PopUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PopUpForm";
            this.TransparencyKey = System.Drawing.Color.Silver;
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            this.tablePanel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel4)).EndInit();
            this.tablePanel4.ResumeLayout(false);
            this.tablePanel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ApplyBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConfirmBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CancelBtn)).EndInit();
            this.tableLayoutPanel5.ResumeLayout(false);
            this.tableLayoutPanel8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel5)).EndInit();
            this.tablePanel5.ResumeLayout(false);
            this.tablePanel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel6)).EndInit();
            this.tablePanel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel7)).EndInit();
            this.tablePanel7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalVideoTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private DevExpress.XtraEditors.SvgImageBox CancelBtn;
        private DevExpress.XtraEditors.SvgImageBox ConfirmBtn;
        private DevExpress.XtraEditors.SvgImageBox ApplyBtn;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxAudioInput;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarSoundIn;
        private ReaLTaiizor.Controls.DungeonLabel Microphone;
        private ReaLTaiizor.Controls.BigLabel VolumeLabel;
        private DevExpress.Utils.Layout.TablePanel tablePanel4;
        private ReaLTaiizor.Controls.BigLabel testMic;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
        private ReaLTaiizor.Controls.Button BCloseGeneral;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private DevExpress.Utils.Layout.TablePanel tablePanel5;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarSoundOut;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxAudioOutput;
        private ReaLTaiizor.Controls.BigLabel testSpeaker;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private DevExpress.Utils.Layout.TablePanel tablePanel6;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxVideo;
        private DevExpress.Utils.Layout.TablePanel tablePanel7;
        private ReaLTaiizor.Controls.HopePictureBox pictureBoxLocalVideoTest;
    }
}