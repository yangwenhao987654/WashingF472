namespace DWZ_Scada.Pages
{
    partial class PageFormulaQuery
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            tbx_input = new Sunny.UI.UITextBox();
            uiButton1 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton3 = new Sunny.UI.UIButton();
            uiButton4 = new Sunny.UI.UIButton();
            dgv = new Sunny.UI.UIDataGridView();
            clmRowID = new DataGridViewTextBoxColumn();
            clmOrderNum = new DataGridViewTextBoxColumn();
            clmName = new DataGridViewTextBoxColumn();
            clmCode = new DataGridViewTextBoxColumn();
            clmBarcodeType = new DataGridViewTextBoxColumn();
            clmSupplierCode = new DataGridViewTextBoxColumn();
            clmPartNum = new DataGridViewTextBoxColumn();
            clmFixValue1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // tbx_input
            // 
            tbx_input.FillColor = SystemColors.ButtonHighlight;
            tbx_input.Font = new Font("黑体", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbx_input.ForeReadOnlyColor = Color.FromArgb(255, 224, 192);
            tbx_input.Location = new Point(48, 28);
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
            tbx_input.Watermark = "请输入产品编号";
            // 
            // uiButton1
            // 
            uiButton1.Cursor = Cursors.Hand;
            uiButton1.FillColor = SystemColors.ButtonHighlight;
            uiButton1.FillColor2 = Color.WhiteSmoke;
            uiButton1.FillHoverColor = Color.Silver;
            uiButton1.FillPressColor = Color.Gray;
            uiButton1.FillSelectedColor = Color.Silver;
            uiButton1.Font = new Font("微软雅黑", 22F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.ForeColor = Color.Black;
            uiButton1.ForeHoverColor = Color.Black;
            uiButton1.ForePressColor = Color.Black;
            uiButton1.ForeSelectedColor = Color.Black;
            uiButton1.Location = new Point(730, 28);
            uiButton1.Margin = new Padding(2);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.RectColor = Color.Silver;
            uiButton1.RectHoverColor = Color.Silver;
            uiButton1.RectPressColor = Color.Gray;
            uiButton1.RectSelectedColor = Color.Silver;
            uiButton1.Size = new Size(145, 50);
            uiButton1.TabIndex = 54;
            uiButton1.Text = "添加";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Click += uiButton1_Click;
            // 
            // uiButton2
            // 
            uiButton2.Cursor = Cursors.Hand;
            uiButton2.FillColor = SystemColors.ButtonHighlight;
            uiButton2.FillColor2 = Color.Gray;
            uiButton2.FillHoverColor = Color.Silver;
            uiButton2.FillPressColor = Color.Gray;
            uiButton2.FillSelectedColor = Color.Silver;
            uiButton2.Font = new Font("微软雅黑", 22F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.ForeColor = Color.Black;
            uiButton2.ForeHoverColor = Color.Black;
            uiButton2.ForePressColor = Color.Black;
            uiButton2.ForeSelectedColor = Color.Black;
            uiButton2.Location = new Point(1151, 28);
            uiButton2.Margin = new Padding(2);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.RectColor = Color.Silver;
            uiButton2.RectHoverColor = Color.Silver;
            uiButton2.RectPressColor = Color.Gray;
            uiButton2.RectSelectedColor = Color.Silver;
            uiButton2.Size = new Size(145, 50);
            uiButton2.TabIndex = 55;
            uiButton2.Text = "删除";
            uiButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.Click += uiButton2_Click;
            // 
            // uiButton3
            // 
            uiButton3.Cursor = Cursors.Hand;
            uiButton3.FillColor = SystemColors.ButtonHighlight;
            uiButton3.FillColor2 = Color.Gray;
            uiButton3.FillHoverColor = Color.Silver;
            uiButton3.FillPressColor = Color.Gray;
            uiButton3.FillSelectedColor = Color.Silver;
            uiButton3.Font = new Font("微软雅黑", 22F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.ForeColor = Color.Black;
            uiButton3.ForeHoverColor = Color.Black;
            uiButton3.ForePressColor = Color.Black;
            uiButton3.ForeSelectedColor = Color.Black;
            uiButton3.Location = new Point(941, 28);
            uiButton3.Margin = new Padding(2);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.RectColor = Color.Silver;
            uiButton3.RectHoverColor = Color.Silver;
            uiButton3.RectPressColor = Color.Gray;
            uiButton3.RectSelectedColor = Color.Silver;
            uiButton3.Size = new Size(145, 50);
            uiButton3.TabIndex = 56;
            uiButton3.Text = "修改";
            uiButton3.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.Click += uiButton3_Click;
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
            uiButton4.Location = new Point(512, 28);
            uiButton4.Margin = new Padding(2);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.RectColor = Color.Silver;
            uiButton4.RectHoverColor = Color.Silver;
            uiButton4.RectPressColor = Color.Gray;
            uiButton4.RectSelectedColor = Color.Silver;
            uiButton4.Size = new Size(145, 50);
            uiButton4.TabIndex = 57;
            uiButton4.Text = "查询";
            uiButton4.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton4.Click += uiButton4_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(224, 224, 224);
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.Font = new Font("微软雅黑", 18F, FontStyle.Bold, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.Black;
            dataGridViewCellStyle2.Padding = new Padding(2);
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle2.SelectionForeColor = Color.Black;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeight = 50;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.Columns.AddRange(new DataGridViewColumn[] { clmRowID, clmOrderNum, clmName, clmCode, clmBarcodeType, clmSupplierCode, clmPartNum, clmFixValue1 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle3;
            dgv.Dock = DockStyle.Bottom;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv.GridColor = Color.DimGray;
            dgv.Location = new Point(0, 134);
            dgv.Margin = new Padding(15, 5, 15, 5);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dgv.RectColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.Silver;
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv.RowHeadersWidth = 51;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle5.Padding = new Padding(2);
            dataGridViewCellStyle5.SelectionBackColor = Color.NavajoWhite;
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv.RowTemplate.Height = 35;
            dgv.SelectedIndex = -1;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(1703, 644);
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
            // clmName
            // 
            clmName.FillWeight = 200F;
            clmName.HeaderText = "名称";
            clmName.MinimumWidth = 150;
            clmName.Name = "clmName";
            // 
            // clmCode
            // 
            clmCode.FillWeight = 200F;
            clmCode.HeaderText = "编号";
            clmCode.MinimumWidth = 200;
            clmCode.Name = "clmCode";
            // 
            // clmBarcodeType
            // 
            clmBarcodeType.HeaderText = "条码类型";
            clmBarcodeType.Name = "clmBarcodeType";
            // 
            // clmSupplierCode
            // 
            clmSupplierCode.HeaderText = "供应商代码";
            clmSupplierCode.Name = "clmSupplierCode";
            // 
            // clmPartNum
            // 
            clmPartNum.HeaderText = "零件号";
            clmPartNum.Name = "clmPartNum";
            // 
            // clmFixValue1
            // 
            clmFixValue1.HeaderText = "固定值1";
            clmFixValue1.Name = "clmFixValue1";
            // 
            // PageFormulaQuery
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1703, 778);
            Controls.Add(dgv);
            Controls.Add(uiButton4);
            Controls.Add(uiButton3);
            Controls.Add(uiButton2);
            Controls.Add(uiButton1);
            Controls.Add(tbx_input);
            Name = "PageFormulaQuery";
            RectColor = Color.Black;
            Text = "";
            TitleHeight = 29;
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            FormClosing += Formula_set_FormClosing;
            Load += Page_Formula_Set_Load;
            SizeChanged += Page_Formula_Set_SizeChanged;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UITextBox tbx_input;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIDataGridView dgv;
        private DataGridViewTextBoxColumn clmRowID;
        private DataGridViewTextBoxColumn clmOrderNum;
        private DataGridViewTextBoxColumn clmName;
        private DataGridViewTextBoxColumn clmCode;
        private DataGridViewTextBoxColumn clmBarcodeType;
        private DataGridViewTextBoxColumn clmSupplierCode;
        private DataGridViewTextBoxColumn clmPartNum;
        private DataGridViewTextBoxColumn clmFixValue1;
    }
}