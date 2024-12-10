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
            second = new TableLayoutPanel();
            first = new TableLayoutPanel();
            third = new TableLayoutPanel();
            splitContainer1 = new SplitContainer();
            m_ctrlExecutionTime = new Label();
            table = new TableLayoutPanel();
            tableLayoutPanel1 = new TableLayoutPanel();
            txt1 = new Label();
            third.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            table.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // second
            // 
            second.ColumnCount = 1;
            second.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            second.Dock = DockStyle.Fill;
            second.Location = new Point(0, 20);
            second.Margin = new Padding(0);
            second.Name = "second";
            second.RowCount = 1;
            second.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            second.Size = new Size(434, 377);
            second.TabIndex = 1;
            // 
            // first
            // 
            first.ColumnCount = 1;
            first.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.30496F));
            first.Dock = DockStyle.Fill;
            first.Location = new Point(0, 20);
            first.Margin = new Padding(0);
            first.Name = "first";
            first.RowCount = 1;
            first.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            first.Size = new Size(434, 1);
            first.TabIndex = 0;
            // 
            // third
            // 
            third.ColumnCount = 1;
            third.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            third.Controls.Add(splitContainer1, 0, 0);
            third.Dock = DockStyle.Fill;
            third.Location = new Point(0, 397);
            third.Margin = new Padding(0);
            third.Name = "third";
            third.RowCount = 1;
            third.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            third.Size = new Size(434, 1);
            third.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(3, 3);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(m_ctrlExecutionTime);
            splitContainer1.Size = new Size(428, 1);
            splitContainer1.SplitterDistance = 382;
            splitContainer1.TabIndex = 0;
            // 
            // m_ctrlExecutionTime
            // 
            m_ctrlExecutionTime.AutoSize = true;
            m_ctrlExecutionTime.Dock = DockStyle.Fill;
            m_ctrlExecutionTime.Location = new Point(0, 0);
            m_ctrlExecutionTime.Name = "m_ctrlExecutionTime";
            m_ctrlExecutionTime.Size = new Size(35, 12);
            m_ctrlExecutionTime.TabIndex = 0;
            m_ctrlExecutionTime.Text = "999ms";
            // 
            // table
            // 
            table.ColumnCount = 1;
            table.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            table.Controls.Add(first, 0, 1);
            table.Controls.Add(second, 0, 2);
            table.Controls.Add(third, 0, 3);
            table.Controls.Add(tableLayoutPanel1, 0, 0);
            table.Dock = DockStyle.Fill;
            table.Location = new Point(0, 0);
            table.Margin = new Padding(0);
            table.Name = "table";
            table.RowCount = 4;
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            table.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            table.RowStyles.Add(new RowStyle(SizeType.Absolute, 0F));
            table.Size = new Size(434, 397);
            table.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(txt1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(434, 20);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // txt1
            // 
            txt1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txt1.BackColor = Color.Transparent;
            txt1.Font = new Font("黑体", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txt1.ForeColor = Color.Black;
            txt1.Location = new Point(0, 0);
            txt1.Margin = new Padding(0);
            txt1.Name = "txt1";
            txt1.Size = new Size(434, 20);
            txt1.TabIndex = 7;
            txt1.Text = "相机";
            txt1.TextAlign = ContentAlignment.MiddleCenter;
            txt1.Click += txt1_Click;
            // 
            // CogDisplayControl
            // 
            AutoScaleMode = AutoScaleMode.Inherit;
            Controls.Add(table);
            Margin = new Padding(0);
            Name = "CogDisplayControl";
            Size = new Size(434, 397);
            Load += CogDisplayControl_Load;
            DoubleClick += CogDisplayControl_DoubleClick;
            third.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            table.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
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
