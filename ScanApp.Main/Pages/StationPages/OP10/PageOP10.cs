using DWZ_Scada.ctrls.LogCtrl;
using DWZ_Scada.UIUtil;
using LogTool;
using Sunny.UI;
using System;
using System.Windows.Forms;

namespace DWZ_Scada.Pages.StationPages.OP10
{
    public partial class PageOP10 : UIPage
    {

        private readonly Action _clearAlarmDelegate;


        private static PageOP10 _instance;
        public static PageOP10 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (typeof(PageOP10))
                    {
                        if (_instance == null)
                        {
                            _instance = new PageOP10();
                        }
                    }
                }
                return _instance;
            }
        }

        private PageOP10()
        {
            InitializeComponent();
            _instance = this;
        }

        private void Page_Load(object sender, EventArgs e)
        {
            //LogMgr.Instance.SetCtrl(listViewEx_Log1);
            LogMgr.Instance.Debug("打开OP10工站");

            OP10MainFunc.Instance.StartAsync();


            myLogCtrl1.BindingControl = uiPanel1;
            Mylog.Instance.Init(myLogCtrl1);
        }

        private void Instance_OnTemperatureRecived(double temperature, double humidity)
        {
            UpdateTemperature(temperature, humidity);
        }

        private void UpdateTemperature(double temperature, double humidity)
        {
            if (InvokeRequired)
            {
                this.Invoke(new Action<double,double>(UpdateTemperature),temperature,humidity);
                return;
            }
            lbl_temperature.Text = $"{temperature}℃";
            lbl_humidity.Text = $"{humidity}%RH";

        }

        private void Instance_OnEntryStateChanged(string sn, int result, string msg = "")
        {
            MyUIControler.UpdateEntryStateCtrl(userCtrlEntry1, sn, result, msg);
        }

        private void PageOP10_OnVision1Finished(string sn, int result)
        {
            MyUIControler.UpdateTestStateCtrl(ctrlResult_V1, sn, result);
        }

        private void PageOP10_OnVision2Finished(string sn, int result)
        {
            MyUIControler.UpdateTestStateCtrl(ctrlResult_V2, sn, result);
        }

        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PageOP10_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogMgr.Instance.Info("关闭OP10-HttpServer");
            if (!OP10MainFunc.IsInstanceNull)
            {
                OP10MainFunc.Instance?.Dispose();
            }
            LogMgr.Instance.Info("关闭OP10程序");
            _instance = null;
            //调用 Close() 方法,先进入  FormClosing 事件 ，之后再调用Designer类的Dispose
        }

        private void workOrderCtrl1_Load(object sender, EventArgs e)
        {

        }
    }
}
