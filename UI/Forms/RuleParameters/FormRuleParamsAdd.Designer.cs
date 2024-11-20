namespace UI.Forms.RuleParameters
{
    partial class FormRuleParamsAdd
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
            tbx_Value = new Sunny.UI.UITextBox();
            tbx_Length = new Sunny.UI.UITextBox();
            tbx_Name = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            uiGroupBox1 = new Sunny.UI.UIGroupBox();
            uiRadioButton4 = new Sunny.UI.UIRadioButton();
            uiRadioButton3 = new Sunny.UI.UIRadioButton();
            uiRadioButton2 = new Sunny.UI.UIRadioButton();
            uiRadioButton1 = new Sunny.UI.UIRadioButton();
            uiGroupBox_Date = new Sunny.UI.UIGroupBox();
            uiRadioButton6 = new Sunny.UI.UIRadioButton();
            uiRadioButton5 = new Sunny.UI.UIRadioButton();
            uiGroupBox_Feature = new Sunny.UI.UIGroupBox();
            rb_Contain = new Sunny.UI.UIRadioButton();
            rb_suffix = new Sunny.UI.UIRadioButton();
            rb_Pre = new Sunny.UI.UIRadioButton();
            uiGroupBox1.SuspendLayout();
            uiGroupBox_Date.SuspendLayout();
            uiGroupBox_Feature.SuspendLayout();
            SuspendLayout();
            // 
            // tbx_Value
            // 
            tbx_Value.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbx_Value.Location = new Point(451, 198);
            tbx_Value.Margin = new Padding(4, 5, 4, 5);
            tbx_Value.MinimumSize = new Size(1, 16);
            tbx_Value.Name = "tbx_Value";
            tbx_Value.Padding = new Padding(5);
            tbx_Value.ShowText = false;
            tbx_Value.Size = new Size(244, 38);
            tbx_Value.TabIndex = 18;
            tbx_Value.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_Value.Watermark = "";
            // 
            // tbx_Length
            // 
            tbx_Length.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbx_Length.Location = new Point(451, 142);
            tbx_Length.Margin = new Padding(4, 5, 4, 5);
            tbx_Length.MinimumSize = new Size(1, 16);
            tbx_Length.Name = "tbx_Length";
            tbx_Length.Padding = new Padding(5);
            tbx_Length.ShowText = false;
            tbx_Length.Size = new Size(244, 38);
            tbx_Length.TabIndex = 17;
            tbx_Length.Text = "0";
            tbx_Length.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_Length.Type = Sunny.UI.UITextBox.UIEditType.Integer;
            tbx_Length.Watermark = "";
            // 
            // tbx_Name
            // 
            tbx_Name.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbx_Name.Location = new Point(451, 80);
            tbx_Name.Margin = new Padding(4, 5, 4, 5);
            tbx_Name.MinimumSize = new Size(1, 16);
            tbx_Name.Name = "tbx_Name";
            tbx_Name.Padding = new Padding(5);
            tbx_Name.ShowText = false;
            tbx_Name.Size = new Size(244, 38);
            tbx_Name.TabIndex = 16;
            tbx_Name.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_Name.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(317, 198);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(127, 38);
            uiLabel3.TabIndex = 14;
            uiLabel3.Text = "匹配值:";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(317, 142);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(127, 38);
            uiLabel2.TabIndex = 13;
            uiLabel2.Text = "参数长度:";
            // 
            // uiLabel1
            // 
            uiLabel1.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(317, 80);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(127, 38);
            uiLabel1.TabIndex = 12;
            uiLabel1.Text = "参数名称:";
            // 
            // uiButton2
            // 
            uiButton2.FillColor = Color.White;
            uiButton2.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.ForeColor = Color.Black;
            uiButton2.Location = new Point(394, 504);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.RectHoverColor = Color.Red;
            uiButton2.Size = new Size(107, 48);
            uiButton2.TabIndex = 11;
            uiButton2.Text = "取消";
            uiButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.Click += uiButton2_Click;
            // 
            // uiButton1
            // 
            uiButton1.FillColor = Color.White;
            uiButton1.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.ForeColor = Color.Black;
            uiButton1.Location = new Point(195, 504);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(107, 48);
            uiButton1.TabIndex = 10;
            uiButton1.Text = "添加";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Click += uiButton1_Click;
            // 
            // uiGroupBox1
            // 
            uiGroupBox1.Controls.Add(uiRadioButton4);
            uiGroupBox1.Controls.Add(uiRadioButton3);
            uiGroupBox1.Controls.Add(uiRadioButton2);
            uiGroupBox1.Controls.Add(uiRadioButton1);
            uiGroupBox1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox1.Location = new Point(34, 80);
            uiGroupBox1.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox1.MinimumSize = new Size(1, 1);
            uiGroupBox1.Name = "uiGroupBox1";
            uiGroupBox1.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox1.Size = new Size(270, 180);
            uiGroupBox1.TabIndex = 22;
            uiGroupBox1.Text = "参数类型";
            uiGroupBox1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // uiRadioButton4
            // 
            uiRadioButton4.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiRadioButton4.Location = new Point(23, 134);
            uiRadioButton4.MinimumSize = new Size(1, 1);
            uiRadioButton4.Name = "uiRadioButton4";
            uiRadioButton4.Size = new Size(118, 26);
            uiRadioButton4.TabIndex = 28;
            uiRadioButton4.Text = "固定值";
            // 
            // uiRadioButton3
            // 
            uiRadioButton3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiRadioButton3.Location = new Point(23, 102);
            uiRadioButton3.MinimumSize = new Size(1, 1);
            uiRadioButton3.Name = "uiRadioButton3";
            uiRadioButton3.Size = new Size(118, 26);
            uiRadioButton3.TabIndex = 27;
            uiRadioButton3.Text = "特征字符串";
            uiRadioButton3.CheckedChanged += uiRadioButton3_CheckedChanged;
            // 
            // uiRadioButton2
            // 
            uiRadioButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiRadioButton2.Location = new Point(23, 70);
            uiRadioButton2.MinimumSize = new Size(1, 1);
            uiRadioButton2.Name = "uiRadioButton2";
            uiRadioButton2.Size = new Size(107, 26);
            uiRadioButton2.TabIndex = 26;
            uiRadioButton2.Text = "流水号";
            uiRadioButton2.CheckedChanged += uiRadioButton2_CheckedChanged;
            // 
            // uiRadioButton1
            // 
            uiRadioButton1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiRadioButton1.Location = new Point(23, 35);
            uiRadioButton1.MinimumSize = new Size(1, 1);
            uiRadioButton1.Name = "uiRadioButton1";
            uiRadioButton1.Size = new Size(107, 29);
            uiRadioButton1.TabIndex = 25;
            uiRadioButton1.Text = "日期";
            uiRadioButton1.CheckedChanged += uiRadioButton1_CheckedChanged;
            // 
            // uiGroupBox_Date
            // 
            uiGroupBox_Date.Controls.Add(uiRadioButton6);
            uiGroupBox_Date.Controls.Add(uiRadioButton5);
            uiGroupBox_Date.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox_Date.Location = new Point(34, 284);
            uiGroupBox_Date.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox_Date.MinimumSize = new Size(1, 1);
            uiGroupBox_Date.Name = "uiGroupBox_Date";
            uiGroupBox_Date.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox_Date.Size = new Size(270, 142);
            uiGroupBox_Date.TabIndex = 23;
            uiGroupBox_Date.Text = "日期格式";
            uiGroupBox_Date.TextAlignment = ContentAlignment.MiddleLeft;
            uiGroupBox_Date.Visible = false;
            // 
            // uiRadioButton6
            // 
            uiRadioButton6.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiRadioButton6.Location = new Point(19, 88);
            uiRadioButton6.MinimumSize = new Size(1, 1);
            uiRadioButton6.Name = "uiRadioButton6";
            uiRadioButton6.Size = new Size(118, 26);
            uiRadioButton6.TabIndex = 30;
            uiRadioButton6.Text = "yyMMdd";
            uiRadioButton6.CheckedChanged += uiRadioButton6_CheckedChanged;
            // 
            // uiRadioButton5
            // 
            uiRadioButton5.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiRadioButton5.Location = new Point(19, 40);
            uiRadioButton5.MinimumSize = new Size(1, 1);
            uiRadioButton5.Name = "uiRadioButton5";
            uiRadioButton5.Size = new Size(118, 26);
            uiRadioButton5.TabIndex = 29;
            uiRadioButton5.Text = "yyyyMMdd";
            uiRadioButton5.CheckedChanged += uiRadioButton5_CheckedChanged;
            // 
            // uiGroupBox_Feature
            // 
            uiGroupBox_Feature.Controls.Add(rb_Contain);
            uiGroupBox_Feature.Controls.Add(rb_suffix);
            uiGroupBox_Feature.Controls.Add(rb_Pre);
            uiGroupBox_Feature.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiGroupBox_Feature.Location = new Point(364, 282);
            uiGroupBox_Feature.Margin = new Padding(4, 5, 4, 5);
            uiGroupBox_Feature.MinimumSize = new Size(1, 1);
            uiGroupBox_Feature.Name = "uiGroupBox_Feature";
            uiGroupBox_Feature.Padding = new Padding(0, 32, 0, 0);
            uiGroupBox_Feature.Size = new Size(270, 148);
            uiGroupBox_Feature.TabIndex = 24;
            uiGroupBox_Feature.Text = "特征格式";
            uiGroupBox_Feature.TextAlignment = ContentAlignment.MiddleLeft;
            uiGroupBox_Feature.Visible = false;
            // 
            // rb_Contain
            // 
            rb_Contain.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rb_Contain.Location = new Point(19, 106);
            rb_Contain.MinimumSize = new Size(1, 1);
            rb_Contain.Name = "rb_Contain";
            rb_Contain.Size = new Size(118, 26);
            rb_Contain.TabIndex = 32;
            rb_Contain.Text = "包含";
            // 
            // rb_suffix
            // 
            rb_suffix.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rb_suffix.Location = new Point(19, 74);
            rb_suffix.MinimumSize = new Size(1, 1);
            rb_suffix.Name = "rb_suffix";
            rb_suffix.Size = new Size(118, 26);
            rb_suffix.TabIndex = 31;
            rb_suffix.Text = "后缀";
            // 
            // rb_Pre
            // 
            rb_Pre.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            rb_Pre.Location = new Point(19, 42);
            rb_Pre.MinimumSize = new Size(1, 1);
            rb_Pre.Name = "rb_Pre";
            rb_Pre.Size = new Size(118, 26);
            rb_Pre.TabIndex = 30;
            rb_Pre.Text = "前缀";
            // 
            // FormRuleParamsAdd
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 612);
            Controls.Add(uiGroupBox_Feature);
            Controls.Add(uiGroupBox_Date);
            Controls.Add(uiGroupBox1);
            Controls.Add(tbx_Value);
            Controls.Add(tbx_Length);
            Controls.Add(tbx_Name);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel1);
            Controls.Add(uiButton2);
            Controls.Add(uiButton1);
            Name = "FormRuleParamsAdd";
            Text = "规则参数添加";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FormRuleParamsAdd_Load;
            uiGroupBox1.ResumeLayout(false);
            uiGroupBox_Date.ResumeLayout(false);
            uiGroupBox_Feature.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UITextBox tbx_Value;
        private Sunny.UI.UITextBox tbx_Length;
        private Sunny.UI.UITextBox tbx_Name;
        private Sunny.UI.UILabel uiLabel3;
        private Sunny.UI.UILabel uiLabel2;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIGroupBox uiGroupBox1;
        private Sunny.UI.UIGroupBox uiGroupBox_Date;
        private Sunny.UI.UIGroupBox uiGroupBox_Feature;
        private Sunny.UI.UIRadioButton uiRadioButton1;
        private Sunny.UI.UIRadioButton uiRadioButton2;
        private Sunny.UI.UIRadioButton uiRadioButton3;
        private Sunny.UI.UIRadioButton uiRadioButton4;
        private Sunny.UI.UIRadioButton uiRadioButton5;
        private Sunny.UI.UIRadioButton uiRadioButton6;
        private Sunny.UI.UIRadioButton rb_Pre;
        private Sunny.UI.UIRadioButton rb_Contain;
        private Sunny.UI.UIRadioButton rb_suffix;
    }
}