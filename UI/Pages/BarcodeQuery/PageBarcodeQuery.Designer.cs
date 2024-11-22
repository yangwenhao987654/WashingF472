namespace DWZ_Scada.Pages
{
    partial class PageBarcodeQuery
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
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle7 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle8 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle9 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle10 = new DataGridViewCellStyle();
            tbx_input = new Sunny.UI.UITextBox();
            uiButton4 = new Sunny.UI.UIButton();
            dgv = new Sunny.UI.UIDataGridView();
            clmRowID = new DataGridViewTextBoxColumn();
            clmOrderNum = new DataGridViewTextBoxColumn();
            clmBarcode = new DataGridViewTextBoxColumn();
            clmCode = new DataGridViewTextBoxColumn();
            clmResult = new DataGridViewTextBoxColumn();
            clmMadeDate = new DataGridViewTextBoxColumn();
            clmScanTime = new DataGridViewTextBoxColumn();
            clmMsg = new DataGridViewTextBoxColumn();
            dtStart = new Sunny.UI.UIDatetimePicker();
            dtEnd = new Sunny.UI.UIDatetimePicker();
            uiLabel1 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiButton1 = new Sunny.UI.UIButton();
            uiPanel1 = new Sunny.UI.UIPanel();
            uiPanel2 = new Sunny.UI.UIPanel();
            lbl_NGCount = new Sunny.UI.UILabel();
            lbl_OKCount = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            rbtn_all = new Sunny.UI.UIRadioButton();
            rbtb_NG = new Sunny.UI.UIRadioButton();
            rbtn_OK = new Sunny.UI.UIRadioButton();
            uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            uiPanel1.SuspendLayout();
            uiPanel2.SuspendLayout();
            uiGroupBox1.SuspendLayout();
            uiTableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbx_input
            // 
            tbx_input.FillColor = SystemColors.ButtonHighlight;
            tbx_input.Font = new Font("黑体", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbx_input.ForeReadOnlyColor = Color.FromArgb(255, 224, 192);
            tbx_input.Location = new Point(18, 27);
            tbx_input.Margin = new Padding(4, 5, 4, 5);
            tbx_input.MinimumSize = new Size(1, 16);
            tbx_input.Name = "tbx_input";
            tbx_input.Padding = new Padding(5);
            tbx_input.RectColor = Color.Snow;
            tbx_input.RectReadOnlyColor = Color.FromArgb(255, 192, 192);
            tbx_input.ShowText = false;
            tbx_input.Size = new Size(360, 50);
            tbx_input.TabIndex = 45;
            tbx_input.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_input.Watermark = "请输入条码内容";
            // 
            // uiButton4
            // 
            uiButton4.Cursor = Cursors.Hand;
            uiButton4.FillColor = SystemColors.ButtonHighlight;
            uiButton4.FillColor2 = Color.Gray;
            uiButton4.FillHoverColor = Color.Silver;
            uiButton4.FillPressColor = Color.Gray;
            uiButton4.FillSelectedColor = Color.Silver;
            uiButton4.Font = new Font("微软雅黑", 22F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton4.ForeColor = Color.Black;
            uiButton4.ForeHoverColor = Color.Black;
            uiButton4.ForePressColor = Color.Black;
            uiButton4.ForeSelectedColor = Color.Black;
            uiButton4.Location = new Point(18, 100);
            uiButton4.Margin = new Padding(2);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.RectColor = Color.Silver;
            uiButton4.RectHoverColor = Color.Silver;
            uiButton4.RectPressColor = Color.Gray;
            uiButton4.RectSelectedColor = Color.Silver;
            uiButton4.Size = new Size(165, 50);
            uiButton4.TabIndex = 57;
            uiButton4.Text = "条码查询";
            uiButton4.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton4.Click += uiButton4_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(224, 224, 224);
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.Font = new Font("微软雅黑", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            dataGridViewCellStyle7.ForeColor = Color.Black;
            dataGridViewCellStyle7.Padding = new Padding(2);
            dataGridViewCellStyle7.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle7.SelectionForeColor = Color.Black;
            dataGridViewCellStyle7.WrapMode = DataGridViewTriState.False;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.Columns.AddRange(new DataGridViewColumn[] { clmRowID, clmOrderNum, clmBarcode, clmCode, clmResult, clmMadeDate, clmScanTime, clmMsg });
            dataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = SystemColors.Window;
            dataGridViewCellStyle8.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle8.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle8.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle8;
            dgv.Dock = DockStyle.Fill;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv.GridColor = Color.DimGray;
            dgv.Location = new Point(15, 199);
            dgv.Margin = new Padding(15, 5, 15, 5);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.RectColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle9.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle9.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle9.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle9.SelectionForeColor = Color.White;
            dataGridViewCellStyle9.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle10.BackColor = Color.White;
            dataGridViewCellStyle10.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle10.Padding = new Padding(2);
            dataGridViewCellStyle10.SelectionBackColor = Color.NavajoWhite;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle10;
            dgv.RowTemplate.Height = 35;
            dgv.SelectedIndex = -1;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1660, 574);
            dgv.StripeOddColor = Color.FromArgb(224, 224, 224);
            dgv.TabIndex = 58;
            // 
            // clmRowID
            // 
            clmRowID.HeaderText = "ID";
            clmRowID.Name = "clmRowID";
            clmRowID.Visible = false;
            // 
            // clmOrderNum
            // 
            clmOrderNum.HeaderText = "序号";
            clmOrderNum.MinimumWidth = 100;
            clmOrderNum.Name = "clmOrderNum";
            // 
            // clmBarcode
            // 
            clmBarcode.FillWeight = 200F;
            clmBarcode.HeaderText = "条码内容";
            clmBarcode.MinimumWidth = 150;
            clmBarcode.Name = "clmBarcode";
            // 
            // clmCode
            // 
            clmCode.FillWeight = 200F;
            clmCode.HeaderText = "产品编号";
            clmCode.MinimumWidth = 200;
            clmCode.Name = "clmCode";
            // 
            // clmResult
            // 
            clmResult.HeaderText = "扫码结果";
            clmResult.Name = "clmResult";
            // 
            // clmMadeDate
            // 
            clmMadeDate.HeaderText = "生产日期";
            clmMadeDate.Name = "clmMadeDate";
            // 
            // clmScanTime
            // 
            clmScanTime.HeaderText = "扫码时间";
            clmScanTime.Name = "clmScanTime";
            // 
            // clmMsg
            // 
            clmMsg.HeaderText = "信息";
            clmMsg.Name = "clmMsg";
            // 
            // dtStart
            // 
            dtStart.FillColor = Color.White;
            dtStart.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtStart.Location = new Point(1000, 26);
            dtStart.Margin = new Padding(4, 5, 4, 5);
            dtStart.MaxLength = 19;
            dtStart.MinimumSize = new Size(63, 0);
            dtStart.Name = "dtStart";
            dtStart.Padding = new Padding(0, 0, 30, 2);
            dtStart.Size = new Size(250, 35);
            dtStart.SymbolDropDown = 61555;
            dtStart.SymbolNormal = 61555;
            dtStart.SymbolSize = 24;
            dtStart.TabIndex = 59;
            dtStart.Text = "2024-11-21 14:48:01";
            dtStart.TextAlignment = ContentAlignment.MiddleLeft;
            dtStart.Value = new DateTime(2024, 11, 21, 14, 48, 1, 578);
            dtStart.Watermark = "";
            // 
            // dtEnd
            // 
            dtEnd.FillColor = Color.White;
            dtEnd.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dtEnd.Location = new Point(1000, 74);
            dtEnd.Margin = new Padding(4, 5, 4, 5);
            dtEnd.MaxLength = 19;
            dtEnd.MinimumSize = new Size(63, 0);
            dtEnd.Name = "dtEnd";
            dtEnd.Padding = new Padding(0, 0, 30, 2);
            dtEnd.Size = new Size(250, 35);
            dtEnd.SymbolDropDown = 61555;
            dtEnd.SymbolNormal = 61555;
            dtEnd.SymbolSize = 24;
            dtEnd.TabIndex = 60;
            dtEnd.Text = "2024-11-21 14:48:01";
            dtEnd.TextAlignment = ContentAlignment.MiddleLeft;
            dtEnd.Value = new DateTime(2024, 11, 21, 14, 48, 1, 578);
            dtEnd.Watermark = "";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(859, 28);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(133, 33);
            uiLabel1.TabIndex = 61;
            uiLabel1.Text = "开始时间:";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(858, 73);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(133, 33);
            uiLabel2.TabIndex = 62;
            uiLabel2.Text = "结束时间:";
            // 
            // uiButton1
            // 
            uiButton1.Cursor = Cursors.Hand;
            uiButton1.FillColor = SystemColors.ButtonHighlight;
            uiButton1.FillColor2 = Color.Gray;
            uiButton1.FillHoverColor = Color.Silver;
            uiButton1.FillPressColor = Color.Gray;
            uiButton1.FillSelectedColor = Color.Silver;
            uiButton1.Font = new Font("微软雅黑", 22F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.ForeColor = Color.Black;
            uiButton1.ForeHoverColor = Color.Black;
            uiButton1.ForePressColor = Color.Black;
            uiButton1.ForeSelectedColor = Color.Black;
            uiButton1.Location = new Point(859, 117);
            uiButton1.Margin = new Padding(2);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.Silver;
            uiButton1.RectHoverColor = Color.Silver;
            uiButton1.RectPressColor = Color.Gray;
            uiButton1.RectSelectedColor = Color.Silver;
            uiButton1.Size = new Size(145, 50);
            uiButton1.TabIndex = 58;
            uiButton1.Text = "批量查询";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Click += uiButton1_Click_1;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(uiPanel2);
            uiPanel1.Controls.Add(uiGroupBox1);
            uiPanel1.Controls.Add(uiButton1);
            uiPanel1.Controls.Add(tbx_input);
            uiPanel1.Controls.Add(uiButton4);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(dtStart);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(dtEnd);
            uiPanel1.Dock = DockStyle.Fill;
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(4, 5);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1800, 200);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1800, 200);
            uiPanel1.TabIndex = 64;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            uiPanel1.Click += uiPanel1_Click;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(lbl_NGCount);
            uiPanel2.Controls.Add(lbl_OKCount);
            uiPanel2.Controls.Add(uiLabel4);
            uiPanel2.Controls.Add(uiLabel3);
            uiPanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel2.Location = new Point(399, 26);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(194, 145);
            uiPanel2.TabIndex = 64;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // lbl_NGCount
            // 
            lbl_NGCount.Font = new Font("微软雅黑", 20F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl_NGCount.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_NGCount.Location = new Point(96, 91);
            lbl_NGCount.Name = "lbl_NGCount";
            lbl_NGCount.Size = new Size(95, 40);
            lbl_NGCount.TabIndex = 3;
            lbl_NGCount.Text = "00";
            // 
            // lbl_OKCount
            // 
            lbl_OKCount.Font = new Font("微软雅黑", 20F, FontStyle.Bold, GraphicsUnit.Point, 134);
            lbl_OKCount.ForeColor = Color.Green;
            lbl_OKCount.Location = new Point(96, 30);
            lbl_OKCount.Name = "lbl_OKCount";
            lbl_OKCount.Size = new Size(95, 41);
            lbl_OKCount.TabIndex = 2;
            lbl_OKCount.Text = "00";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel4.ForeColor = Color.Black;
            uiLabel4.Location = new Point(15, 91);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(83, 40);
            uiLabel4.TabIndex = 1;
            uiLabel4.Text = "异常";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = Color.Black;
            uiLabel3.Location = new Point(15, 31);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(83, 40);
            uiLabel3.TabIndex = 0;
            uiLabel3.Text = "良品:";
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(rbtn_all);
            uiGroupBox1.Controls.Add(rbtb_NG);
            uiGroupBox1.Controls.Add(rbtn_OK);
            uiGroupBox1.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox1.Location = new Point(655, 20);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(162, 151);
            uiGroupBox1.TabIndex = 63;
            uiGroupBox1.Text = "筛选条件";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // rbtn_all
            // 
            rbtn_all.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rbtn_all.Location = new Point(3, 112);
            rbtn_all.MinimumSize = new Size(1, 1);
            rbtn_all.Name = "rbtn_all";
            rbtn_all.Size = new Size(77, 29);
            rbtn_all.TabIndex = 2;
            rbtn_all.Text = "全部";
            // 
            // rbtb_NG
            // 
            rbtb_NG.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rbtb_NG.Location = new Point(3, 67);
            rbtb_NG.MinimumSize = new Size(1, 1);
            rbtb_NG.Name = "rbtb_NG";
            rbtb_NG.Size = new Size(150, 43);
            rbtb_NG.TabIndex = 1;
            rbtb_NG.Text = "异常";
            // 
            // rbtn_OK
            // 
            rbtn_OK.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rbtn_OK.Location = new Point(3, 35);
            rbtn_OK.MinimumSize = new Size(1, 1);
            rbtn_OK.Name = "rbtn_OK";
            rbtn_OK.Size = new Size(150, 29);
            rbtn_OK.TabIndex = 0;
            rbtn_OK.Text = "正常";
            // 
            // uiTableLayoutPanel1
            // 
            uiTableLayoutPanel1.ColumnCount = 1;
            uiTableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            uiTableLayoutPanel1.Controls.Add(dgv, 0, 1);
            uiTableLayoutPanel1.Controls.Add(uiPanel1, 0, 0);
            uiTableLayoutPanel1.Dock = DockStyle.Fill;
            uiTableLayoutPanel1.Location = new Point(0, 0);
            uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            uiTableLayoutPanel1.RowCount = 2;
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            uiTableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 75F));
            uiTableLayoutPanel1.Size = new Size(1690, 778);
            uiTableLayoutPanel1.TabIndex = 64;
            uiTableLayoutPanel1.TagString = null;
            // 
            // PageBarcodeQuery
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1690, 778);
            Controls.Add(uiTableLayoutPanel1);
            Name = "PageBarcodeQuery";
            RectColor = Color.Black;
            Text = "";
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            FormClosing += Formula_set_FormClosing;
            Load += Page_Formula_Set_Load;
            SizeChanged += Page_Formula_Set_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            uiPanel1.ResumeLayout(false);
            uiPanel2.ResumeLayout(false);
            uiGroupBox1.ResumeLayout(false);
            uiTableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UITextBox tbx_input;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIDataGridView dgv;
        private Sunny.UI.UIDatetimePicker dtStart;
        private Sunny.UI.UIDatetimePicker dtEnd;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UIButton uiButton1;
        private DataGridViewTextBoxColumn clmRowID;
        private DataGridViewTextBoxColumn clmOrderNum;
        private DataGridViewTextBoxColumn clmBarcode;
        private DataGridViewTextBoxColumn clmCode;
        private DataGridViewTextBoxColumn clmResult;
        private DataGridViewTextBoxColumn clmMadeDate;
        private DataGridViewTextBoxColumn clmScanTime;
        private DataGridViewTextBoxColumn clmMsg;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIRadioButton rbtn_all;
        private Sunny.UI.UIRadioButton rbtb_NG;
        private Sunny.UI.UIRadioButton rbtn_OK;
        private Sunny.UI.UIPanel uiPanel2;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel lbl_NGCount;
        private Sunny.UI.UILabel lbl_OKCount;
    }
}