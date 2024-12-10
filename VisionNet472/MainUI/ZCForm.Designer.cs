using System.Drawing;
using System.Resources;
using System.Windows.Forms;

namespace DWZ_Scada.Pages
{
    partial class ZCForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ZCForm));
            this.uiTableLayoutPanel1 = new Sunny.UI.UITableLayoutPanel();
            this.uiPanel2 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel3 = new Sunny.UI.UITableLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.uiLight1 = new Sunny.UI.UILight();
            this.lbl_PLCConn = new Sunny.UI.UILabel();
            this.uiLabel17 = new Sunny.UI.UILabel();
            this.lbl_PLCState = new Sunny.UI.UILabel();
            this.uiLabel8 = new Sunny.UI.UILabel();
            this.uiLabel9 = new Sunny.UI.UILabel();
            this.uiLabel10 = new Sunny.UI.UILabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblLoginUserName = new Sunny.UI.UILabel();
            this.lblLoginTime = new Sunny.UI.UILabel();
            this.lblTime = new Sunny.UI.UILabel();
            this.uiLabel5 = new Sunny.UI.UILabel();
            this.uiLabel6 = new Sunny.UI.UILabel();
            this.uiLabel7 = new Sunny.UI.UILabel();
            this.uiTableLayoutPanel4 = new Sunny.UI.UITableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lbl_CompanyName = new Sunny.UI.UILabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Version = new Sunny.UI.UILabel();
            this.lbl_DeviceName = new Sunny.UI.UILabel();
            this.lbl_DeviceCompany = new Sunny.UI.UILabel();
            this.uiLabel4 = new Sunny.UI.UILabel();
            this.uiLabel3 = new Sunny.UI.UILabel();
            this.uiLabel1 = new Sunny.UI.UILabel();
            this.uiTableLayoutPanel2 = new Sunny.UI.UITableLayoutPanel();
            this.uiButton8 = new Sunny.UI.UIButton();
            this.uiButton6 = new Sunny.UI.UIButton();
            this.uiButton4 = new Sunny.UI.UIButton();
            this.uiButton1 = new Sunny.UI.UIButton();
            this.uiButton2 = new Sunny.UI.UIButton();
            this.uiButton3 = new Sunny.UI.UIButton();
            this.uiPanel1 = new Sunny.UI.UIPanel();
            this.uiTableLayoutPanel1.SuspendLayout();
            this.uiPanel2.SuspendLayout();
            this.uiTableLayoutPanel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.uiTableLayoutPanel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.uiTableLayoutPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // uiTableLayoutPanel1
            // 
            this.uiTableLayoutPanel1.ColumnCount = 1;
            this.uiTableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel1.Controls.Add(this.uiPanel2, 0, 0);
            this.uiTableLayoutPanel1.Controls.Add(this.uiTableLayoutPanel2, 0, 2);
            this.uiTableLayoutPanel1.Controls.Add(this.uiPanel1, 0, 1);
            this.uiTableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel1.Location = new System.Drawing.Point(0, 35);
            this.uiTableLayoutPanel1.Name = "uiTableLayoutPanel1";
            this.uiTableLayoutPanel1.RowCount = 3;
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82F));
            this.uiTableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5F));
            this.uiTableLayoutPanel1.Size = new System.Drawing.Size(1400, 825);
            this.uiTableLayoutPanel1.TabIndex = 0;
            this.uiTableLayoutPanel1.TagString = null;
            // 
            // uiPanel2
            // 
            this.uiPanel2.Controls.Add(this.uiTableLayoutPanel3);
            this.uiPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel2.FillColor = System.Drawing.Color.White;
            this.uiPanel2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel2.Location = new System.Drawing.Point(0, 0);
            this.uiPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel2.Name = "uiPanel2";
            this.uiPanel2.RectColor = System.Drawing.Color.Black;
            this.uiPanel2.Size = new System.Drawing.Size(1400, 107);
            this.uiPanel2.TabIndex = 3;
            this.uiPanel2.Text = null;
            this.uiPanel2.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // uiTableLayoutPanel3
            // 
            this.uiTableLayoutPanel3.BackColor = System.Drawing.Color.White;
            this.uiTableLayoutPanel3.ColumnCount = 4;
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.3908F));
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 18.3908F));
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.48276F));
            this.uiTableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.73563F));
            this.uiTableLayoutPanel3.Controls.Add(this.panel4, 3, 0);
            this.uiTableLayoutPanel3.Controls.Add(this.panel3, 2, 0);
            this.uiTableLayoutPanel3.Controls.Add(this.uiTableLayoutPanel4, 0, 0);
            this.uiTableLayoutPanel3.Controls.Add(this.panel1, 1, 0);
            this.uiTableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel3.Location = new System.Drawing.Point(0, 0);
            this.uiTableLayoutPanel3.Margin = new System.Windows.Forms.Padding(0);
            this.uiTableLayoutPanel3.MinimumSize = new System.Drawing.Size(0, 115);
            this.uiTableLayoutPanel3.Name = "uiTableLayoutPanel3";
            this.uiTableLayoutPanel3.RowCount = 1;
            this.uiTableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel3.Size = new System.Drawing.Size(1400, 115);
            this.uiTableLayoutPanel3.TabIndex = 1;
            this.uiTableLayoutPanel3.TagString = null;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Transparent;
            this.panel4.Controls.Add(this.uiLight1);
            this.panel4.Controls.Add(this.lbl_PLCConn);
            this.panel4.Controls.Add(this.uiLabel17);
            this.panel4.Controls.Add(this.lbl_PLCState);
            this.panel4.Controls.Add(this.uiLabel8);
            this.panel4.Controls.Add(this.uiLabel9);
            this.panel4.Controls.Add(this.uiLabel10);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(999, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(398, 109);
            this.panel4.TabIndex = 3;
            // 
            // uiLight1
            // 
            this.uiLight1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLight1.Location = new System.Drawing.Point(232, 22);
            this.uiLight1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiLight1.Name = "uiLight1";
            this.uiLight1.OffColor = System.Drawing.Color.Red;
            this.uiLight1.OnColor = System.Drawing.Color.LightGray;
            this.uiLight1.Radius = 59;
            this.uiLight1.Size = new System.Drawing.Size(59, 60);
            this.uiLight1.TabIndex = 10;
            this.uiLight1.Tag = "-1";
            this.uiLight1.Text = "uiLight1";
            // 
            // lbl_PLCConn
            // 
            this.lbl_PLCConn.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PLCConn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_PLCConn.Location = new System.Drawing.Point(115, 0);
            this.lbl_PLCConn.Name = "lbl_PLCConn";
            this.lbl_PLCConn.Size = new System.Drawing.Size(91, 28);
            this.lbl_PLCConn.TabIndex = 9;
            this.lbl_PLCConn.Text = "未连接";
            // 
            // uiLabel17
            // 
            this.uiLabel17.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel17.Location = new System.Drawing.Point(115, 30);
            this.uiLabel17.Name = "uiLabel17";
            this.uiLabel17.Size = new System.Drawing.Size(91, 28);
            this.uiLabel17.TabIndex = 8;
            this.uiLabel17.Text = "本地";
            // 
            // lbl_PLCState
            // 
            this.lbl_PLCState.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_PLCState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_PLCState.Location = new System.Drawing.Point(115, 60);
            this.lbl_PLCState.Name = "lbl_PLCState";
            this.lbl_PLCState.Size = new System.Drawing.Size(91, 28);
            this.lbl_PLCState.TabIndex = 7;
            this.lbl_PLCState.Text = "离线";
            // 
            // uiLabel8
            // 
            this.uiLabel8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel8.Location = new System.Drawing.Point(4, 60);
            this.uiLabel8.Name = "uiLabel8";
            this.uiLabel8.Size = new System.Drawing.Size(104, 28);
            this.uiLabel8.TabIndex = 2;
            this.uiLabel8.Text = "设备状态:";
            // 
            // uiLabel9
            // 
            this.uiLabel9.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel9.Location = new System.Drawing.Point(4, 30);
            this.uiLabel9.Name = "uiLabel9";
            this.uiLabel9.Size = new System.Drawing.Size(104, 28);
            this.uiLabel9.TabIndex = 1;
            this.uiLabel9.Text = "设备模式:";
            // 
            // uiLabel10
            // 
            this.uiLabel10.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel10.Location = new System.Drawing.Point(4, 0);
            this.uiLabel10.Name = "uiLabel10";
            this.uiLabel10.Size = new System.Drawing.Size(104, 28);
            this.uiLabel10.TabIndex = 0;
            this.uiLabel10.Text = "连接状态:";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.Controls.Add(this.lblLoginUserName);
            this.panel3.Controls.Add(this.lblLoginTime);
            this.panel3.Controls.Add(this.lblTime);
            this.panel3.Controls.Add(this.uiLabel5);
            this.panel3.Controls.Add(this.uiLabel6);
            this.panel3.Controls.Add(this.uiLabel7);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(517, 3);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(476, 109);
            this.panel3.TabIndex = 2;
            // 
            // lblLoginUserName
            // 
            this.lblLoginUserName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblLoginUserName.Location = new System.Drawing.Point(114, 59);
            this.lblLoginUserName.Name = "lblLoginUserName";
            this.lblLoginUserName.Size = new System.Drawing.Size(311, 28);
            this.lblLoginUserName.TabIndex = 6;
            // 
            // lblLoginTime
            // 
            this.lblLoginTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblLoginTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblLoginTime.Location = new System.Drawing.Point(114, 30);
            this.lblLoginTime.Name = "lblLoginTime";
            this.lblLoginTime.Size = new System.Drawing.Size(311, 28);
            this.lblLoginTime.TabIndex = 5;
            // 
            // lblTime
            // 
            this.lblTime.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lblTime.Location = new System.Drawing.Point(114, 0);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(311, 28);
            this.lblTime.TabIndex = 4;
            // 
            // uiLabel5
            // 
            this.uiLabel5.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel5.Location = new System.Drawing.Point(4, 59);
            this.uiLabel5.Name = "uiLabel5";
            this.uiLabel5.Size = new System.Drawing.Size(104, 28);
            this.uiLabel5.TabIndex = 2;
            this.uiLabel5.Text = "登录账号:";
            // 
            // uiLabel6
            // 
            this.uiLabel6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel6.Location = new System.Drawing.Point(4, 30);
            this.uiLabel6.Name = "uiLabel6";
            this.uiLabel6.Size = new System.Drawing.Size(104, 28);
            this.uiLabel6.TabIndex = 1;
            this.uiLabel6.Text = "登录时间:";
            // 
            // uiLabel7
            // 
            this.uiLabel7.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel7.Location = new System.Drawing.Point(4, 0);
            this.uiLabel7.Name = "uiLabel7";
            this.uiLabel7.Size = new System.Drawing.Size(104, 28);
            this.uiLabel7.TabIndex = 0;
            this.uiLabel7.Text = "系统时间:";
            // 
            // uiTableLayoutPanel4
            // 
            this.uiTableLayoutPanel4.BackColor = System.Drawing.Color.Transparent;
            this.uiTableLayoutPanel4.ColumnCount = 2;
            this.uiTableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.72205F));
            this.uiTableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.27795F));
            this.uiTableLayoutPanel4.Controls.Add(this.panel2, 1, 0);
            this.uiTableLayoutPanel4.Controls.Add(this.pictureBox1, 0, 0);
            this.uiTableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.uiTableLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.uiTableLayoutPanel4.Name = "uiTableLayoutPanel4";
            this.uiTableLayoutPanel4.RowCount = 1;
            this.uiTableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.uiTableLayoutPanel4.Size = new System.Drawing.Size(251, 109);
            this.uiTableLayoutPanel4.TabIndex = 0;
            this.uiTableLayoutPanel4.TagString = null;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.lbl_CompanyName);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(82, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(166, 103);
            this.panel2.TabIndex = 2;
            // 
            // lbl_CompanyName
            // 
            this.lbl_CompanyName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lbl_CompanyName.Font = new System.Drawing.Font("微软雅黑", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_CompanyName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_CompanyName.Location = new System.Drawing.Point(0, 0);
            this.lbl_CompanyName.Name = "lbl_CompanyName";
            this.lbl_CompanyName.Size = new System.Drawing.Size(166, 103);
            this.lbl_CompanyName.TabIndex = 0;
            this.lbl_CompanyName.Text = "中昌智能";
            this.lbl_CompanyName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.lbl_Version);
            this.panel1.Controls.Add(this.lbl_DeviceName);
            this.panel1.Controls.Add(this.lbl_DeviceCompany);
            this.panel1.Controls.Add(this.uiLabel4);
            this.panel1.Controls.Add(this.uiLabel3);
            this.panel1.Controls.Add(this.uiLabel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(260, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(251, 109);
            this.panel1.TabIndex = 1;
            // 
            // lbl_Version
            // 
            this.lbl_Version.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_Version.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_Version.Location = new System.Drawing.Point(103, 60);
            this.lbl_Version.Name = "lbl_Version";
            this.lbl_Version.Size = new System.Drawing.Size(130, 28);
            this.lbl_Version.TabIndex = 5;
            this.lbl_Version.Text = "1.0.0.1";
            // 
            // lbl_DeviceName
            // 
            this.lbl_DeviceName.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DeviceName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_DeviceName.Location = new System.Drawing.Point(103, 30);
            this.lbl_DeviceName.Name = "lbl_DeviceName";
            this.lbl_DeviceName.Size = new System.Drawing.Size(130, 28);
            this.lbl_DeviceName.TabIndex = 4;
            this.lbl_DeviceName.Text = "测试机";
            // 
            // lbl_DeviceCompany
            // 
            this.lbl_DeviceCompany.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbl_DeviceCompany.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.lbl_DeviceCompany.Location = new System.Drawing.Point(103, 0);
            this.lbl_DeviceCompany.Name = "lbl_DeviceCompany";
            this.lbl_DeviceCompany.Size = new System.Drawing.Size(130, 28);
            this.lbl_DeviceCompany.TabIndex = 3;
            this.lbl_DeviceCompany.Text = "苏州中昌";
            // 
            // uiLabel4
            // 
            this.uiLabel4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel4.Location = new System.Drawing.Point(4, 60);
            this.uiLabel4.Name = "uiLabel4";
            this.uiLabel4.Size = new System.Drawing.Size(104, 28);
            this.uiLabel4.TabIndex = 2;
            this.uiLabel4.Text = "软件版本:";
            // 
            // uiLabel3
            // 
            this.uiLabel3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel3.Location = new System.Drawing.Point(4, 30);
            this.uiLabel3.Name = "uiLabel3";
            this.uiLabel3.Size = new System.Drawing.Size(104, 28);
            this.uiLabel3.TabIndex = 1;
            this.uiLabel3.Text = "设备名称:";
            // 
            // uiLabel1
            // 
            this.uiLabel1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.uiLabel1.Location = new System.Drawing.Point(4, 0);
            this.uiLabel1.Name = "uiLabel1";
            this.uiLabel1.Size = new System.Drawing.Size(104, 28);
            this.uiLabel1.TabIndex = 0;
            this.uiLabel1.Text = "设备厂商:";
            // 
            // uiTableLayoutPanel2
            // 
            this.uiTableLayoutPanel2.BackColor = System.Drawing.Color.AliceBlue;
            this.uiTableLayoutPanel2.ColumnCount = 6;
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.uiTableLayoutPanel2.Controls.Add(this.uiButton8, 5, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiButton6, 4, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiButton4, 3, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiButton1, 1, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiButton2, 0, 0);
            this.uiTableLayoutPanel2.Controls.Add(this.uiButton3, 2, 0);
            this.uiTableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiTableLayoutPanel2.Location = new System.Drawing.Point(3, 786);
            this.uiTableLayoutPanel2.Name = "uiTableLayoutPanel2";
            this.uiTableLayoutPanel2.RowCount = 1;
            this.uiTableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.uiTableLayoutPanel2.Size = new System.Drawing.Size(1394, 36);
            this.uiTableLayoutPanel2.TabIndex = 0;
            this.uiTableLayoutPanel2.TagString = null;
            // 
            // uiButton8
            // 
            this.uiButton8.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton8.FillColor = System.Drawing.Color.AliceBlue;
            this.uiButton8.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton8.ForeColor = System.Drawing.Color.Black;
            this.uiButton8.Location = new System.Drawing.Point(1160, 0);
            this.uiButton8.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton8.Name = "uiButton8";
            this.uiButton8.RectColor = System.Drawing.Color.SlateGray;
            this.uiButton8.Size = new System.Drawing.Size(234, 36);
            this.uiButton8.TabIndex = 8;
            this.uiButton8.Text = "退出程序(Esc)";
            this.uiButton8.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiButton6
            // 
            this.uiButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton6.FillColor = System.Drawing.Color.AliceBlue;
            this.uiButton6.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton6.ForeColor = System.Drawing.Color.Black;
            this.uiButton6.Location = new System.Drawing.Point(928, 0);
            this.uiButton6.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton6.Name = "uiButton6";
            this.uiButton6.RectColor = System.Drawing.Color.SlateGray;
            this.uiButton6.Size = new System.Drawing.Size(232, 36);
            this.uiButton6.TabIndex = 6;
            this.uiButton6.Text = "系统配置(F11)";
            this.uiButton6.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiButton4
            // 
            this.uiButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton4.FillColor = System.Drawing.Color.AliceBlue;
            this.uiButton4.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton4.ForeColor = System.Drawing.Color.Black;
            this.uiButton4.Location = new System.Drawing.Point(696, 0);
            this.uiButton4.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton4.Name = "uiButton4";
            this.uiButton4.RectColor = System.Drawing.Color.SlateGray;
            this.uiButton4.Size = new System.Drawing.Size(232, 36);
            this.uiButton4.TabIndex = 4;
            this.uiButton4.Text = "调试功能(F4)";
            this.uiButton4.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiButton1
            // 
            this.uiButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton1.FillColor = System.Drawing.Color.AliceBlue;
            this.uiButton1.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton1.ForeColor = System.Drawing.Color.Black;
            this.uiButton1.Location = new System.Drawing.Point(232, 0);
            this.uiButton1.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton1.Name = "uiButton1";
            this.uiButton1.RectColor = System.Drawing.Color.SlateGray;
            this.uiButton1.Size = new System.Drawing.Size(232, 36);
            this.uiButton1.TabIndex = 3;
            this.uiButton1.Text = "生产记录(F2)";
            this.uiButton1.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiButton2
            // 
            this.uiButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton2.FillColor = System.Drawing.Color.AliceBlue;
            this.uiButton2.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton2.ForeColor = System.Drawing.Color.Black;
            this.uiButton2.Location = new System.Drawing.Point(0, 0);
            this.uiButton2.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton2.Name = "uiButton2";
            this.uiButton2.RectColor = System.Drawing.Color.SlateGray;
            this.uiButton2.Size = new System.Drawing.Size(232, 36);
            this.uiButton2.TabIndex = 1;
            this.uiButton2.Text = "生产监控(F1)";
            this.uiButton2.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiButton3
            // 
            this.uiButton3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.uiButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiButton3.FillColor = System.Drawing.Color.AliceBlue;
            this.uiButton3.Font = new System.Drawing.Font("微软雅黑", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiButton3.ForeColor = System.Drawing.Color.Black;
            this.uiButton3.Location = new System.Drawing.Point(464, 0);
            this.uiButton3.Margin = new System.Windows.Forms.Padding(0);
            this.uiButton3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiButton3.Name = "uiButton3";
            this.uiButton3.RectColor = System.Drawing.Color.SlateGray;
            this.uiButton3.Size = new System.Drawing.Size(232, 36);
            this.uiButton3.TabIndex = 2;
            this.uiButton3.Text = "产品配方(F3)";
            this.uiButton3.TipsFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            // 
            // uiPanel1
            // 
            this.uiPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.uiPanel1.FillColor = System.Drawing.Color.White;
            this.uiPanel1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPanel1.Location = new System.Drawing.Point(0, 107);
            this.uiPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.uiPanel1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPanel1.Name = "uiPanel1";
            this.uiPanel1.RectColor = System.Drawing.Color.Black;
            this.uiPanel1.RectDisableColor = System.Drawing.Color.Black;
            this.uiPanel1.Size = new System.Drawing.Size(1400, 676);
            this.uiPanel1.TabIndex = 2;
            this.uiPanel1.Text = null;
            this.uiPanel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ZCForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.BackColor = System.Drawing.Color.Transparent;
            this.ClientSize = new System.Drawing.Size(1400, 860);
            this.ControlBoxForeColor = System.Drawing.Color.Black;
            this.Controls.Add(this.uiTableLayoutPanel1);
            this.EscClose = true;
            this.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1920, 1080);
            this.MinimumSize = new System.Drawing.Size(1280, 860);
            this.Name = "ZCForm";
            this.Text = "数据采集系统";
            this.TitleColor = System.Drawing.Color.AliceBlue;
            this.TitleFont = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.TitleForeColor = System.Drawing.Color.Black;
            this.ZoomScaleRect = new System.Drawing.Rectangle(15, 15, 1920, 1040);
            this.uiTableLayoutPanel1.ResumeLayout(false);
            this.uiPanel2.ResumeLayout(false);
            this.uiTableLayoutPanel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.uiTableLayoutPanel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.uiTableLayoutPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel1;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel2;
        private Sunny.UI.UIButton uiButton2;
        private Sunny.UI.UIButton uiButton8;
        private Sunny.UI.UIButton uiButton6;
        private Sunny.UI.UIButton uiButton4;
        private Sunny.UI.UIButton uiButton1;
        private Sunny.UI.UIButton uiButton3;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel3;
        private Sunny.UI.UITableLayoutPanel uiTableLayoutPanel4;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Sunny.UI.UILabel lbl_CompanyName;
        private Sunny.UI.UILabel uiLabel1;
        private Sunny.UI.UILabel uiLabel4;
        private Sunny.UI.UILabel uiLabel3;
        private System.Windows.Forms.Panel panel3;
        private Sunny.UI.UILabel uiLabel5;
        private Sunny.UI.UILabel uiLabel6;
        private Sunny.UI.UILabel uiLabel7;
        private System.Windows.Forms.Panel panel4;
        private Sunny.UI.UILabel uiLabel8;
        private Sunny.UI.UILabel uiLabel9;
        private Sunny.UI.UILabel uiLabel10;
        private Sunny.UI.UILabel lbl_DeviceCompany;
        private Sunny.UI.UILabel lbl_DeviceName;
        private Sunny.UI.UILabel lbl_Version;
        private Sunny.UI.UILabel lblLoginTime;
        private Sunny.UI.UILabel lblTime;
        private Sunny.UI.UILabel lblLoginUserName;
        private Sunny.UI.UILabel lbl_PLCState;
        private Sunny.UI.UILabel uiLabel17;
        private Sunny.UI.UILabel lbl_PLCConn;
        private Sunny.UI.UIPanel uiPanel1;
        private Sunny.UI.UILight uiLight1;
        private Sunny.UI.UIPanel uiPanel2;
    }
}