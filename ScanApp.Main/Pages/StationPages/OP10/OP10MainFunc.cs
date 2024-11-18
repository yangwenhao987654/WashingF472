using CommunicationUtilYwh.Device;
using DWZ_Scada.ctrls;
using DWZ_Scada.ctrls.LogCtrl;
using LogTool;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace DWZ_Scada.Pages.StationPages.OP10
{
    public class OP10MainFunc
    {
        public static bool IsInstanceNull => _instance == null;

        private static OP10MainFunc _instance;

        public static OP10MainFunc Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (typeof(OP10MainFunc))
                    {
                        if (_instance == null)
                        {
                            // 使用一个工厂方法创建实例，让子类决定实例化逻辑
                            throw new Exception("OP10MainFunc is Not instantiate");
                        }
                    }
                }
                return _instance;
            }
        }


        public event Action<double,double > OnTemperatureRecived;

        private  object _lock = new object();

        public OP10MainFunc( ) 
        {

          
        }

        public  void Dispose()
        {

        }
     
        public  async void PLCMainWork(CancellationToken token)
        {
            int state = -1;
            Thread t1 = new Thread(() => VisionMonitor01(token));
            t1.Start();


            Thread t3 = new Thread(() => TemperatureMonitor(token));
            t3.Start();
            while (!token.IsCancellationRequested)
            {
                try
                {
            

                }
                catch (Exception ex)
                {
                    LogMgr.Instance.Error($"Exception in PLCMainWork: {ex.Message}");
                }

                Thread.Sleep(1000);
            }
        }

        private void TemperatureMonitor(CancellationToken token)
        {
            TemperatureController485 controller = new TemperatureController485();
            while (!token.IsCancellationRequested)
            {
                try
                {
                    if (controller.IsConnect)
                    {
                        //连接成功
                        double humidity = controller.ReadHumidity();
                        double temperature = controller.ReadTemperature();
                        //获取到温度和湿度

                        lock (_lock)
                        {
                            CurHumidity = humidity;
                            CurTemperature = temperature;
                        }
                        //实时显示温度和湿度
                        OnTemperatureRecived?.Invoke(temperature,humidity);
                    }
                    else
                    {
                        controller.Open(SystemParams.Instance.OP10_ComName);
                    }
                }
                catch (Exception e)
                {
                    LogMgr.Instance.Error($"温度采集线程出错:{e.Message}");
                    //LogMgr.Instance.Error($"温度采集线程出错:{e.Message}");
                }
                Thread.Sleep(1000);
            }
            controller.Dispose();
        }

        /// <summary>
        /// 当前温度
        /// </summary>
        public double CurTemperature { get; set; }

        /// <summary>
        /// 当前湿度
        /// </summary>
        public double CurHumidity { get; set; }

        /// <summary>
        /// 画像检测流程
        /// </summary>
        /// <param name="token"></param>
        private async void VisionMonitor01(CancellationToken token)
        {
            while (!token.IsCancellationRequested)
            {
                try
                {
                  
                    Thread.Sleep(100);
                }
                catch (Exception e)
                {
                    LogMgr.Instance.Error("画像检测1线程错误:" + e.Message);
                }
            }
        }

        public void StartAsync()
        {
            throw new NotImplementedException();
        }
    }
}