using System.Drawing;
using System.Windows.Forms;

namespace DWZ_Scada.Pages
{
    partial class PageTabMenu_Debug
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
            tabPage2 = new TabPage();
            tabPage1 = new TabPage();
            uiTabControlMenu1 = new Sunny.UI.UITabControlMenu();
            uiTabControlMenu1.SuspendLayout();
            SuspendLayout();
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.White;
            tabPage2.Location = new Point(126, 0);
            tabPage2.Margin = new Padding(5);
            tabPage2.Name = "tabPage2";
            tabPage2.Size = new Size(674, 450);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "程序实时日志";
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.White;
            tabPage1.Location = new Point(126, 0);
            tabPage1.Name = "tabPage1";
            tabPage1.Size = new Size(674, 450);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "设备调试";
            // 
            // uiTabControlMenu1
            // 
            uiTabControlMenu1.Alignment = TabAlignment.Left;
            uiTabControlMenu1.Controls.Add(tabPage2);
            uiTabControlMenu1.Controls.Add(tabPage1);
            uiTabControlMenu1.Dock = DockStyle.Fill;
            uiTabControlMenu1.DrawMode = TabDrawMode.OwnerDrawFixed;
            uiTabControlMenu1.FillColor = Color.White;
            uiTabControlMenu1.Font = new Font("微软雅黑", 12F, FontStyle.Regular, GraphicsUnit.Point, 134);
            uiTabControlMenu1.ItemSize = new Size(125, 50);
            uiTabControlMenu1.Location = new Point(0, 0);
            uiTabControlMenu1.Margin = new Padding(0);
            uiTabControlMenu1.MenuStyle = Sunny.UI.UIMenuStyle.Custom;
            uiTabControlMenu1.Multiline = true;
            uiTabControlMenu1.Name = "uiTabControlMenu1";
            uiTabControlMenu1.Padding = new Point(0, 0);
            uiTabControlMenu1.SelectedIndex = 0;
            uiTabControlMenu1.Size = new Size(800, 450);
            uiTabControlMenu1.SizeMode = TabSizeMode.Fixed;
            uiTabControlMenu1.TabBackColor = Color.PowderBlue;
            uiTabControlMenu1.TabIndex = 0;
            uiTabControlMenu1.TabSelectedColor = Color.LightCyan;
            uiTabControlMenu1.TabSelectedForeColor = Color.Black;
            uiTabControlMenu1.TabSelectedHighColor = Color.LightSkyBlue;
            uiTabControlMenu1.TabUnSelectedForeColor = Color.Black;
            uiTabControlMenu1.TextAlignment = HorizontalAlignment.Left;
            // 
            // PageTabMenu_Debug
            // 
            AutoScaleMode = AutoScaleMode.None;
            ClientSize = new Size(800, 450);
            Controls.Add(uiTabControlMenu1);
            Name = "PageTabMenu_Debug";
            Text = "                                                                        ";
            Load += PageTabMenu_Load;
            uiTabControlMenu1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage1;
        private Sunny.UI.UITabControlMenu uiTabControlMenu1;
    }
}