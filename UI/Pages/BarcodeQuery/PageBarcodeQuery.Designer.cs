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
            DataGridViewCellStyle dataGridViewCellStyle11 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle12 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle13 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle14 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle15 = new DataGridViewCellStyle();
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
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiButton1 = new Sunny.UI.UIButton();
            uiRadioButton3 = new Sunny.UI.UIRadioButton();
            uiRadioButton2 = new Sunny.UI.UIRadioButton();
            uiRadioButton1 = new Sunny.UI.UIRadioButton();
            uiPanel1 = new Sunny.UI.UIPanel();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            uiGroupBox1.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // tbx_input
            // 
            tbx_input.FillColor = SystemColors.ButtonHighlight;
            tbx_input.Font = new Font("黑体", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbx_input.ForeReadOnlyColor = Color.FromArgb(255, 224, 192);
            tbx_input.Location = new Point(13, 90);
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
            uiButton4.Location = new Point(404, 87);
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
            dataGridViewCellStyle11.BackColor = Color.FromArgb(224, 224, 224);
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle11;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle12.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle12.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.Font = new Font("微软雅黑", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            dataGridViewCellStyle12.ForeColor = Color.Black;
            dataGridViewCellStyle12.Padding = new Padding(2);
            dataGridViewCellStyle12.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle12.SelectionForeColor = Color.Black;
            dataGridViewCellStyle12.WrapMode = DataGridViewTriState.False;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle12;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.Columns.AddRange(new DataGridViewColumn[] { clmRowID, clmOrderNum, clmBarcode, clmCode, clmResult, clmMadeDate, clmScanTime, clmMsg });
            dataGridViewCellStyle13.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = SystemColors.Window;
            dataGridViewCellStyle13.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle13.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle13.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle13;
            dgv.Dock = DockStyle.Bottom;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv.GridColor = Color.DimGray;
            dgv.Location = new Point(0, 214);
            dgv.Margin = new Padding(15, 5, 15, 5);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.RectColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle14.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle14.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle14.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle14.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle14.SelectionForeColor = Color.White;
            dataGridViewCellStyle14.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle14;
            dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle15.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle15.BackColor = Color.White;
            dataGridViewCellStyle15.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle15.Padding = new Padding(2);
            dataGridViewCellStyle15.SelectionBackColor = Color.NavajoWhite;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle15;
            dgv.RowTemplate.Height = 35;
            dgv.SelectedIndex = -1;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1745, 564);
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
            dtStart.Location = new Point(759, 76);
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
            dtEnd.Location = new Point(759, 124);
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
            uiLabel1.Location = new Point(618, 78);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(133, 33);
            uiLabel1.TabIndex = 61;
            uiLabel1.Text = "开始时间:";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(617, 123);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(133, 33);
            uiLabel2.TabIndex = 62;
            uiLabel2.Text = "结束时间:";
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(uiButton1);
            uiGroupBox1.Controls.Add(uiRadioButton3);
            uiGroupBox1.Controls.Add(uiRadioButton2);
            uiGroupBox1.Controls.Add(uiRadioButton1);
            uiGroupBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox1.Location = new Point(1097, 76);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(548, 110);
            uiGroupBox1.TabIndex = 63;
            uiGroupBox1.Text = "uiGroupBox1";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
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
            uiButton1.Location = new Point(313, 46);
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
            // uiRadioButton3
            // 
            uiRadioButton3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiRadioButton3.Location = new Point(199, 41);
            uiRadioButton3.MinimumSize = new Size(1, 1);
            uiRadioButton3.Name = "uiRadioButton3";
            uiRadioButton3.Size = new Size(150, 29);
            uiRadioButton3.TabIndex = 2;
            uiRadioButton3.Text = "全部";
            // 
            // uiRadioButton2
            // 
            uiRadioButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiRadioButton2.Location = new Point(13, 67);
            uiRadioButton2.MinimumSize = new Size(1, 1);
            uiRadioButton2.Name = "uiRadioButton2";
            uiRadioButton2.Size = new Size(150, 29);
            uiRadioButton2.TabIndex = 1;
            uiRadioButton2.Text = "NG";
            // 
            // uiRadioButton1
            // 
            uiRadioButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiRadioButton1.Location = new Point(13, 35);
            uiRadioButton1.MinimumSize = new Size(1, 1);
            uiRadioButton1.Name = "uiRadioButton1";
            uiRadioButton1.Size = new Size(150, 29);
            uiRadioButton1.TabIndex = 0;
            uiRadioButton1.Text = "OK";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(tbx_input);
            uiPanel1.Controls.Add(uiGroupBox1);
            uiPanel1.Controls.Add(uiButton4);
            uiPanel1.Controls.Add(uiLabel2);
            uiPanel1.Controls.Add(dtStart);
            uiPanel1.Controls.Add(uiLabel1);
            uiPanel1.Controls.Add(dtEnd);
            uiPanel1.Dock = DockStyle.Top;
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(0, 0);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1745, 204);
            uiPanel1.TabIndex = 64;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // PageBarcodeQuery
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1745, 778);
            Controls.Add(uiPanel1);
            Controls.Add(dgv);
            Name = "PageBarcodeQuery";
            RectColor = Color.Black;
            Text = "";
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            FormClosing += Formula_set_FormClosing;
            Load += Page_Formula_Set_Load;
            SizeChanged += Page_Formula_Set_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            uiGroupBox1.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
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
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIRadioButton uiRadioButton3;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIRadioButton uiRadioButton1;
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
    }
}