using CommonUtilYwh.Communication.ModbusTCP;
using CommunicationUtilYwh.Device;
using DWZ_Scada.ctrls.LogCtrl;
using LogTool;
using Microsoft.Extensions.DependencyInjection;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using UtilYwh.VoicePrompt;

namespace DWZ_Scada.Pages.StationPages.OP10
{
    public partial class PageOP10 : UIPage
    {
        public PlcState PlcState;

        private readonly Action _clearAlarmDelegate;

        private Scanner_RS232 scanner;

        private ModbusTCP modbusTcp = new ModbusTCP();

        public int OKCount { get; set; }

        public int NGCount { get; set; }

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

        public int SelectCodeType { get; set; } = -1;


        private CancellationTokenSource cts = new CancellationTokenSource();

        SoundHelper soundHelper = new SoundHelper();

        private PageOP10()
        {
            InitializeComponent();
            _instance = this;
        }

        private async void Page_Load(object sender, EventArgs e)
        {
            LogMgr.Instance.Debug("打开扫码对比软件");

            try
            {
                ctrlOCV1.InitVpro(Global.VppPath);
            }
            catch (Exception exception)
            {
                MessageBox.Show($"加载VPP错误:{exception.Message}");
            }

            myLogCtrl1.BindingControl = uiPanel1;
            Mylog.Instance.Init(myLogCtrl1);


            if (SystemParams.Instance.ScannerComName == null)
            {
                SystemParams.Instance.ScannerComName = "COM3";
            }
            SerialPort port = new SerialPort(SystemParams.Instance.ScannerComName);
            scanner = new Scanner_RS232(port);
            scanner.Open();
            //modbusTcp.Connect();
            Thread t0 = new Thread(() => SerialPortMonitor(cts.Token));
            t0.Start();

            Thread t = new Thread(() => PLCMainWork(cts.Token));
            t.Start();

        }

        private void SerialPortMonitor(CancellationToken token)
        {

            while (!token.IsCancellationRequested)
            {
                try
                {

                    if (scanner.IsOpen)
                    {

                    }
                    else
                    {
                        scanner.SetPort(new SerialPort(SystemParams.Instance.ScannerComName));
                        bool isOpen = scanner.Open();
                        if (!isOpen)
                        {
                            LogMgr.Instance.Error($"串口打开失败：{SystemParams.Instance.ScannerComName}");
                        }
                    }
                }
                catch (Exception ex)
                {
                    LogMgr.Instance.Error($"串口监控线程错误:{ex.Message}");
                }
                finally
                {
                    Thread.Sleep(1000);
                }
            }
        }

        public string ScanHandle()
        {
            LogMgr.Instance.Debug("开始触发扫码");
            userCtrlEntry1.Start("");
            string res = "";
            for (int i = 0; i < 3; i++)
            {
                res = TriggerScanner();
                if (res != "")
                {
                    break;
                }
            }
            return res;
        }

        public void PLCMainWork(CancellationToken token)
        {
            int state = -1;
            //
            Thread.Sleep(2000);
            while (!token.IsCancellationRequested)
            {
                try
                {
                    if (modbusTcp.IsConnect)
                    {
                        PlcState = PlcState.Online;
                    }
                    else
                    {
                        ZCForm.Instance.UpdatePlcState(PlcState);
                    }
                }
                catch (Exception ex)
                {
                    LogMgr.Instance.Error($"Exception in modbusTcp Work: {ex.Message} {ex.StackTrace}");
                    UIMessageBox.ShowError($"错误：{ex.StackTrace}");
                }
                Thread.Sleep(100);
            }
        }

        private string TriggerScanner()
        {
            scanner.Trigger();
            Thread.Sleep(200);

            return scanner.GetResult();
        }

        private bool GetFinishSignal()
        {
            //完成信号 读0
            //modbusTcp.ReadBool("0", out bool isFinish);
            modbusTcp.ReadBool("0", out bool[] arr,8);
            bool isFinish = false;
            if (arr==null)
            {
                return false;
            }
            for (var i = 0; i < arr.Length; i++)
            {
                if (arr[i])
                {
                    isFinish = true;
                    break;
                }
            }
            return isFinish;
        }


        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PageOP10_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogMgr.Instance.Info("关闭程序");
            cts.Cancel();
            modbusTcp?.Close();
            scanner?.Dispose();
            _instance = null;
            //调用 Close() 方法,先进入  FormClosing 事件 ，之后再调用Designer类的Dispose
        }

        private async void uiButton3_Click(object sender, EventArgs e)
        {

            //soundHelper.PlayErr();
            string res = "";
            for (int i = 0; i < 3; i++)
            {
                res = TriggerScanner();
                //Mylog.Instance.Debug($"读码结果:[{res}]");
                if (res != "")
                {
                    break;
                }
            }
            if (res != "")
            {
                Mylog.Instance.Info($"读取条码:[{res}]");
            }
            else
            {
                Mylog.Instance.Error("读取失败");
            }
        }
    }
    public enum PlcState
    {
        Online = 0,
        OffLine = -1,
        Alarm = 2,
        Running = 1,
        Stop = 3,
    }

    }
