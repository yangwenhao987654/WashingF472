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
            uiLabel4 = new Sunny.UI.UILabel();
            lbl_Input = new Sunny.UI.UILabel();
            SuspendLayout();
            // 
            // uiLabel4
            // 
            uiLabel4.BackColor = Color.Gray;
            uiLabel4.Dock = DockStyle.Fill;
            uiLabel4.Font = new Font("微软雅黑", 50F);
            uiLabel4.ForeColor = Color.FromArgb(48, 48, 48);
            uiLabel4.Location = new Point(0, 0);
            uiLabel4.Margin = new Padding(4, 0, 4, 0);
            uiLabel4.Name = "uiLabel4";
            uiLabel4.Size = new Size(313, 168);
            uiLabel4.TabIndex = 2;
            uiLabel4.Text = "等待中";
            uiLabel4.TextAlign = ContentAlignment.MiddleCenter;
            uiLabel4.Click += uiLabel4_Click;
            // 
            // lbl_Input
            // 
            lbl_Input.BackColor = Color.PaleTurquoise;
            lbl_Input.Dock = DockStyle.Top;
            lbl_Input.Font = new Font("宋体", 20F, FontStyle.Regular, GraphicsUnit.Point, 134);
            lbl_Input.ForeColor = Color.FromArgb(48, 48, 48);
            lbl_Input.Location = new Point(0, 0);
            lbl_Input.Name = "lbl_Input";
            lbl_Input.Size = new Size(313, 36);
            lbl_Input.TabIndex = 3;
            lbl_Input.Text = "SN";
            lbl_Input.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // UserCtrlEntry
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lbl_Input);
            Controls.Add(uiLabel4);
            Margin = new Padding(4);
            Name = "UserCtrlEntry";
            Size = new Size(313, 168);
            Resize += UserCtrlResult_Resize;
            ResumeLayout(false);
        }

        #endregion
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel lbl_Input;
    }
}
