using System.Drawing;
using System.Windows.Forms;
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
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.lbl_EntrySN = new Sunny.UI.UILabel();
            this.lbl_EntryResult = new Sunny.UI.UILabel();
            this.uiPanel3 = new Sunny.UI.UIPanel();
            this.lbl_NGCount = new Sunny.UI.UILabel();
            this.lbl_OKCount = new Sunny.UI.UILabel();
            this.uiLabel11 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.ctrlOCV1 = new AutoTF.UserCtrls.ctrlOCV();
            this.uiPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(0, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(1400, 59);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "称重检测系统";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_EntrySN
            // 
            this.lbl_EntrySN.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_EntrySN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_EntrySN.Location = new System.Drawing.Point(176, 287);
            this.lbl_EntrySN.Name = "lbl_EntrySN";
            this.lbl_EntrySN.Size = new System.Drawing.Size(220, 42);
            this.lbl_EntrySN.TabIndex = 11;
            // 
            // lbl_EntryResult
            // 
            this.lbl_EntryResult.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_EntryResult.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_EntryResult.Location = new System.Drawing.Point(176, 339);
            this.lbl_EntryResult.Name = "lbl_EntryResult";
            this.lbl_EntryResult.Size = new System.Drawing.Size(220, 42);
            this.lbl_EntryResult.TabIndex = 30;
            // 
            // uiPanel3
            // 
            this.uiPanel3.Controls.Add(this.lbl_NGCount);
            this.uiPanel3.Controls.Add(this.lbl_OKCount);
            this.uiPanel3.Controls.Add(this.uiLabel11);
            this.uiPanel3.Controls.Add(this.uiLabel10);
            this.uiPanel3.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel3.Location = new System.Drawing.Point(934, 83);
            this.uiPanel3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel3.Name = "uiPanel3";
            this.uiPanel3.Size = new System.Drawing.Size(361, 163);
            this.uiPanel3.TabIndex = 37;
            this.uiPanel3.Text = null;
            this.uiPanel3.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbl_NGCount
            // 
            this.lbl_NGCount.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_NGCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbl_NGCount.Location = new System.Drawing.Point(147, 85);
            this.lbl_NGCount.Name = "lbl_NGCount";
            this.lbl_NGCount.Size = new System.Drawing.Size(192, 72);
            this.lbl_NGCount.TabIndex = 3;
            this.lbl_NGCount.Text = "0";
            // 
            // lbl_OKCount
            // 
            this.lbl_OKCount.Font = new System.Drawing.Font("微软雅黑", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_OKCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.lbl_OKCount.Location = new System.Drawing.Point(147, 13);
            this.lbl_OKCount.Name = "lbl_OKCount";
            this.lbl_OKCount.Size = new System.Drawing.Size(192, 65);
            this.lbl_OKCount.TabIndex = 2;
            this.lbl_OKCount.Text = "0";
            // 
            // uiLabel11
            // 
            this.uiLabel11.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.uiLabel11.Location = new System.Drawing.Point(7, 93);
            this.uiLabel11.Name = "uiLabel11";
            this.uiLabel11.Size = new System.Drawing.Size(110, 54);
            this.uiLabel11.TabIndex = 1;
            this.uiLabel11.Text = "NG:";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.ForeColor = System.Drawing.Color.LimeGreen;
            this.uiLabel10.Location = new System.Drawing.Point(11, 18);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(100, 60);
            this.uiLabel10.TabIndex = 0;
            this.uiLabel10.Text = "OK:";
            // 
            // uiPanel1
            // 
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(27, 573);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MaximumSize = new System.Drawing.Size(2000, 300);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1340, 300);
            this.uiPanel1.TabIndex = 39;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(1216, 386);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(110, 51);
            this.uiButton3.TabIndex = 43;
            this.uiButton3.Text = "测试扫码";
            this.uiButton3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // ctrlOCV1
            // 
            this.ctrlOCV1.Location = new System.Drawing.Point(39, 69);
            this.ctrlOCV1.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlOCV1.Name = "ctrlOCV1";
            this.ctrlOCV1.Size = new System.Drawing.Size(440, 466);
            this.ctrlOCV1.TabIndex = 44;
            // 
            // PageOP10
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1400, 1000);
            this.Controls.Add(this.ctrlOCV1);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiPanel3);
            this.Controls.Add(this.lbl_EntryResult);
            this.Controls.Add(this.lbl_EntrySN);
            this.Controls.Add(this.uiLabel1);
            this.Font = new System.Drawing.Font("宋体", 8F);
            this.Name = "PageOP10";
            this.Text = "OP10";
            this.TitleFillColor = System.Drawing.Color.Transparent;
            this.uiPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel lbl_EntrySN;
        private UILabel lbl_EntryResult;
        private ctrls.MyLogCtrl myLogCtrl1;
        private DIPTest.Ctrl.UserCtrlEntry userCtrlEntry1;
        private UIPanel uiPanel3;
        private UIPanel uiPanel1;
        private UIButton uiButton3;
        private UILabel uiLabel11;
        private UILabel uiLabel10;
        private UILabel lbl_NGCount;
        private UILabel lbl_OKCount;
        private AutoTF.UserCtrls.ctrlOCV ctrlOCV1;
    }
}