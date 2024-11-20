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
            uiPanel3 = new UIPanel();
            uiPanel1 = new UIPanel();
            myLogCtrl1 = new ctrls.MyLogCtrl();
            uiButton2 = new UIButton();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Dock = DockStyle.Top;
            uiLabel1.Font = new Font("微软雅黑", 28F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new Point(0, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new Size(1223, 59);
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
            uiPanel2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel2.Location = new Point(13, 64);
            uiPanel2.Margin = new Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new Size(1194, 141);
            uiPanel2.TabIndex = 36;
            uiPanel2.Text = "产品配方";
            uiPanel2.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            uiPanel3.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel3.Location = new Point(35, 246);
            uiPanel3.Margin = new Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Size = new Size(270, 180);
            uiPanel3.TabIndex = 37;
            uiPanel3.Text = "良率统计";
            uiPanel3.TextAlignment = ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(myLogCtrl1);
            uiPanel1.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiPanel1.Location = new Point(35, 450);
            uiPanel1.Margin = new Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new Size(1172, 522);
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
            myLogCtrl1.Name = "myLogCtrl1";
            myLogCtrl1.Size = new Size(1172, 522);
            myLogCtrl1.TabIndex = 0;
            myLogCtrl1.UseCompatibleStateImageBehavior = false;
            myLogCtrl1.View = View.Details;
            // 
            // uiButton2
            // 
            uiButton2.Font = new Font("宋体", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.Location = new Point(573, 349);
            uiButton2.MinimumSize = new Size(1, 1);
            uiButton2.Name = "uiButton2";
            uiButton2.Size = new Size(151, 56);
            uiButton2.TabIndex = 40;
            uiButton2.Text = "查询条码规则";
            uiButton2.TipsFont = new Font("宋体", 9F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiButton2.Click += uiButton2_Click;
            // 
            // PageOP10
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(1223, 1000);
            Controls.Add(uiButton2);
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
        private UIButton uiButton2;
    }
}