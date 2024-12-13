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
            this.components = new System.ComponentModel.Container();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.ctrlOCV1 = new AutoTF.UserCtrls.ctrlOCV();
            this.myLogCtrl1 = new DWZ_Scada.ctrls.MyLogCtrl();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiPanel2.SuspendLayout();
            this.uiPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiLabel1
            // 
            this.uiLabel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(0, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(1280, 59);
            this.uiLabel1.TabIndex = 1;
            this.uiLabel1.Text = "称重检测系统";
            this.uiLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.uiLabel1.Click += new System.EventHandler(this.uiLabel1_Click);
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Location = new System.Drawing.Point(576, 72);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.Size = new System.Drawing.Size(110, 51);
            this.uiButton3.TabIndex = 43;
            this.uiButton3.Text = "测试扫码";
            this.uiButton3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.Click += new System.EventHandler(this.uiButton3_Click);
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.ctrlOCV1);
            this.uiPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(36, 131);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.Size = new System.Drawing.Size(432, 311);
            this.uiPanel2.TabIndex = 45;
            this.uiPanel2.Text = "uiPanel2";
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiPanel1
            // 
            this.uiPanel1.Controls.Add(this.myLogCtrl1);
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(10, 592);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.uiPanel1.MaximumSize = new System.Drawing.Size(2000, 300);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.Size = new System.Drawing.Size(1257, 152);
            this.uiPanel1.TabIndex = 39;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Location = new System.Drawing.Point(576, 144);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.Size = new System.Drawing.Size(110, 51);
            this.uiButton1.TabIndex = 46;
            this.uiButton1.Text = "测试称重";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.Click += new System.EventHandler(this.uiButton1_Click);
            // 
            // ctrlOCV1
            // 
            this.ctrlOCV1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ctrlOCV1.Location = new System.Drawing.Point(0, 0);
            this.ctrlOCV1.Margin = new System.Windows.Forms.Padding(0);
            this.ctrlOCV1.Name = "ctrlOCV1";
            this.ctrlOCV1.Size = new System.Drawing.Size(432, 311);
            this.ctrlOCV1.TabIndex = 44;
            // 
            // myLogCtrl1
            // 
            this.myLogCtrl1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.myLogCtrl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.myLogCtrl1.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.myLogCtrl1.FullRowSelect = true;
            this.myLogCtrl1.LabelWrap = false;
            this.myLogCtrl1.Location = new System.Drawing.Point(0, 0);
            this.myLogCtrl1.MultiSelect = false;
            this.myLogCtrl1.Name = "myLogCtrl1";
            this.myLogCtrl1.ShowGroups = false;
            this.myLogCtrl1.Size = new System.Drawing.Size(1257, 152);
            this.myLogCtrl1.TabIndex = 0;
            this.myLogCtrl1.UseCompatibleStateImageBehavior = false;
            this.myLogCtrl1.View = System.Windows.Forms.View.Details;
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Location = new System.Drawing.Point(585, 350);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.Size = new System.Drawing.Size(110, 51);
            this.uiButton2.TabIndex = 47;
            this.uiButton2.Text = "测试";
            this.uiButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.Click += new System.EventHandler(this.uiButton2_Click);
            // 
            // PageOP10
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1280, 750);
            this.Controls.Add(this.uiButton2);
            this.Controls.Add(this.uiButton1);
            this.Controls.Add(this.uiPanel2);
            this.Controls.Add(this.uiButton3);
            this.Controls.Add(this.uiPanel1);
            this.Controls.Add(this.uiLabel1);
            this.Font = new System.Drawing.Font("宋体", 8F);
            this.Name = "PageOP10";
            this.Text = "OP10";
            this.TitleFillColor = System.Drawing.Color.Transparent;
            this.Initialize += new System.EventHandler(this.PageOP10_Initialize);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PageOP10_FormClosing);
            this.Load += new System.EventHandler(this.Page_Load);
            this.uiPanel2.ResumeLayout(false);
            this.uiPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel1;
        private UIPanel uiPanel1;
        private UIButton uiButton3;
        private ctrls.MyLogCtrl myLogCtrl1;
        private AutoTF.UserCtrls.ctrlOCV ctrlOCV1;
        private UIPanel uiPanel2;
        private UIButton uiButton1;
        private UIButton uiButton2;
    }
}