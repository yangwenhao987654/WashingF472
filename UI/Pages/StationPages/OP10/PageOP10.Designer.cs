using Sunny.UI;

namespace DWZ_Scada.Pages.StationPages.OP10
{
    partial class PageOP10
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
            //this.PageOP10_FormClosing(this,null);
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            uiLabel1 = new UILabel();
            lbl_EntrySN = new UILabel();
            lbl_EntryResult = new UILabel();
            uiPanel2 = new UIPanel();
            tbx_FixValue1 = new UITextBox();
            uiLabel9 = new UILabel();
            tbx_CodeType = new UITextBox();
            uiLabel5 = new UILabel();
            tbx_DateFormat = new UITextBox();
            uiLabel8 = new UILabel();
            uiLabel7 = new UILabel();
            uiDatePicker1 = new UIDatePicker();
            tbx_Part = new UITextBox();
            uiLabel6 = new UILabel();
            tbx_Spy = new UITextBox();
            uiLabel4 = new UILabel();
            tbx_Code = new UITextBox();
            uiLabel3 = new UILabel();
            uiLabel2 = new UILabel();
            uiComboBox1 = new UIComboBox();
            uiPanel3 = new UIPanel();
            lbl_NGCount = new UILabel();
            lbl_OKCount = new UILabel();
            uiLabel11 = new UILabel();
            uiLabel10 = new UILabel();
            uiPanel1 = new UIPanel();
            myLogCtrl1 = new ctrls.MyLogCtrl();
            uiButton1 = new UIButton();
            tbx_Input = new UITextBox();
            uiButton3 = new UIButton();
            userCtrlEntry1 = new DIPTest.Ctrl.UserCtrlEntry();
            uiPanel2.SuspendLayout();
            uiPanel3.SuspendLayout();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Dock = DockStyle.Top;
            uiLabel1.Font = new Font("微软雅黑", 28F, FontStyle.Bold, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(0, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(1400, 59);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "扫码对比系统";
            uiLabel1.TextAlign = ContentAlignment.MiddleCenter;
            uiLabel1.Click += uiLabel1_Click;
            // 
            // lbl_EntrySN
            // 
            lbl_EntrySN.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_EntrySN.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_EntrySN.Location = new Point(176, 287);
            lbl_EntrySN.Name = "lbl_EntrySN";
            lbl_EntrySN.Size = new Size(220, 42);
            lbl_EntrySN.TabIndex = 11;
            // 
            // lbl_EntryResult
            // 
            lbl_EntryResult.Font = new Font("微软雅黑", 18F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_EntryResult.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_EntryResult.Location = new Point(176, 339);
            lbl_EntryResult.Name = "lbl_EntryResult";
            lbl_EntryResult.Size = new Size(220, 42);
            lbl_EntryResult.TabIndex = 30;
            // 
            // uiPanel2
            // 
            uiPanel2.Controls.Add(tbx_FixValue1);
            uiPanel2.Controls.Add(uiLabel9);
            uiPanel2.Controls.Add(tbx_CodeType);
            uiPanel2.Controls.Add(uiLabel5);
            uiPanel2.Controls.Add(tbx_DateFormat);
            uiPanel2.Controls.Add(uiLabel8);
            uiPanel2.Controls.Add(uiLabel7);
            uiPanel2.Controls.Add(uiDatePicker1);
            uiPanel2.Controls.Add(tbx_Part);
            uiPanel2.Controls.Add(uiLabel6);
            uiPanel2.Controls.Add(tbx_Spy);
            uiPanel2.Controls.Add(uiLabel4);
            uiPanel2.Controls.Add(tbx_Code);
            uiPanel2.Controls.Add(uiLabel3);
            uiPanel2.Controls.Add(uiLabel2);
            uiPanel2.Controls.Add(uiComboBox1);
            uiPanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel2.Location = new Point(13, 53);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(1362, 152);
            uiPanel2.TabIndex = 36;
            uiPanel2.Text = null;
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            uiPanel2.Click += uiPanel2_Click;
            // 
            // tbx_FixValue1
            // 
            tbx_FixValue1.Enabled = false;
            tbx_FixValue1.Font = new Font("微软雅黑", 18F);
            tbx_FixValue1.Location = new Point(583, 101);
            tbx_FixValue1.Margin = new Padding(4, 5, 4, 5);
            tbx_FixValue1.MinimumSize = new Size(1, 16);
            tbx_FixValue1.Name = "tbx_FixValue1";
            tbx_FixValue1.Padding = new Padding(5);
            tbx_FixValue1.ShowText = false;
            tbx_FixValue1.Size = new Size(211, 40);
            tbx_FixValue1.TabIndex = 17;
            tbx_FixValue1.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_FixValue1.Watermark = "";
            // 
            // uiLabel9
            // 
            uiLabel9.Font = new Font("微软雅黑", 18F);
            uiLabel9.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel9.Location = new Point(462, 100);
            uiLabel9.Name = "uiLabel9";
            uiLabel9.Size = new Size(98, 33);
            uiLabel9.TabIndex = 16;
            uiLabel9.Text = "固定位:";
            uiLabel9.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbx_CodeType
            // 
            tbx_CodeType.Enabled = false;
            tbx_CodeType.Font = new Font("微软雅黑", 18F);
            tbx_CodeType.Location = new Point(150, 107);
            tbx_CodeType.Margin = new Padding(4, 5, 4, 5);
            tbx_CodeType.MinimumSize = new Size(1, 16);
            tbx_CodeType.Name = "tbx_CodeType";
            tbx_CodeType.Padding = new Padding(5);
            tbx_CodeType.ShowText = false;
            tbx_CodeType.Size = new Size(197, 40);
            tbx_CodeType.TabIndex = 15;
            tbx_CodeType.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_CodeType.Watermark = "";
            // 
            // uiLabel5
            // 
            uiLabel5.Font = new Font("微软雅黑", 18F);
            uiLabel5.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel5.Location = new Point(22, 112);
            uiLabel5.Name = "uiLabel5";
            uiLabel5.Size = new Size(123, 29);
            uiLabel5.TabIndex = 14;
            uiLabel5.Text = "条码类型:";
            // 
            // tbx_DateFormat
            // 
            tbx_DateFormat.Enabled = false;
            tbx_DateFormat.Font = new Font("微软雅黑", 18F);
            tbx_DateFormat.Location = new Point(977, 74);
            tbx_DateFormat.Margin = new Padding(4, 5, 4, 5);
            tbx_DateFormat.MinimumSize = new Size(1, 16);
            tbx_DateFormat.Name = "tbx_DateFormat";
            tbx_DateFormat.Padding = new Padding(5);
            tbx_DateFormat.ShowText = false;
            tbx_DateFormat.Size = new Size(198, 38);
            tbx_DateFormat.TabIndex = 13;
            tbx_DateFormat.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_DateFormat.Watermark = "";
            // 
            // uiLabel8
            // 
            uiLabel8.Font = new Font("微软雅黑", 18F);
            uiLabel8.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel8.Location = new Point(812, 70);
            uiLabel8.Name = "uiLabel8";
            uiLabel8.Size = new Size(135, 33);
            uiLabel8.TabIndex = 12;
            uiLabel8.Text = "日期格式:";
            uiLabel8.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiLabel7
            // 
            uiLabel7.Font = new Font("微软雅黑", 18F);
            uiLabel7.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel7.Location = new Point(825, 16);
            uiLabel7.Name = "uiLabel7";
            uiLabel7.Size = new Size(102, 33);
            uiLabel7.TabIndex = 11;
            uiLabel7.Text = "日  期:";
            uiLabel7.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // uiDatePicker1
            // 
            uiDatePicker1.FillColor = Color.White;
            uiDatePicker1.Font = new Font("微软雅黑", 18F);
            uiDatePicker1.Location = new Point(977, 16);
            uiDatePicker1.Margin = new Padding(4, 5, 4, 5);
            uiDatePicker1.MaxLength = 10;
            uiDatePicker1.MinimumSize = new Size(63, 0);
            uiDatePicker1.Name = "uiDatePicker1";
            uiDatePicker1.Padding = new Padding(0, 0, 30, 2);
            uiDatePicker1.Size = new Size(198, 38);
            uiDatePicker1.SymbolDropDown = 61555;
            uiDatePicker1.SymbolNormal = 61555;
            uiDatePicker1.SymbolSize = 24;
            uiDatePicker1.TabIndex = 10;
            uiDatePicker1.Text = "2024-11-20";
            uiDatePicker1.TextAlignment = ContentAlignment.MiddleLeft;
            uiDatePicker1.Value = new DateTime(2024, 11, 20, 13, 20, 11, 817);
            uiDatePicker1.Watermark = "";
            // 
            // tbx_Part
            // 
            tbx_Part.Enabled = false;
            tbx_Part.Font = new Font("微软雅黑", 18F);
            tbx_Part.Location = new Point(583, 50);
            tbx_Part.Margin = new Padding(4, 5, 4, 5);
            tbx_Part.MinimumSize = new Size(1, 16);
            tbx_Part.Name = "tbx_Part";
            tbx_Part.Padding = new Padding(5);
            tbx_Part.ShowText = false;
            tbx_Part.Size = new Size(211, 40);
            tbx_Part.TabIndex = 9;
            tbx_Part.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_Part.Watermark = "";
            // 
            // uiLabel6
            // 
            uiLabel6.Font = new Font("微软雅黑", 18F);
            uiLabel6.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel6.Location = new Point(462, 56);
            uiLabel6.Name = "uiLabel6";
            uiLabel6.Size = new Size(98, 33);
            uiLabel6.TabIndex = 7;
            uiLabel6.Text = "零件号:";
            uiLabel6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbx_Spy
            // 
            tbx_Spy.Enabled = false;
            tbx_Spy.Font = new Font("微软雅黑", 18F);
            tbx_Spy.Location = new Point(583, 3);
            tbx_Spy.Margin = new Padding(4, 5, 4, 5);
            tbx_Spy.MinimumSize = new Size(1, 16);
            tbx_Spy.Name = "tbx_Spy";
            tbx_Spy.Padding = new Padding(5);
            tbx_Spy.ShowText = false;
            tbx_Spy.Size = new Size(211, 40);
            tbx_Spy.TabIndex = 5;
            tbx_Spy.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_Spy.Watermark = "";
            // 
            // uiLabel4
            // 
            uiLabel4.Font = new Font("微软雅黑", 18F);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(417, 6);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(159, 33);
            uiLabel4.TabIndex = 4;
            uiLabel4.Text = "供应商代码:";
            uiLabel4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbx_Code
            // 
            tbx_Code.Enabled = false;
            tbx_Code.Font = new Font("微软雅黑", 18F);
            tbx_Code.Location = new Point(150, 60);
            tbx_Code.Margin = new Padding(0);
            tbx_Code.MinimumSize = new Size(1, 16);
            tbx_Code.Name = "tbx_Code";
            tbx_Code.Padding = new Padding(5);
            tbx_Code.ShowText = false;
            tbx_Code.Size = new Size(197, 40);
            tbx_Code.TabIndex = 3;
            tbx_Code.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_Code.Watermark = "";
            // 
            // uiLabel3
            // 
            uiLabel3.Font = new Font("微软雅黑", 18F);
            uiLabel3.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel3.Location = new Point(22, 60);
            uiLabel3.Name = "uiLabel3";
            uiLabel3.Size = new Size(140, 36);
            uiLabel3.TabIndex = 2;
            uiLabel3.Text = "产品编号:";
            // 
            // uiLabel2
            // 
            uiLabel2.Font = new Font("微软雅黑", 18F);
            uiLabel2.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel2.Location = new Point(22, 9);
            uiLabel2.Name = "uiLabel2";
            uiLabel2.Size = new Size(121, 30);
            uiLabel2.TabIndex = 1;
            uiLabel2.Text = "产品名称:";
            // 
            // uiComboBox1
            // 
            uiComboBox1.DataSource = null;
            uiComboBox1.DropDownStyle = UIDropDownStyle.DropDownList;
            uiComboBox1.FillColor = Color.White;
            uiComboBox1.Font = new Font("微软雅黑", 18F, FontStyle.Bold);
            uiComboBox1.ItemHeight = 35;
            uiComboBox1.ItemHoverColor = Color.FromArgb(155, 200, 255);
            uiComboBox1.ItemSelectForeColor = Color.FromArgb(235, 243, 255);
            uiComboBox1.Location = new Point(150, 8);
            uiComboBox1.Margin = new Padding(0);
            uiComboBox1.MinimumSize = new Size(63, 0);
            uiComboBox1.Name = "uiComboBox1";
            uiComboBox1.Padding = new Padding(0, 0, 30, 2);
            uiComboBox1.Size = new Size(197, 40);
            uiComboBox1.SymbolSize = 24;
            uiComboBox1.TabIndex = 0;
            uiComboBox1.TextAlignment = ContentAlignment.MiddleLeft;
            uiComboBox1.Watermark = "";
            uiComboBox1.SelectedIndexChanged += uiComboBox1_SelectedIndexChanged;
            // 
            // uiPanel3
            // 
            uiPanel3.Controls.Add(lbl_NGCount);
            uiPanel3.Controls.Add(lbl_OKCount);
            uiPanel3.Controls.Add(uiLabel11);
            uiPanel3.Controls.Add(uiLabel10);
            uiPanel3.Font = new Font("宋体", 20F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel3.Location = new Point(16, 224);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Size = new Size(361, 163);
            uiPanel3.TabIndex = 37;
            uiPanel3.Text = null;
            uiPanel3.TextAlignment = ContentAlignment.TopCenter;
            // 
            // lbl_NGCount
            // 
            lbl_NGCount.Font = new Font("微软雅黑", 40F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_NGCount.ForeColor = Color.FromArgb(255, 128, 128);
            lbl_NGCount.Location = new Point(147, 85);
            lbl_NGCount.Name = "lbl_NGCount";
            lbl_NGCount.Size = new Size(192, 72);
            lbl_NGCount.TabIndex = 3;
            lbl_NGCount.Text = "0";
            // 
            // lbl_OKCount
            // 
            lbl_OKCount.Font = new Font("微软雅黑", 40F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_OKCount.ForeColor = Color.LimeGreen;
            lbl_OKCount.Location = new Point(147, 13);
            lbl_OKCount.Name = "lbl_OKCount";
            lbl_OKCount.Size = new Size(192, 65);
            lbl_OKCount.TabIndex = 2;
            lbl_OKCount.Text = "0";
            // 
            // uiLabel11
            // 
            uiLabel11.Font = new Font("微软雅黑", 30F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel11.ForeColor = Color.FromArgb(255, 128, 128);
            uiLabel11.Location = new Point(7, 93);
            uiLabel11.Name = "uiLabel11";
            uiLabel11.Size = new Size(110, 54);
            uiLabel11.TabIndex = 1;
            uiLabel11.Text = "NG:";
            // 
            // uiLabel10
            // 
            uiLabel10.Font = new Font("微软雅黑", 30F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel10.ForeColor = Color.LimeGreen;
            uiLabel10.Location = new Point(11, 18);
            uiLabel10.Name = "uiLabel10";
            uiLabel10.Size = new Size(100, 60);
            uiLabel10.TabIndex = 0;
            uiLabel10.Text = "OK:";
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(myLogCtrl1);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(35, 397);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MaximumSize = new Size(2000, 300);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1340, 300);
            uiPanel1.TabIndex = 39;
            uiPanel1.Text = null;
            uiPanel1.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // myLogCtrl1
            // 
            myLogCtrl1.Alignment = ListViewAlignment.Default;
            myLogCtrl1.Dock = DockStyle.Fill;
            myLogCtrl1.Font = new Font("微软雅黑", 12F);
            myLogCtrl1.FullRowSelect = true;
            myLogCtrl1.HideSelection = true;
            myLogCtrl1.LabelWrap = false;
            myLogCtrl1.Location = new Point(0, 0);
            myLogCtrl1.Margin = new Padding(3, 3, 3, 20);
            myLogCtrl1.MultiSelect = false;
            myLogCtrl1.Name = "myLogCtrl1";
            myLogCtrl1.ShowGroups = false;
            myLogCtrl1.Size = new Size(1340, 300);
            myLogCtrl1.TabIndex = 0;
            myLogCtrl1.UseCompatibleStateImageBehavior = false;
            myLogCtrl1.View = View.Details;
            // 
            // uiButton1
            // 
            uiButton1.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Location = new Point(1035, 287);
            uiButton1.MinimumSize = new Size(1, 1);
            uiButton1.Name = "uiButton1";
            uiButton1.Size = new Size(109, 51);
            uiButton1.TabIndex = 41;
            uiButton1.Text = "条码校验";
            uiButton1.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton1.Click += uiButton1_Click_1;
            // 
            // tbx_Input
            // 
            tbx_Input.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            tbx_Input.Location = new Point(1015, 224);
            tbx_Input.Margin = new Padding(4, 5, 4, 5);
            tbx_Input.MinimumSize = new Size(1, 16);
            tbx_Input.Name = "tbx_Input";
            tbx_Input.Padding = new Padding(5);
            tbx_Input.ShowText = false;
            tbx_Input.Size = new Size(372, 55);
            tbx_Input.TabIndex = 42;
            tbx_Input.TextAlignment = ContentAlignment.MiddleLeft;
            tbx_Input.Watermark = "";
            // 
            // uiButton3
            // 
            uiButton3.Font = new Font("微软雅黑", 15F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.Location = new Point(1189, 287);
            uiButton3.MinimumSize = new Size(1, 1);
            uiButton3.Name = "uiButton3";
            uiButton3.Size = new Size(110, 51);
            uiButton3.TabIndex = 43;
            uiButton3.Text = "测试扫码";
            uiButton3.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton3.Click += uiButton3_Click;
            // 
            // userCtrlEntry1
            // 
            userCtrlEntry1.Location = new Point(385, 214);
            userCtrlEntry1.Margin = new Padding(4);
            userCtrlEntry1.Name = "userCtrlEntry1";
            userCtrlEntry1.Size = new Size(609, 173);
            userCtrlEntry1.TabIndex = 44;
            userCtrlEntry1.TextAlign = ContentAlignment.MiddleCenter;
            userCtrlEntry1.TextFont = new Font("微软雅黑", 50F);
            // 
            // PageOP10
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1400, 1000);
            Controls.Add(userCtrlEntry1);
            Controls.Add(uiButton3);
            Controls.Add(tbx_Input);
            Controls.Add(uiButton1);
            Controls.Add(uiPanel1);
            Controls.Add(uiPanel3);
            Controls.Add(uiPanel2);
            Controls.Add(lbl_EntryResult);
            Controls.Add(lbl_EntrySN);
            Controls.Add(uiLabel1);
            Font = new Font("宋体", 8F);
            Name = "PageOP10";
            Text = "OP10";
            TitleFillColor = Color.Transparent;
            FormClosing += PageOP10_FormClosing;
            Load += Page_Load;
            uiPanel2.ResumeLayout(false);
            uiPanel3.ResumeLayout(false);
            uiPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lbl_EntrySN;
        private UILabel lbl_EntryResult;
        private ctrls.MyLogCtrl myLogCtrl1;
        private DIPTest.Ctrl.UserCtrlEntry userCtrlEntry1;
        private UIPanel uiPanel2;
        private UIPanel uiPanel3;
        private UIPanel uiPanel1;
        private UIComboBox uiComboBox1;
        private UILabel uiLabel3;
        private UITextBox tbx_Code;
        private UILabel uiLabel4;
        private UITextBox tbx_Spy;
        private UILabel uiLabel6;
        private UITextBox tbx_Part;
        private UILabel uiLabel7;
        private UIDatePicker uiDatePicker1;
        private UITextBox tbx_DateFormat;
        private UILabel uiLabel8;
        private UILabel uiLabel2;
        private UITextBox tbx_CodeType;
        private UILabel uiLabel5;
        private UILabel uiLabel9;
        private UITextBox tbx_FixValue1;
        private UIButton uiButton1;
        private UITextBox tbx_Input;
        private UIButton uiButton3;
        private UILabel uiLabel11;
        private UILabel uiLabel10;
        private UILabel lbl_NGCount;
        private UILabel lbl_OKCount;
    }
}