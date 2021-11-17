
namespace RSI_X_Desktop.forms
{
    partial class Devices
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
            this.materialShowTabControl1 = new ReaLTaiizor.Controls.MaterialShowTabControl();
            this.General = new System.Windows.Forms.TabPage();
            this.BCloseGeneral = new ReaLTaiizor.Controls.Button();
            this.dungeonLabel3 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel2 = new ReaLTaiizor.Controls.DungeonLabel();
            this.dungeonLabel1 = new ReaLTaiizor.Controls.DungeonLabel();
            this.bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            this.Sound = new System.Windows.Forms.TabPage();
            this.BAcceptSound = new ReaLTaiizor.Controls.Button();
            this.BCloseSound = new ReaLTaiizor.Controls.Button();
            this.Dynamic = new ReaLTaiizor.Controls.DungeonLabel();
            this.Microphone = new ReaLTaiizor.Controls.DungeonLabel();
            this.trackBarSoundOut = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.trackBarSoundIn = new ReaLTaiizor.Controls.DungeonTrackBar();
            this.comboBoxAudioInput = new ReaLTaiizor.Controls.AloneComboBox();
            this.comboBoxAudioOutput = new ReaLTaiizor.Controls.AloneComboBox();
            this.Video = new System.Windows.Forms.TabPage();
            this.BAcceptVideo = new ReaLTaiizor.Controls.Button();
            this.BCloseVideo = new ReaLTaiizor.Controls.Button();
            this.pictureBoxLocalVideoTest = new ReaLTaiizor.Controls.HopePictureBox();
            this.comboBoxVideo = new ReaLTaiizor.Controls.AloneComboBox();
            this.materialShowTabControl1.SuspendLayout();
            this.General.SuspendLayout();
            this.Sound.SuspendLayout();
            this.Video.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalVideoTest)).BeginInit();
            this.SuspendLayout();
            // 
            // materialShowTabControl1
            // 
            this.materialShowTabControl1.Controls.Add(this.General);
            this.materialShowTabControl1.Controls.Add(this.Sound);
            this.materialShowTabControl1.Controls.Add(this.Video);
            this.materialShowTabControl1.Depth = 0;
            this.materialShowTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialShowTabControl1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.materialShowTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialShowTabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            this.materialShowTabControl1.Multiline = true;
            this.materialShowTabControl1.Name = "materialShowTabControl1";
            this.materialShowTabControl1.SelectedIndex = 0;
            this.materialShowTabControl1.Size = new System.Drawing.Size(321, 541);
            this.materialShowTabControl1.TabIndex = 2;
            this.materialShowTabControl1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.materialShowTabControl1_Selecting);
            this.materialShowTabControl1.Deselecting += new System.Windows.Forms.TabControlCancelEventHandler(this.materialShowTabControl1_Deselecting);
            // 
            // General
            // 
            this.General.BackColor = System.Drawing.Color.White;
            this.General.CausesValidation = false;
            this.General.Controls.Add(this.BCloseGeneral);
            this.General.Controls.Add(this.dungeonLabel3);
            this.General.Controls.Add(this.dungeonLabel2);
            this.General.Controls.Add(this.dungeonLabel1);
            this.General.Controls.Add(this.bigLabel1);
            this.General.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.General.Location = new System.Drawing.Point(4, 39);
            this.General.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.General.Name = "General";
            this.General.Size = new System.Drawing.Size(313, 498);
            this.General.TabIndex = 4;
            this.General.Text = "General";
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
            this.BCloseGeneral.Location = new System.Drawing.Point(225, 466);
            this.BCloseGeneral.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BCloseGeneral.Name = "BCloseGeneral";
            this.BCloseGeneral.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BCloseGeneral.Size = new System.Drawing.Size(80, 28);
            this.BCloseGeneral.TabIndex = 4;
            this.BCloseGeneral.Text = "Close";
            this.BCloseGeneral.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BCloseGeneral.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // dungeonLabel3
            // 
            this.dungeonLabel3.AutoSize = true;
            this.dungeonLabel3.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel3.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel3.Location = new System.Drawing.Point(16, 118);
            this.dungeonLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel3.Name = "dungeonLabel3";
            this.dungeonLabel3.Size = new System.Drawing.Size(110, 24);
            this.dungeonLabel3.TabIndex = 3;
            this.dungeonLabel3.Text = "dungeonLabel3";
            // 
            // dungeonLabel2
            // 
            this.dungeonLabel2.AutoSize = true;
            this.dungeonLabel2.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel2.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel2.Location = new System.Drawing.Point(16, 87);
            this.dungeonLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel2.Name = "dungeonLabel2";
            this.dungeonLabel2.Size = new System.Drawing.Size(110, 24);
            this.dungeonLabel2.TabIndex = 2;
            this.dungeonLabel2.Text = "dungeonLabel2";
            // 
            // dungeonLabel1
            // 
            this.dungeonLabel1.AutoSize = true;
            this.dungeonLabel1.BackColor = System.Drawing.Color.Transparent;
            this.dungeonLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.dungeonLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.dungeonLabel1.Location = new System.Drawing.Point(16, 55);
            this.dungeonLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dungeonLabel1.Name = "dungeonLabel1";
            this.dungeonLabel1.Size = new System.Drawing.Size(107, 24);
            this.dungeonLabel1.TabIndex = 1;
            this.dungeonLabel1.Text = "dungeonLabel1";
            // 
            // bigLabel1
            // 
            this.bigLabel1.AutoSize = true;
            this.bigLabel1.BackColor = System.Drawing.Color.Transparent;
            this.bigLabel1.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.bigLabel1.Location = new System.Drawing.Point(16, 10);
            this.bigLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bigLabel1.Name = "bigLabel1";
            this.bigLabel1.Size = new System.Drawing.Size(135, 36);
            this.bigLabel1.TabIndex = 0;
            this.bigLabel1.Text = "Your system";
            // 
            // Sound
            // 
            this.Sound.BackColor = System.Drawing.Color.White;
            this.Sound.Controls.Add(this.BAcceptSound);
            this.Sound.Controls.Add(this.BCloseSound);
            this.Sound.Controls.Add(this.Dynamic);
            this.Sound.Controls.Add(this.Microphone);
            this.Sound.Controls.Add(this.trackBarSoundOut);
            this.Sound.Controls.Add(this.trackBarSoundIn);
            this.Sound.Controls.Add(this.comboBoxAudioInput);
            this.Sound.Controls.Add(this.comboBoxAudioOutput);
            this.Sound.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Sound.Location = new System.Drawing.Point(4, 39);
            this.Sound.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Sound.Name = "Sound";
            this.Sound.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Sound.Size = new System.Drawing.Size(313, 498);
            this.Sound.TabIndex = 7;
            this.Sound.Text = "Sound";
            // 
            // BAcceptSound
            // 
            this.BAcceptSound.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BAcceptSound.BackColor = System.Drawing.Color.Transparent;
            this.BAcceptSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAcceptSound.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BAcceptSound.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAcceptSound.Image = null;
            this.BAcceptSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAcceptSound.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BAcceptSound.Location = new System.Drawing.Point(139, 466);
            this.BAcceptSound.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BAcceptSound.Name = "BAcceptSound";
            this.BAcceptSound.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BAcceptSound.Size = new System.Drawing.Size(80, 28);
            this.BAcceptSound.TabIndex = 7;
            this.BAcceptSound.Text = "Accept";
            this.BAcceptSound.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BAcceptSound.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // BCloseSound
            // 
            this.BCloseSound.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BCloseSound.BackColor = System.Drawing.Color.Transparent;
            this.BCloseSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCloseSound.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseSound.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCloseSound.Image = null;
            this.BCloseSound.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCloseSound.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseSound.Location = new System.Drawing.Point(225, 466);
            this.BCloseSound.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BCloseSound.Name = "BCloseSound";
            this.BCloseSound.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BCloseSound.Size = new System.Drawing.Size(80, 28);
            this.BCloseSound.TabIndex = 6;
            this.BCloseSound.Text = "Close";
            this.BCloseSound.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BCloseSound.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // Dynamic
            // 
            this.Dynamic.AutoSize = true;
            this.Dynamic.BackColor = System.Drawing.Color.Transparent;
            this.Dynamic.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Dynamic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.Dynamic.Location = new System.Drawing.Point(8, 126);
            this.Dynamic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Dynamic.Name = "Dynamic";
            this.Dynamic.Size = new System.Drawing.Size(62, 23);
            this.Dynamic.TabIndex = 5;
            this.Dynamic.Text = "Speaker";
            this.Dynamic.Visible = false;
            // 
            // Microphone
            // 
            this.Microphone.AutoSize = true;
            this.Microphone.BackColor = System.Drawing.Color.Transparent;
            this.Microphone.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Microphone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.Microphone.Location = new System.Drawing.Point(8, 22);
            this.Microphone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Microphone.Name = "Microphone";
            this.Microphone.Size = new System.Drawing.Size(83, 23);
            this.Microphone.TabIndex = 4;
            this.Microphone.Text = "Microphone";
            // 
            // trackBarSoundOut
            // 
            this.trackBarSoundOut.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.trackBarSoundOut.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.trackBarSoundOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSoundOut.DrawValueString = false;
            this.trackBarSoundOut.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBarSoundOut.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.trackBarSoundOut.JumpToMouse = false;
            this.trackBarSoundOut.Location = new System.Drawing.Point(0, 179);
            this.trackBarSoundOut.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBarSoundOut.Maximum = 100;
            this.trackBarSoundOut.Minimum = 0;
            this.trackBarSoundOut.MinimumSize = new System.Drawing.Size(34, 21);
            this.trackBarSoundOut.Name = "trackBarSoundOut";
            this.trackBarSoundOut.Size = new System.Drawing.Size(302, 22);
            this.trackBarSoundOut.TabIndex = 3;
            this.trackBarSoundOut.Text = "dungeonTrackBar1";
            this.trackBarSoundOut.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.trackBarSoundOut.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.trackBarSoundOut.Value = 100;
            this.trackBarSoundOut.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By100;
            this.trackBarSoundOut.ValueToSet = 1F;
            this.trackBarSoundOut.Visible = false;
            // 
            // trackBarSoundIn
            // 
            this.trackBarSoundIn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarSoundIn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.trackBarSoundIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.trackBarSoundIn.DrawValueString = false;
            this.trackBarSoundIn.EmptyBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(221)))), ((int)(((byte)(221)))));
            this.trackBarSoundIn.FillBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(99)))), ((int)(((byte)(50)))));
            this.trackBarSoundIn.JumpToMouse = false;
            this.trackBarSoundIn.Location = new System.Drawing.Point(4, 71);
            this.trackBarSoundIn.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.trackBarSoundIn.Maximum = 10;
            this.trackBarSoundIn.Minimum = 0;
            this.trackBarSoundIn.MinimumSize = new System.Drawing.Size(34, 21);
            this.trackBarSoundIn.Name = "trackBarSoundIn";
            this.trackBarSoundIn.Size = new System.Drawing.Size(302, 22);
            this.trackBarSoundIn.TabIndex = 2;
            this.trackBarSoundIn.Text = "dungeonTrackBar1";
            this.trackBarSoundIn.ThumbBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(244)))), ((int)(((byte)(244)))));
            this.trackBarSoundIn.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.trackBarSoundIn.Value = 0;
            this.trackBarSoundIn.ValueDivison = ReaLTaiizor.Controls.DungeonTrackBar.ValueDivisor.By1;
            this.trackBarSoundIn.ValueToSet = 0F;
            this.trackBarSoundIn.ValueChanged += new ReaLTaiizor.Controls.DungeonTrackBar.ValueChangedEventHandler(this.trackBarSoundIn_ValueChanged);
            // 
            // comboBoxAudioInput
            // 
            this.comboBoxAudioInput.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxAudioInput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAudioInput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAudioInput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioInput.EnabledCalc = true;
            this.comboBoxAudioInput.FormattingEnabled = true;
            this.comboBoxAudioInput.ItemHeight = 20;
            this.comboBoxAudioInput.Location = new System.Drawing.Point(4, 41);
            this.comboBoxAudioInput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAudioInput.Name = "comboBoxAudioInput";
            this.comboBoxAudioInput.Size = new System.Drawing.Size(302, 26);
            this.comboBoxAudioInput.TabIndex = 1;
            this.comboBoxAudioInput.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioInput_SelectedIndexChanged);
            // 
            // comboBoxAudioOutput
            // 
            this.comboBoxAudioOutput.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxAudioOutput.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxAudioOutput.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxAudioOutput.EnabledCalc = true;
            this.comboBoxAudioOutput.FormattingEnabled = true;
            this.comboBoxAudioOutput.ItemHeight = 20;
            this.comboBoxAudioOutput.Location = new System.Drawing.Point(4, 147);
            this.comboBoxAudioOutput.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxAudioOutput.Name = "comboBoxAudioOutput";
            this.comboBoxAudioOutput.Size = new System.Drawing.Size(302, 26);
            this.comboBoxAudioOutput.TabIndex = 0;
            this.comboBoxAudioOutput.Visible = false;
            this.comboBoxAudioOutput.SelectedIndexChanged += new System.EventHandler(this.comboBoxAudioOutput_SelectedIndexChanged);
            // 
            // Video
            // 
            this.Video.BackColor = System.Drawing.Color.White;
            this.Video.Controls.Add(this.BAcceptVideo);
            this.Video.Controls.Add(this.BCloseVideo);
            this.Video.Controls.Add(this.pictureBoxLocalVideoTest);
            this.Video.Controls.Add(this.comboBoxVideo);
            this.Video.Font = new System.Drawing.Font("Bahnschrift Condensed", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Video.Location = new System.Drawing.Point(4, 39);
            this.Video.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Video.Name = "Video";
            this.Video.Padding = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Video.Size = new System.Drawing.Size(313, 498);
            this.Video.TabIndex = 6;
            this.Video.Text = "Video";
            // 
            // BAcceptVideo
            // 
            this.BAcceptVideo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BAcceptVideo.BackColor = System.Drawing.Color.Transparent;
            this.BAcceptVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BAcceptVideo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BAcceptVideo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BAcceptVideo.Image = null;
            this.BAcceptVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BAcceptVideo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BAcceptVideo.Location = new System.Drawing.Point(139, 466);
            this.BAcceptVideo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BAcceptVideo.Name = "BAcceptVideo";
            this.BAcceptVideo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BAcceptVideo.Size = new System.Drawing.Size(80, 28);
            this.BAcceptVideo.TabIndex = 3;
            this.BAcceptVideo.Text = "Accept";
            this.BAcceptVideo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BAcceptVideo.Click += new System.EventHandler(this.AcceptButton_Click);
            // 
            // BCloseVideo
            // 
            this.BCloseVideo.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.BCloseVideo.BackColor = System.Drawing.Color.Transparent;
            this.BCloseVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BCloseVideo.EnteredColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseVideo.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.BCloseVideo.Image = null;
            this.BCloseVideo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BCloseVideo.InactiveColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(34)))), ((int)(((byte)(37)))));
            this.BCloseVideo.Location = new System.Drawing.Point(225, 466);
            this.BCloseVideo.Margin = new System.Windows.Forms.Padding(3, 3, 3, 10);
            this.BCloseVideo.Name = "BCloseVideo";
            this.BCloseVideo.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.BCloseVideo.Size = new System.Drawing.Size(80, 28);
            this.BCloseVideo.TabIndex = 2;
            this.BCloseVideo.Text = "Close";
            this.BCloseVideo.TextAlignment = System.Drawing.StringAlignment.Center;
            this.BCloseVideo.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // pictureBoxLocalVideoTest
            // 
            this.pictureBoxLocalVideoTest.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(196)))), ((int)(((byte)(204)))));
            this.pictureBoxLocalVideoTest.Location = new System.Drawing.Point(4, 6);
            this.pictureBoxLocalVideoTest.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.pictureBoxLocalVideoTest.Name = "pictureBoxLocalVideoTest";
            this.pictureBoxLocalVideoTest.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            this.pictureBoxLocalVideoTest.Size = new System.Drawing.Size(302, 220);
            this.pictureBoxLocalVideoTest.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pictureBoxLocalVideoTest.TabIndex = 1;
            this.pictureBoxLocalVideoTest.TabStop = false;
            this.pictureBoxLocalVideoTest.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // comboBoxVideo
            // 
            this.comboBoxVideo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxVideo.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.comboBoxVideo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxVideo.EnabledCalc = true;
            this.comboBoxVideo.FormattingEnabled = true;
            this.comboBoxVideo.ItemHeight = 20;
            this.comboBoxVideo.Location = new System.Drawing.Point(4, 232);
            this.comboBoxVideo.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.comboBoxVideo.Name = "comboBoxVideo";
            this.comboBoxVideo.Size = new System.Drawing.Size(302, 26);
            this.comboBoxVideo.TabIndex = 0;
            this.comboBoxVideo.SelectedIndexChanged += new System.EventHandler(this.comboBoxVideo_SelectedIndexChanged);
            // 
            // Devices
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(321, 541);
            this.Controls.Add(this.materialShowTabControl1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Bahnschrift Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MinimumSize = new System.Drawing.Size(90, 47);
            this.Name = "Devices";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Settings";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewDevices_FormClosed);
            this.Load += new System.EventHandler(this.NewDevices_Load);
            this.materialShowTabControl1.ResumeLayout(false);
            this.General.ResumeLayout(false);
            this.General.PerformLayout();
            this.Sound.ResumeLayout(false);
            this.Sound.PerformLayout();
            this.Video.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLocalVideoTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private ReaLTaiizor.Controls.MaterialShowTabControl materialShowTabControl1;
        private System.Windows.Forms.TabPage General;
        private ReaLTaiizor.Controls.Button BCloseGeneral;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel3;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel2;
        private ReaLTaiizor.Controls.DungeonLabel dungeonLabel1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private System.Windows.Forms.TabPage Sound;
        private ReaLTaiizor.Controls.Button BAcceptSound;
        private ReaLTaiizor.Controls.Button BCloseSound;
        private ReaLTaiizor.Controls.DungeonLabel Dynamic;
        private ReaLTaiizor.Controls.DungeonLabel Microphone;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarSoundOut;
        private ReaLTaiizor.Controls.DungeonTrackBar trackBarSoundIn;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxAudioInput;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxAudioOutput;
        private System.Windows.Forms.TabPage Video;
        private ReaLTaiizor.Controls.Button BAcceptVideo;
        private ReaLTaiizor.Controls.Button BCloseVideo;
        private ReaLTaiizor.Controls.HopePictureBox pictureBoxLocalVideoTest;
        private ReaLTaiizor.Controls.AloneComboBox comboBoxVideo;
    }
}