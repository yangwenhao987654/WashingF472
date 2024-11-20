namespace UI.Forms.RuleParameters
{
    partial class FormRuleParamsSetting
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRuleParamsSetting));
            tbx_Value = new Sunny.UI.UITextBox();
            tbx_Length = new Sunny.UI.UITextBox();
            tbx_Name = new Sunny.UI.UITextBox();
            uiLabel3 = new Sunny.UI.UILabel();
            uiLabel2 = new Sunny.UI.UILabel();
            uiLabel1 = new Sunny.UI.UILabel();
            uiButton2 = new Sunny.UI.UIButton();
            uiButton1 = new Sunny.UI.UIButton();
            uiCheckBoxGroup1 = new Sunny.UI.UICheckBoxGroup();
            cbx_fullMatch = new Sunny.UI.UICheckBox();
            cbx_feature = new Sunny.UI.UICheckBox();
            cbx_Serial = new Sunny.UI.UICheckBox();
            cbx_date = new Sunny.UI.UICheckBox();
            uiCheckBoxGroup_Time = new Sunny.UI.UICheckBoxGroup();
            cbx_Date_yyMMdd = new Sunny.UI.UICheckBox();
            cbx_date_yyyyMMdd = new Sunny.UI.UICheckBox();
            uiCheckBoxGroup_Feature = new Sunny.UI.UICheckBoxGroup();
            uiCheckBox_Contain = new Sunny.UI.UICheckBox();
            uiCheckBox_suffix = new Sunny.UI.UICheckBox();
            uiCheckBox_Pre = new Sunny.UI.UICheckBox();
            uiCheckBoxGroup1.SuspendLayout();
            uiCheckBoxGroup_Time.SuspendLayout();
            uiCheckBoxGroup_Feature.SuspendLayout();
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
            uiButton1.Text = "保存";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Click += uiButton1_Click;
            // 
            // uiCheckBoxGroup1
            // 
            uiCheckBoxGroup1.Controls.Add(cbx_fullMatch);
            uiCheckBoxGroup1.Controls.Add(cbx_feature);
            uiCheckBoxGroup1.Controls.Add(cbx_Serial);
            uiCheckBoxGroup1.Controls.Add(cbx_date);
            uiCheckBoxGroup1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiCheckBoxGroup1.HoverColor = Color.FromArgb(220, 236, 255);
            uiCheckBoxGroup1.Location = new Point(31, 57);
            uiCheckBoxGroup1.Margin = new Padding(4, 5, 4, 5);
            uiCheckBoxGroup1.MinimumSize = new Size(1, 1);
            uiCheckBoxGroup1.Name = "uiCheckBoxGroup1";
            uiCheckBoxGroup1.Padding = new Padding(0, 32, 0, 0);
            uiCheckBoxGroup1.SelectedIndexes = (List<int>)resources.GetObject("uiCheckBoxGroup1.SelectedIndexes");
            uiCheckBoxGroup1.Size = new Size(209, 186);
            uiCheckBoxGroup1.TabIndex = 19;
            uiCheckBoxGroup1.Text = "参数类型";
            uiCheckBoxGroup1.TextAlignment = ContentAlignment.MiddleLeft;
            // 
            // cbx_fullMatch
            // 
            cbx_fullMatch.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbx_fullMatch.ForeColor = Color.FromArgb(48, 48, 48);
            cbx_fullMatch.Location = new Point(23, 137);
            cbx_fullMatch.MinimumSize = new Size(1, 1);
            cbx_fullMatch.Name = "cbx_fullMatch";
            cbx_fullMatch.Size = new Size(150, 29);
            cbx_fullMatch.TabIndex = 3;
            cbx_fullMatch.Text = "固定值";
            // 
            // cbx_feature
            // 
            cbx_feature.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbx_feature.ForeColor = Color.FromArgb(48, 48, 48);
            cbx_feature.Location = new Point(23, 102);
            cbx_feature.MinimumSize = new Size(1, 1);
            cbx_feature.Name = "cbx_feature";
            cbx_feature.Size = new Size(150, 29);
            cbx_feature.TabIndex = 2;
            cbx_feature.Text = "特征字符串";
            cbx_feature.CheckedChanged += uiCheckBox3_CheckedChanged;
            // 
            // cbx_Serial
            // 
            cbx_Serial.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbx_Serial.ForeColor = Color.FromArgb(48, 48, 48);
            cbx_Serial.Location = new Point(23, 67);
            cbx_Serial.MinimumSize = new Size(1, 1);
            cbx_Serial.Name = "cbx_Serial";
            cbx_Serial.Size = new Size(150, 29);
            cbx_Serial.TabIndex = 1;
            cbx_Serial.Text = "流水号";
            cbx_Serial.CheckedChanged += uiCheckBox2_CheckedChanged;
            // 
            // cbx_date
            // 
            cbx_date.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbx_date.ForeColor = Color.FromArgb(48, 48, 48);
            cbx_date.Location = new Point(23, 32);
            cbx_date.MinimumSize = new Size(1, 1);
            cbx_date.Name = "cbx_date";
            cbx_date.Size = new Size(150, 29);
            cbx_date.TabIndex = 0;
            cbx_date.Text = "日期";
            cbx_date.CheckedChanged += uiCheckBox1_CheckedChanged;
            // 
            // uiCheckBoxGroup_Time
            // 
            uiCheckBoxGroup_Time.Controls.Add(cbx_Date_yyMMdd);
            uiCheckBoxGroup_Time.Controls.Add(cbx_date_yyyyMMdd);
            uiCheckBoxGroup_Time.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiCheckBoxGroup_Time.HoverColor = Color.FromArgb(220, 236, 255);
            uiCheckBoxGroup_Time.Location = new Point(34, 272);
            uiCheckBoxGroup_Time.Margin = new Padding(4, 5, 4, 5);
            uiCheckBoxGroup_Time.MinimumSize = new Size(1, 1);
            uiCheckBoxGroup_Time.Name = "uiCheckBoxGroup_Time";
            uiCheckBoxGroup_Time.Padding = new Padding(0, 32, 0, 0);
            uiCheckBoxGroup_Time.SelectedIndexes = (List<int>)resources.GetObject("uiCheckBoxGroup_Time.SelectedIndexes");
            uiCheckBoxGroup_Time.Size = new Size(268, 154);
            uiCheckBoxGroup_Time.TabIndex = 20;
            uiCheckBoxGroup_Time.Text = "日期格式";
            uiCheckBoxGroup_Time.TextAlignment = ContentAlignment.MiddleLeft;
            uiCheckBoxGroup_Time.Visible = false;
            // 
            // cbx_Date_yyMMdd
            // 
            cbx_Date_yyMMdd.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbx_Date_yyMMdd.ForeColor = Color.FromArgb(48, 48, 48);
            cbx_Date_yyMMdd.Location = new Point(23, 67);
            cbx_Date_yyMMdd.MinimumSize = new Size(1, 1);
            cbx_Date_yyMMdd.Name = "cbx_Date_yyMMdd";
            cbx_Date_yyMMdd.Size = new Size(150, 29);
            cbx_Date_yyMMdd.TabIndex = 1;
            cbx_Date_yyMMdd.Text = "yyMMdd";
            cbx_Date_yyMMdd.CheckedChanged += uiCheckBox7_CheckedChanged;
            // 
            // cbx_date_yyyyMMdd
            // 
            cbx_date_yyyyMMdd.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            cbx_date_yyyyMMdd.ForeColor = Color.FromArgb(48, 48, 48);
            cbx_date_yyyyMMdd.Location = new Point(23, 35);
            cbx_date_yyyyMMdd.MinimumSize = new Size(1, 1);
            cbx_date_yyyyMMdd.Name = "cbx_date_yyyyMMdd";
            cbx_date_yyyyMMdd.Size = new Size(150, 29);
            cbx_date_yyyyMMdd.TabIndex = 0;
            cbx_date_yyyyMMdd.Text = "yyyyMMdd";
            cbx_date_yyyyMMdd.CheckedChanged += uiCheckBox8_CheckedChanged;
            // 
            // uiCheckBoxGroup_Feature
            // 
            uiCheckBoxGroup_Feature.Controls.Add(uiCheckBox_Contain);
            uiCheckBoxGroup_Feature.Controls.Add(uiCheckBox_suffix);
            uiCheckBoxGroup_Feature.Controls.Add(uiCheckBox_Pre);
            uiCheckBoxGroup_Feature.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiCheckBoxGroup_Feature.HoverColor = Color.FromArgb(220, 236, 255);
            uiCheckBoxGroup_Feature.Location = new Point(328, 272);
            uiCheckBoxGroup_Feature.Margin = new Padding(4, 5, 4, 5);
            uiCheckBoxGroup_Feature.MinimumSize = new Size(1, 1);
            uiCheckBoxGroup_Feature.Name = "uiCheckBoxGroup_Feature";
            uiCheckBoxGroup_Feature.Padding = new Padding(0, 32, 0, 0);
            uiCheckBoxGroup_Feature.SelectedIndexes = (List<int>)resources.GetObject("uiCheckBoxGroup_Feature.SelectedIndexes");
            uiCheckBoxGroup_Feature.Size = new Size(268, 154);
            uiCheckBoxGroup_Feature.TabIndex = 21;
            uiCheckBoxGroup_Feature.Text = "特征格式";
            uiCheckBoxGroup_Feature.TextAlignment = ContentAlignment.MiddleLeft;
            uiCheckBoxGroup_Feature.Visible = false;
            // 
            // uiCheckBox_Contain
            // 
            uiCheckBox_Contain.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiCheckBox_Contain.ForeColor = Color.FromArgb(48, 48, 48);
            uiCheckBox_Contain.Location = new Point(24, 102);
            uiCheckBox_Contain.MinimumSize = new Size(1, 1);
            uiCheckBox_Contain.Name = "uiCheckBox_Contain";
            uiCheckBox_Contain.Size = new Size(150, 29);
            uiCheckBox_Contain.TabIndex = 2;
            uiCheckBox_Contain.Text = "包含";
            // 
            // uiCheckBox_suffix
            // 
            uiCheckBox_suffix.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiCheckBox_suffix.ForeColor = Color.FromArgb(48, 48, 48);
            uiCheckBox_suffix.Location = new Point(23, 67);
            uiCheckBox_suffix.MinimumSize = new Size(1, 1);
            uiCheckBox_suffix.Name = "uiCheckBox_suffix";
            uiCheckBox_suffix.Size = new Size(150, 29);
            uiCheckBox_suffix.TabIndex = 1;
            uiCheckBox_suffix.Text = "后缀";
            // 
            // uiCheckBox_Pre
            // 
            uiCheckBox_Pre.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiCheckBox_Pre.ForeColor = Color.FromArgb(48, 48, 48);
            uiCheckBox_Pre.Location = new Point(23, 35);
            uiCheckBox_Pre.MinimumSize = new Size(1, 1);
            uiCheckBox_Pre.Name = "uiCheckBox_Pre";
            uiCheckBox_Pre.Size = new Size(150, 29);
            uiCheckBox_Pre.TabIndex = 0;
            uiCheckBox_Pre.Text = "前缀";
            // 
            // FormRuleParamsSetting
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 612);
            Controls.Add(uiCheckBoxGroup_Feature);
            Controls.Add(uiCheckBoxGroup_Time);
            Controls.Add(uiCheckBoxGroup1);
            Controls.Add(tbx_Value);
            Controls.Add(tbx_Length);
            Controls.Add(tbx_Name);
            Controls.Add(uiLabel3);
            Controls.Add(uiLabel2);
            Controls.Add(uiLabel1);
            Controls.Add(uiButton2);
            Controls.Add(uiButton1);
            Name = "FormRuleParamsSetting";
            Text = "条码参数规则编辑";
            ZoomScaleRect = new Rectangle(15, 15, 800, 450);
            Load += FormRuleParamsAdd_Load;
            uiCheckBoxGroup1.ResumeLayout(false);
            uiCheckBoxGroup_Time.ResumeLayout(false);
            uiCheckBoxGroup_Feature.ResumeLayout(false);
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
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup1;
        private Sunny.UI.UICheckBox cbx_feature;
        private Sunny.UI.UICheckBox cbx_Serial;
        private Sunny.UI.UICheckBox cbx_date;
        private Sunny.UI.UICheckBox cbx_fullMatch;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup_Time;
        private Sunny.UI.UICheckBox cbx_Date_yyMMdd;
        private Sunny.UI.UICheckBox cbx_date_yyyyMMdd;
        private Sunny.UI.UICheckBoxGroup uiCheckBoxGroup_Feature;
        private Sunny.UI.UICheckBox uiCheckBox_suffix;
        private Sunny.UI.UICheckBox uiCheckBox_Pre;
        private Sunny.UI.UICheckBox uiCheckBox_Contain;
    }
}