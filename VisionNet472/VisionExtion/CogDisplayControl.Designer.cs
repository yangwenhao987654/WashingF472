namespace AutoTF.UserCtrls
{
    partial class CogDisplayControl
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CogDisplayControl));
            this.second = new System.Windows.Forms.TableLayoutPanel();
            this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
            this.cogDisplayToolbar = new Cognex.VisionPro.CogDisplayToolbarV2();
            this.first = new System.Windows.Forms.TableLayoutPanel();
            this.third = new System.Windows.Forms.TableLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.cogDisplayStatusBar = new Cognex.VisionPro.CogDisplayStatusBarV2();
            this.m_ctrlExecutionTime = new System.Windows.Forms.Label();
            this.table = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.txt1 = new System.Windows.Forms.Label();
            this.second.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
            this.first.SuspendLayout();
            this.third.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.table.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // second
            // 
            this.second.ColumnCount = 1;
            this.second.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.second.Controls.Add(this.cogRecordDisplay1, 0, 0);
            this.second.Dock = System.Windows.Forms.DockStyle.Fill;
            this.second.Location = new System.Drawing.Point(0, 20);
            this.second.Margin = new System.Windows.Forms.Padding(0);
            this.second.Name = "second";
            this.second.RowCount = 1;
            this.second.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.second.Size = new System.Drawing.Size(434, 377);
            this.second.TabIndex = 1;
            // 
            // cogRecordDisplay1
            // 
            this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
            this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
            this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
            this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
            this.cogRecordDisplay1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogRecordDisplay1.DoubleTapZoomCycleLength = 2;
            this.cogRecordDisplay1.DoubleTapZoomSensitivity = 2.5D;
            this.cogRecordDisplay1.Location = new System.Drawing.Point(0, 0);
            this.cogRecordDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
            this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
            this.cogRecordDisplay1.Name = "cogRecordDisplay1";
            this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
            this.cogRecordDisplay1.Size = new System.Drawing.Size(434, 377);
            this.cogRecordDisplay1.TabIndex = 0;
            this.cogRecordDisplay1.DoubleClick += new System.EventHandler(this.cogRecordDisplay1_DoubleClick);
            // 
            // cogDisplayToolbar
            // 
            this.cogDisplayToolbar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cogDisplayToolbar.Location = new System.Drawing.Point(0, 0);
            this.cogDisplayToolbar.Margin = new System.Windows.Forms.Padding(0);
            this.cogDisplayToolbar.Name = "cogDisplayToolbar";
            this.cogDisplayToolbar.Size = new System.Drawing.Size(434, 1);
            this.cogDisplayToolbar.TabIndex = 7;
            // 
            // first
            // 
            this.first.ColumnCount = 1;
            this.first.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.30496F));
            this.first.Controls.Add(this.cogDisplayToolbar, 0, 0);
            this.first.Dock = System.Windows.Forms.DockStyle.Fill;
            this.first.Location = new System.Drawing.Point(0, 20);
            this.first.Margin = new System.Windows.Forms.Padding(0);
            this.first.Name = "first";
            this.first.RowCount = 1;
            this.first.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.first.Size = new System.Drawing.Size(434, 1);
            this.first.TabIndex = 0;
            // 
            // third
            // 
            this.third.ColumnCount = 1;
            this.third.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.third.Controls.Add(this.splitContainer1, 0, 0);
            this.third.Dock = System.Windows.Forms.DockStyle.Fill;
            this.third.Location = new System.Drawing.Point(0, 397);
            this.third.Margin = new System.Windows.Forms.Padding(0);
            this.third.Name = "third";
            this.third.RowCount = 1;
            this.third.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.third.Size = new System.Drawing.Size(434, 1);
            this.third.TabIndex = 2;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.cogDisplayStatusBar);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.m_ctrlExecutionTime);
            this.splitContainer1.Size = new System.Drawing.Size(428, 1);
            this.splitContainer1.SplitterDistance = 382;
            this.splitContainer1.TabIndex = 0;
            // 
            // cogDisplayStatusBar
            // 
            this.cogDisplayStatusBar.CoordinateSpaceName = "*\\#";
            this.cogDisplayStatusBar.CoordinateSpaceName3D = "*\\#";
            this.cogDisplayStatusBar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cogDisplayStatusBar.Location = new System.Drawing.Point(0, 0);
            this.cogDisplayStatusBar.Margin = new System.Windows.Forms.Padding(0);
            this.cogDisplayStatusBar.Name = "cogDisplayStatusBar";
            this.cogDisplayStatusBar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.cogDisplayStatusBar.Size = new System.Drawing.Size(382, 1);
            this.cogDisplayStatusBar.TabIndex = 0;
            this.cogDisplayStatusBar.Use3DCoordinateSpaceTree = false;
            // 
            // m_ctrlExecutionTime
            // 
            this.m_ctrlExecutionTime.AutoSize = true;
            this.m_ctrlExecutionTime.Dock = System.Windows.Forms.DockStyle.Fill;
            this.m_ctrlExecutionTime.Location = new System.Drawing.Point(0, 0);
            this.m_ctrlExecutionTime.Name = "m_ctrlExecutionTime";
            this.m_ctrlExecutionTime.Size = new System.Drawing.Size(35, 12);
            this.m_ctrlExecutionTime.TabIndex = 0;
            this.m_ctrlExecutionTime.Text = "999ms";
            // 
            // table
            // 
            this.table.ColumnCount = 1;
            this.table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.Controls.Add(this.first, 0, 1);
            this.table.Controls.Add(this.second, 0, 2);
            this.table.Controls.Add(this.third, 0, 3);
            this.table.Controls.Add(this.tableLayoutPanel1, 0, 0);
            this.table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.table.Location = new System.Drawing.Point(0, 0);
            this.table.Margin = new System.Windows.Forms.Padding(0);
            this.table.Name = "table";
            this.table.RowCount = 4;
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 0F));
            this.table.Size = new System.Drawing.Size(434, 397);
            this.table.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.txt1, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(434, 20);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // txt1
            // 
            this.txt1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txt1.BackColor = System.Drawing.Color.Transparent;
            this.txt1.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt1.ForeColor = System.Drawing.Color.Black;
            this.txt1.Location = new System.Drawing.Point(0, 0);
            this.txt1.Margin = new System.Windows.Forms.Padding(0);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(434, 20);
            this.txt1.TabIndex = 7;
            this.txt1.Text = "相机";
            this.txt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.txt1.Click += new System.EventHandler(this.txt1_Click);
            // 
            // CogDisplayControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.table);
            this.Margin = new System.Windows.Forms.Padding(0);
            this.Name = "CogDisplayControl";
            this.Size = new System.Drawing.Size(434, 397);
            this.Load += new System.EventHandler(this.CogDisplayControl_Load);
            this.DoubleClick += new System.EventHandler(this.CogDisplayControl_DoubleClick);
            this.second.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
            this.first.ResumeLayout(false);
            this.third.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.table.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.TableLayoutPanel second;
        internal Cognex.VisionPro.CogDisplayToolbarV2 cogDisplayToolbar;
        internal System.Windows.Forms.TableLayoutPanel first;
        internal System.Windows.Forms.TableLayoutPanel third;
        internal System.Windows.Forms.TableLayoutPanel table;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        internal System.Windows.Forms.Label txt1;
        internal Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        internal Cognex.VisionPro.CogDisplayStatusBarV2 cogDisplayStatusBar;
        internal System.Windows.Forms.Label m_ctrlExecutionTime;


    }
}
