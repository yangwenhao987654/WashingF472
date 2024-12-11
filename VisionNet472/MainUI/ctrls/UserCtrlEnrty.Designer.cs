using System.Drawing;
using System.Windows.Forms;

namespace DIPTest.Ctrl
{
    partial class UserCtrlEntry
    {
        /// <summary> 
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.lbl_Input = new Sunny.UI.UILabel();
            this.SuspendLayout();
            // 
            // uiLabel4
            // 
            this.uiLabel4.BackColor = System.Drawing.Color.Gray;
            this.uiLabel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 50F);
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(0, 0);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(268, 119);
            this.uiLabel4.TabIndex = 2;
            this.uiLabel4.Text = "等待中";
            this.uiLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Input
            // 
            this.lbl_Input.BackColor = System.Drawing.Color.PaleTurquoise;
            this.lbl_Input.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_Input.Font = new System.Drawing.Font("宋体", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Input.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_Input.Location = new System.Drawing.Point(0, 0);
            this.lbl_Input.Name = "lbl_Input";
            this.lbl_Input.Size = new System.Drawing.Size(268, 25);
            this.lbl_Input.TabIndex = 3;
            this.lbl_Input.Text = "SN";
            this.lbl_Input.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // UserCtrlEntry
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.lbl_Input);
            this.Controls.Add(this.uiLabel4);
            this.Name = "UserCtrlEntry";
            this.Size = new System.Drawing.Size(268, 119);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel lbl_Input;
    }
}
