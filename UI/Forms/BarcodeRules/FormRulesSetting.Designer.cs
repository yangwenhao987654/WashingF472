namespace DWZ_Scada.Forms.ProductFormula
{
    partial class FormRulesSetting
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
            uiButton1 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            uiLabel2 = new Sunny.UI.UILabel();
            tbxName = new Sunny.UI.UITextBox();
            uiButton3 = new Sunny.UI.UIButton();
            dgv = new Sunny.UI.UIDataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            Column6 = new DataGridViewTextBoxColumn();
            uiButton4 = new Sunny.UI.UIButton();
            uiButton5 = new Sunny.UI.UIButton();
            uiButton6 = new Sunny.UI.UIButton();
            uiButton7 = new Sunny.UI.UIButton();
            ((System.ComponentModel.ISupportInitialize)dgv).BeginInit();
            SuspendLayout();
            // 
            // uiButton1
            // 
            uiButton1.FillColor = Color.White;
            uiButton1.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.ForeColor = Color.Black;
            uiButton1.Location = new Point(152, 527);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(107, 48);
            uiButton1.TabIndex = 0;
            uiButton1.Text = "保存";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Click += uiButton1_Click;
            // 
            // uiButton2
            // 
            uiButton2.FillColor = Color.White;
            uiButton2.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.ForeColor = Color.Black;
            uiButton2.Location = new Point(437, 527);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.RectHoverColor = Color.Red;
            uiButton2.Size = new Size(107, 48);
            uiButton2.TabIndex = 1;
            uiButton2.Text = "取消";
            uiButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.Click += uiButton2_Click;
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(87, 52);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(127, 38);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "规则名称:";
            // 
            // tbxName
            // 
            tbxName.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbxName.Location = new Point(221, 52);
            tbxName.Margin = new Padding(4, 5, 4, 5);
            tbxName.MinimumSize = new Size(1, 16);
            tbxName.Name = "tbxName";
            tbxName.Padding = new Padding(5);
            tbxName.ShowText = false;
            tbxName.Size = new Size(244, 38);
            tbxName.TabIndex = 7;
            tbxName.TextAlignment = ContentAlignment.MiddleLeft;
            tbxName.Watermark = "";
            // 
            // uiButton3
            // 
            uiButton3.FillColor = Color.White;
            uiButton3.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.ForeColor = Color.Black;
            uiButton3.Location = new Point(690, 376);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(107, 48);
            uiButton3.TabIndex = 8;
            uiButton3.Text = "添加";
            uiButton3.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.Click += uiButton3_Click;
            // 
            // dgv
            // 
            dgv.AllowUserToAddRows = false;
            dgv.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(235, 243, 255);
            dgv.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dgv.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgv.BackgroundColor = Color.White;
            dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dgv.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dgv.ColumnHeadersHeight = 32;
            dgv.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dgv.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5, Column6 });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dgv.DefaultCellStyle = dataGridViewCellStyle3;
            dgv.EditMode = DataGridViewEditMode.EditOnF2;
            dgv.EnableHeadersVisualStyles = false;
            dgv.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv.GridColor = Color.FromArgb(80, 160, 255);
            dgv.Location = new Point(26, 124);
            dgv.MultiSelect = false;
            dgv.Name = "dgv";
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(235, 243, 255);
            dataGridViewCellStyle4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(48, 48, 48);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(80, 160, 255);
            dataGridViewCellStyle4.SelectionForeColor = Color.White;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dgv.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dgv.RowHeadersVisible = false;
            dataGridViewCellStyle5.BackColor = Color.White;
            dataGridViewCellStyle5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            dgv.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dgv.SelectedIndex = -1;
            dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgv.Size = new Size(629, 384);
            dgv.StripeOddColor = Color.FromArgb(235, 243, 255);
            dgv.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "序号";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "名称";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "长度";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "类型";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "匹配值";
            Column5.Name = "Column5";
            // 
            // Column6
            // 
            Column6.HeaderText = "ID";
            Column6.Name = "Column6";
            Column6.Visible = false;
            // 
            // uiButton4
            // 
            uiButton4.FillColor = Color.White;
            uiButton4.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton4.ForeColor = Color.Black;
            uiButton4.Location = new Point(690, 297);
            uiButton4.MinimumSize = new Size(1, 1);
            uiButton4.Name = "uiButton4";
            uiButton4.Size = new Size(107, 48);
            uiButton4.TabIndex = 10;
            uiButton4.Text = "上移";
            uiButton4.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton4.Click += uiButton4_Click;
            // 
            // uiButton5
            // 
            uiButton5.FillColor = Color.White;
            uiButton5.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton5.ForeColor = Color.Black;
            uiButton5.Location = new Point(690, 205);
            uiButton5.MinimumSize = new Size(1, 1);
            uiButton5.Name = "uiButton5";
            uiButton5.Size = new Size(107, 48);
            uiButton5.TabIndex = 11;
            uiButton5.Text = "下移";
            uiButton5.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton5.Click += uiButton5_Click;
            // 
            // uiButton6
            // 
            uiButton6.FillColor = Color.White;
            uiButton6.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton6.ForeColor = Color.Black;
            uiButton6.Location = new Point(691, 459);
            uiButton6.MinimumSize = new Size(1, 1);
            uiButton6.Name = "uiButton6";
            uiButton6.Size = new Size(107, 48);
            uiButton6.TabIndex = 12;
            uiButton6.Text = "删除";
            uiButton6.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton6.Click += uiButton6_Click;
            // 
            // uiButton7
            // 
            uiButton7.FillColor = Color.White;
            uiButton7.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton7.ForeColor = Color.Black;
            uiButton7.Location = new Point(690, 116);
            uiButton7.MinimumSize = new Size(1, 1);
            uiButton7.Name = "uiButton7";
            uiButton7.Size = new Size(107, 48);
            uiButton7.TabIndex = 13;
            uiButton7.Text = "编辑";
            uiButton7.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton7.Click += uiButton7_Click;
            // 
            // FormRulesSetting
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(858, 602);
            Controls.Add(uiButton7);
            Controls.Add(uiButton6);
            Controls.Add(uiButton5);
            Controls.Add(uiButton4);
            Controls.Add(dgv);
            Controls.Add(uiButton3);
            Controls.Add(tbxName);
            Controls.Add(uiLabel2);
            Controls.Add(uiButton2);
            Controls.Add(uiButton1);
            Name = "FormRulesSetting";
            Text = "产品规则编辑";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FormRulesAdd_Load;
            ((System.ComponentModel.ISupportInitialize)dgv).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UITextBox tbxName;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UIDataGridView dgv;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton5;
        private Sunny.UI.UIButton uiButton6;
        private Sunny.UI.UIButton uiButton7;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
    }
}