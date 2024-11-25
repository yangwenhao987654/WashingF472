namespace DWZ_Scada.Forms.ProductFormula
{
    partial class FormProductFormulaSetting
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
            uiButton1 = new Sunny.UI.UIButton();
            uiButton2 = new Sunny.UI.UIButton();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel4 = new Sunny.UI.UILabel();
            tbxName = new Sunny.UI.UITextBox();
            tbx_Code = new Sunny.UI.UITextBox();
            uiComboBox1 = new Sunny.UI.UIComboBox();
            uiPanel1 = new Sunny.UI.UIPanel();
            ctrlCode40 = new UI.CtrlCodeInfo.CtrlCode40();
            ctrlCode43 = new UI.CtrlCodeInfo.CtrlCode43();
            ctrlCode14 = new UI.CtrlCodeInfo.CtrlCode14();
            ctrlCode31 = new UI.CtrlCodeInfo.CtrlCode31();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiButton1
            // 
            uiButton1.FillColor = Color.White;
            uiButton1.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.ForeColor = Color.Black;
            uiButton1.Location = new Point(222, 779);
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
            uiButton2.Location = new Point(608, 779);
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
            uiLabel2.Location = new Point(303, 65);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(127, 38);
            uiLabel2.TabIndex = 3;
            uiLabel2.Text = "产品名称:";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(303, 121);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(127, 38);
            uiLabel3.TabIndex = 4;
            uiLabel3.Text = "产品编号:";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(303, 186);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(127, 38);
            uiLabel4.TabIndex = 5;
            uiLabel4.Text = "条码类型:";
            // 
            // tbxName
            // 
            tbxName.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbxName.Location = new Point(437, 65);
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
            // tbx_Code
            // 
            tbx_Code.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbx_Code.Location = new Point(437, 121);
            tbx_Code.Margin = new Padding(4, 5, 4, 5);
            tbx_Code.MinimumSize = new Size(1, 16);
            tbx_Code.Name = "tbx_Code";
            tbx_Code.Padding = new Padding(5);
            tbx_Code.ShowText = false;
            tbx_Code.Size = new Size(244, 38);
            tbx_Code.TabIndex = 8;
            tbx_Code.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_Code.Watermark = "";
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(437, 185);
            uiComboBox1.Margin = new Padding(4, 5, 4, 5);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Size = new Size(244, 39);
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 11;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "选择条码种类";
            uiComboBox1.SelectedIndexChanged += uiComboBox1_SelectedIndexChanged;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(ctrlCode40);
            uiPanel1.Controls.Add(ctrlCode43);
            uiPanel1.Controls.Add(ctrlCode14);
            uiPanel1.Controls.Add(ctrlCode31);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(62, 240);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(881, 510);
            uiPanel1.TabIndex = 12;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // ctrlCode40
            // 
            ctrlCode40.BackColor = Color.Transparent;
            ctrlCode40.Location = new Point(201, 24);
            ctrlCode40.Name = "ctrlCode40";
            ctrlCode40.Size = new Size(562, 411);
            ctrlCode40.TabIndex = 13;
            ctrlCode40.Visible = false;
            // 
            // ctrlCode43
            // 
            ctrlCode43.BackColor = Color.Transparent;
            ctrlCode43.Location = new Point(219, 24);
            ctrlCode43.Name = "ctrlCode43";
            ctrlCode43.Size = new Size(562, 411);
            ctrlCode43.TabIndex = 14;
            ctrlCode43.Visible = false;
            // 
            // ctrlCode14
            // 
            ctrlCode14.BackColor = Color.Transparent;
            ctrlCode14.Location = new Point(219, 24);
            ctrlCode14.Name = "ctrlCode14";
            ctrlCode14.Size = new Size(562, 411);
            ctrlCode14.TabIndex = 1;
            ctrlCode14.Visible = false;
            // 
            // ctrlCode31
            // 
            ctrlCode31.BackColor = Color.Transparent;
            ctrlCode31.Location = new Point(186, 12);
            ctrlCode31.Name = "ctrlCode31";
            ctrlCode31.Size = new Size(562, 411);
            ctrlCode31.TabIndex = 0;
            ctrlCode31.Visible = false;
            // 
            // FormProductFormulaSetting
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.AliceBlue;
            ClientSize = new Size(1086, 854);
            Controls.Add(uiPanel1);
            Controls.Add(uiComboBox1);
            Controls.Add(tbx_Code);
            Controls.Add(tbxName);
            Controls.Add(uiLabel4);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel2);
            Controls.Add(uiButton2);
            Controls.Add(uiButton1);
            Name = "FormProductFormulaSetting";
            Text = "产品配方编辑";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FormProductFormulaAdd_Load;
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UITextBox tbxName;
        private Sunny.UI.UITextBox tbx_Code;
        private Sunny.UI.UIComboBox uiComboBox1;
        private Sunny.UI.UIPanel uiPanel1;
        private UI.CtrlCodeInfo.CtrlCode31 ctrlCode31;
        private UI.CtrlCodeInfo.CtrlCode14 ctrlCode14;
        private UI.CtrlCodeInfo.CtrlCode40 ctrlCode40;
        private UI.CtrlCodeInfo.CtrlCode43 ctrlCode43;
    }
}