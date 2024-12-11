using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cognex.VisionPro;
using System.Globalization;


namespace AutoTF.UserCtrls
{
    public partial class CogDisplayControl : UserControl
    {
        public delegate void ButtonClickHandler();
        public CogRecordDisplay record = new CogRecordDisplay();
        public TableLayoutPanel mParent = null;
        public int mPositionIdx = 0;
        public int DisplayID;
        private double m_lastExecutionTime = 0;
    
        private delegate void UpdateTitleDelegate();

        public Label textbox = new Label();
        public CogDisplayControl()
        {
            try
            {
                InitializeComponent();
                Resize += OnResizeCogDisplayUI;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw new Exception("加载cogDIsplay组件错误:"+e.Message);
            }
       
        }
        public event CogDisplayControl.ButtonClickHandler ButtonDoubleClick;
        private void CogDisplayControl_Load(object sender, EventArgs e)
        {
            try
            {
                this.UpdateStyles();
                record = cogRecordDisplay1;
                textbox = txt1;
                cogDisplayToolbar.Display = cogRecordDisplay1;
                cogDisplayStatusBar.Display = cogRecordDisplay1;
            }
            catch (Exception ex)
            {
                throw new Exception("加载自定义CogDisplayControl组件错误:"+ex.Message);
            }
 
        }
        private void OnResizeCogDisplayUI(object sender, EventArgs e)
        {
            cogRecordDisplay1.Left = 0;
            cogRecordDisplay1.Width = this.Width;
            cogRecordDisplay1.Top = this.cogDisplayToolbar.Height;
            cogRecordDisplay1.Height = this.Height - this.cogDisplayToolbar.Height - this.cogDisplayStatusBar.Height - this.txt1.Height;
        }

        private void CogDisplayControl_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonDoubleClick != null)
            {
                this.ButtonDoubleClick();
            }
        }

        private void cogRecordDisplay1_DoubleClick(object sender, EventArgs e)
        {
            if (this.ButtonDoubleClick != null)
            {
                this.ButtonDoubleClick();
            }
        }

        public double ExecutionTime
        {
            get
            {
                return this.m_lastExecutionTime;
            }
            set
            {
                this.m_lastExecutionTime = value;
                this.UpdateTitle();
            }
        }

        private void UpdateTitle()
        {
            if (base.InvokeRequired)
            {
                base.BeginInvoke(new UpdateTitleDelegate(this.UpdateTitle));
                return;
            }

            if (this.m_lastExecutionTime >= 0.0)
            {
                this.m_ctrlExecutionTime.Text = string.Format("{0} ms", this.m_lastExecutionTime.ToString("F0", CultureInfo.InvariantCulture));
                return;
            }
            this.m_ctrlExecutionTime.Text = "";
            return;

        }

        private void txt1_Click(object sender, EventArgs e)
        {

        }
    }
}
