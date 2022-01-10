
namespace RSI_X_Desktop.forms.HelpingClass
{
    partial class ChatForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChatForm));
            this.tablePanel1 = new DevExpress.Utils.Layout.TablePanel();
            this.tableLayoutPanel7 = new System.Windows.Forms.TableLayoutPanel();
            this.ScrollPanel = new System.Windows.Forms.Panel();
            this.SupportScroll = new ReaLTaiizor.Controls.PoisonScrollBar();
            this.PSupport = new ReaLTaiizor.Controls.Panel();
            this.tablePanel2 = new DevExpress.Utils.Layout.TablePanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tablePanel3 = new DevExpress.Utils.Layout.TablePanel();
            this.SendMsgBtn = new DevExpress.XtraEditors.SvgImageBox();
            this.bigTextBox2 = new ReaLTaiizor.Controls.RichTextBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).BeginInit();
            this.tablePanel1.SuspendLayout();
            this.tableLayoutPanel7.SuspendLayout();
            this.ScrollPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).BeginInit();
            this.tablePanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).BeginInit();
            this.tablePanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SendMsgBtn)).BeginInit();
            this.SuspendLayout();
            // 
            // tablePanel1
            // 
            this.tablePanel1.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 100F)});
            this.tablePanel1.Controls.Add(this.tableLayoutPanel7);
            this.tablePanel1.Controls.Add(this.tablePanel2);
            this.tablePanel1.Controls.Add(this.label1);
            this.tablePanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel1.Location = new System.Drawing.Point(0, 0);
            this.tablePanel1.Name = "tablePanel1";
            this.tablePanel1.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 10F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 65F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 150F)});
            this.tablePanel1.Size = new System.Drawing.Size(450, 800);
            this.tablePanel1.TabIndex = 0;
            // 
            // tableLayoutPanel7
            // 
            this.tablePanel1.SetColumn(this.tableLayoutPanel7, 0);
            this.tableLayoutPanel7.ColumnCount = 2;
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 95F));
            this.tableLayoutPanel7.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.tableLayoutPanel7.Controls.Add(this.ScrollPanel, 1, 0);
            this.tableLayoutPanel7.Controls.Add(this.PSupport, 0, 0);
            this.tableLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel7.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel7.Location = new System.Drawing.Point(25, 87);
            this.tableLayoutPanel7.Margin = new System.Windows.Forms.Padding(25, 0, 25, 0);
            this.tableLayoutPanel7.Name = "tableLayoutPanel7";
            this.tablePanel1.SetRow(this.tableLayoutPanel7, 1);
            this.tableLayoutPanel7.RowCount = 1;
            this.tableLayoutPanel7.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel7.Size = new System.Drawing.Size(400, 563);
            this.tableLayoutPanel7.TabIndex = 3;
            // 
            // ScrollPanel
            // 
            this.ScrollPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ScrollPanel.Controls.Add(this.SupportScroll);
            this.ScrollPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ScrollPanel.Location = new System.Drawing.Point(380, 0);
            this.ScrollPanel.Margin = new System.Windows.Forms.Padding(0);
            this.ScrollPanel.Name = "ScrollPanel";
            this.ScrollPanel.Size = new System.Drawing.Size(20, 563);
            this.ScrollPanel.TabIndex = 0;
            // 
            // SupportScroll
            // 
            this.SupportScroll.BackColor = System.Drawing.Color.White;
            this.SupportScroll.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SupportScroll.LargeChange = 1;
            this.SupportScroll.Location = new System.Drawing.Point(0, 0);
            this.SupportScroll.Maximum = 1;
            this.SupportScroll.Minimum = 0;
            this.SupportScroll.MouseWheelBarPartitions = 1;
            this.SupportScroll.Name = "SupportScroll";
            this.SupportScroll.Orientation = ReaLTaiizor.Enum.Poison.ScrollOrientationType.Vertical;
            this.SupportScroll.ScrollbarSize = 20;
            this.SupportScroll.Size = new System.Drawing.Size(20, 563);
            this.SupportScroll.TabIndex = 0;
            this.SupportScroll.Text = "poisonScrollBar1";
            this.SupportScroll.UseSelectable = true;
            this.SupportScroll.ValueChanged += new ReaLTaiizor.Controls.PoisonScrollBar.ScrollValueChangedDelegate(this.SupportScroll_ValueChanged);
            // 
            // PSupport
            // 
            this.PSupport.BackColor = System.Drawing.Color.White;
            this.PSupport.Cursor = System.Windows.Forms.Cursors.Default;
            this.PSupport.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PSupport.EdgeColor = System.Drawing.SystemColors.Control;
            this.PSupport.Location = new System.Drawing.Point(0, 0);
            this.PSupport.Margin = new System.Windows.Forms.Padding(0);
            this.PSupport.Name = "PSupport";
            this.PSupport.Padding = new System.Windows.Forms.Padding(5);
            this.PSupport.Size = new System.Drawing.Size(380, 563);
            this.PSupport.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.PSupport.TabIndex = 3;
            this.PSupport.Text = "panel3";
            // 
            // tablePanel2
            // 
            this.tablePanel1.SetColumn(this.tablePanel2, 0);
            this.tablePanel2.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F)});
            this.tablePanel2.Controls.Add(this.bigTextBox2);
            this.tablePanel2.Controls.Add(this.tablePanel3);
            this.tablePanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel2.Location = new System.Drawing.Point(0, 650);
            this.tablePanel2.Margin = new System.Windows.Forms.Padding(0);
            this.tablePanel2.Name = "tablePanel2";
            this.tablePanel1.SetRow(this.tablePanel2, 2);
            this.tablePanel2.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 55F),
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 45F)});
            this.tablePanel2.Size = new System.Drawing.Size(450, 150);
            this.tablePanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.tablePanel1.SetColumn(this.label1, 0);
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.tablePanel1.SetRow(this.label1, 0);
            this.label1.Size = new System.Drawing.Size(444, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = "RSI X Chat";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tablePanel3
            // 
            this.tablePanel2.SetColumn(this.tablePanel3, 0);
            this.tablePanel3.Columns.AddRange(new DevExpress.Utils.Layout.TablePanelColumn[] {
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 65F),
            new DevExpress.Utils.Layout.TablePanelColumn(DevExpress.Utils.Layout.TablePanelEntityStyle.Relative, 35F)});
            this.tablePanel3.Controls.Add(this.SendMsgBtn);
            this.tablePanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tablePanel3.Location = new System.Drawing.Point(3, 86);
            this.tablePanel3.Name = "tablePanel3";
            this.tablePanel2.SetRow(this.tablePanel3, 1);
            this.tablePanel3.Rows.AddRange(new DevExpress.Utils.Layout.TablePanelRow[] {
            new DevExpress.Utils.Layout.TablePanelRow(DevExpress.Utils.Layout.TablePanelEntityStyle.Absolute, 26F)});
            this.tablePanel3.Size = new System.Drawing.Size(444, 61);
            this.tablePanel3.TabIndex = 2;
            // 
            // SendMsgBtn
            // 
            this.tablePanel3.SetColumn(this.SendMsgBtn, 1);
            this.SendMsgBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SendMsgBtn.Location = new System.Drawing.Point(292, 3);
            this.SendMsgBtn.Name = "SendMsgBtn";
            this.tablePanel3.SetRow(this.SendMsgBtn, 0);
            this.SendMsgBtn.Size = new System.Drawing.Size(149, 55);
            this.SendMsgBtn.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SendMsgBtn.SvgImage")));
            this.SendMsgBtn.TabIndex = 0;
            this.SendMsgBtn.Click += new System.EventHandler(this.chatButtonRight2_Click);
            // 
            // bigTextBox2
            // 
            this.bigTextBox2.AutoWordSelection = false;
            this.bigTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.bigTextBox2.BaseColor = System.Drawing.Color.Transparent;
            this.bigTextBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.tablePanel2.SetColumn(this.bigTextBox2, 0);
            this.bigTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bigTextBox2.EdgeColor = System.Drawing.Color.White;
            this.bigTextBox2.Font = new System.Drawing.Font("Leelawadee", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigTextBox2.ForeColor = System.Drawing.Color.DimGray;
            this.bigTextBox2.Location = new System.Drawing.Point(3, 3);
            this.bigTextBox2.Name = "bigTextBox2";
            this.bigTextBox2.ReadOnly = false;
            this.tablePanel2.SetRow(this.bigTextBox2, 0);
            this.bigTextBox2.Size = new System.Drawing.Size(444, 77);
            this.bigTextBox2.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            this.bigTextBox2.TabIndex = 3;
            this.bigTextBox2.Text = "Type in your message";
            this.bigTextBox2.TextBackColor = System.Drawing.Color.White;
            this.bigTextBox2.TextBorderStyle = System.Windows.Forms.BorderStyle.None;
            this.bigTextBox2.TextFont = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bigTextBox2.WordWrap = true;
            // 
            // ChatForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(450, 800);
            this.Controls.Add(this.tablePanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ChatForm";
            this.ShowInTaskbar = false;
            this.Text = "ChatForm";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ChatWnd_FormClosed);
            this.Load += new System.EventHandler(this.ChatForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel1)).EndInit();
            this.tablePanel1.ResumeLayout(false);
            this.tablePanel1.PerformLayout();
            this.tableLayoutPanel7.ResumeLayout(false);
            this.ScrollPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel2)).EndInit();
            this.tablePanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tablePanel3)).EndInit();
            this.tablePanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SendMsgBtn)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.Utils.Layout.TablePanel tablePanel1;
        private System.Windows.Forms.Label label1;
        private DevExpress.Utils.Layout.TablePanel tablePanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel7;
        private System.Windows.Forms.Panel ScrollPanel;
        private ReaLTaiizor.Controls.PoisonScrollBar SupportScroll;
        private ReaLTaiizor.Controls.Panel PSupport;
        private DevExpress.Utils.Layout.TablePanel tablePanel3;
        private DevExpress.XtraEditors.SvgImageBox SendMsgBtn;
        private ReaLTaiizor.Controls.RichTextBoxEdit bigTextBox2;
    }
}