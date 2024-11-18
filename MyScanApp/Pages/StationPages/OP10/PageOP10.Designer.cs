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
            myLogCtrl1 = new ctrls.MyLogCtrl();
            uiPanel1 = new UIPanel();
            userCtrlEntry1 = new DIPTest.Ctrl.UserCtrlEntry();
            uiPanel2 = new UIPanel();
            uiPanel3 = new UIPanel();
            uiPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // uiLabel1
            // 
            uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            uiLabel1.Font = new System.Drawing.Font("微软雅黑", 28F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiLabel1.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            uiLabel1.Location = new System.Drawing.Point(0, 0);
            uiLabel1.Name = "uiLabel1";
            uiLabel1.Size = new System.Drawing.Size(1223, 59);
            uiLabel1.TabIndex = 1;
            uiLabel1.Text = "扫码对比系统";
            uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            uiLabel1.Click += uiLabel1_Click;
            // 
            // lbl_EntrySN
            // 
            lbl_EntrySN.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lbl_EntrySN.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            lbl_EntrySN.Location = new System.Drawing.Point(176, 287);
            lbl_EntrySN.Name = "lbl_EntrySN";
            lbl_EntrySN.Size = new System.Drawing.Size(220, 42);
            lbl_EntrySN.TabIndex = 11;
            // 
            // lbl_EntryResult
            // 
            lbl_EntryResult.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            lbl_EntryResult.ForeColor = System.Drawing.Color.FromArgb(48, 48, 48);
            lbl_EntryResult.Location = new System.Drawing.Point(176, 339);
            lbl_EntryResult.Name = "lbl_EntryResult";
            lbl_EntryResult.Size = new System.Drawing.Size(220, 42);
            lbl_EntryResult.TabIndex = 30;
            // 
            // myLogCtrl1
            // 
            myLogCtrl1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            myLogCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            myLogCtrl1.Font = new System.Drawing.Font("微软雅黑", 12F);
            myLogCtrl1.FullRowSelect = true;
            myLogCtrl1.HideSelection = true;
            myLogCtrl1.LabelWrap = false;
            myLogCtrl1.Location = new System.Drawing.Point(0, 0);
            myLogCtrl1.MultiSelect = false;
            myLogCtrl1.Name = "myLogCtrl1";
            myLogCtrl1.Size = new System.Drawing.Size(1189, 536);
            myLogCtrl1.TabIndex = 33;
            myLogCtrl1.UseCompatibleStateImageBehavior = false;
            myLogCtrl1.View = System.Windows.Forms.View.Details;
            // 
            // uiPanel1
            // 
            uiPanel1.Controls.Add(myLogCtrl1);
            uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiPanel1.Location = new System.Drawing.Point(18, 450);
            uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel1.Name = "uiPanel1";
            uiPanel1.Size = new System.Drawing.Size(1189, 536);
            uiPanel1.TabIndex = 34;
            uiPanel1.Text = "uiPanel1";
            uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userCtrlEntry1
            // 
            userCtrlEntry1.Location = new System.Drawing.Point(403, 246);
            userCtrlEntry1.Margin = new System.Windows.Forms.Padding(4);
            userCtrlEntry1.Name = "userCtrlEntry1";
            userCtrlEntry1.Size = new System.Drawing.Size(310, 174);
            userCtrlEntry1.TabIndex = 35;
            userCtrlEntry1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            userCtrlEntry1.TextFont = new System.Drawing.Font("微软雅黑", 50F);
            // 
            // uiPanel2
            // 
            uiPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiPanel2.Location = new System.Drawing.Point(13, 64);
            uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel2.Name = "uiPanel2";
            uiPanel2.Size = new System.Drawing.Size(1194, 141);
            uiPanel2.TabIndex = 36;
            uiPanel2.Text = "产品配方";
            uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel3
            // 
            uiPanel3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, 134);
            uiPanel3.Location = new System.Drawing.Point(35, 246);
            uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            uiPanel3.Name = "uiPanel3";
            uiPanel3.Size = new System.Drawing.Size(270, 180);
            uiPanel3.TabIndex = 37;
            uiPanel3.Text = "良率统计";
            uiPanel3.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PageOP10
            // 
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            ClientSize = new System.Drawing.Size(1223, 1000);
            Controls.Add(uiPanel3);
            Controls.Add(uiPanel2);
            Controls.Add(userCtrlEntry1);
            Controls.Add(uiPanel1);
            Controls.Add(lbl_EntryResult);
            Controls.Add(lbl_EntrySN);
            Controls.Add(uiLabel1);
            Font = new System.Drawing.Font("宋体", 8F);
            Name = "PageOP10";
            Text = "OP10";
            TitleFillColor = System.Drawing.Color.Transparent;
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
        private UIPanel uiPanel1;
        private DIPTest.Ctrl.UserCtrlEntry userCtrlEntry1;
        private UIPanel uiPanel2;
        private UIPanel uiPanel3;
    }
}