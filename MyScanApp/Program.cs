using DWZ_Scada.Pages;
using LogTool;
using Microsoft.Extensions.DependencyInjection;
using ScanApp.DAL.ExecuteSQL;
using System;
using System.IO;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace DWZ_Scada
{
    internal static class Program
    {

        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region 只允许打开一个程序
            #endregion
            try
            {

                bool canCreateNew;
                string mutexName = System.Reflection.Assembly.GetEntryAssembly().FullName;
                using (Mutex m = new Mutex(false, mutexName, out canCreateNew))
                {
                    //GC.RegisterForFullGCNotification(GarbageCollectionNotificationCallback,null));
                        #region 处理全局异常,Task类中出现的异常无法在此捕获.
                        Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                        //处理UI异常
                        Application.ThreadException += Application_ThreadException;
                        //处理非UI异常
                        AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                        Application.EnableVisualStyles();
                        Application.SetCompatibleTextRenderingDefault(false);
                        #endregion
                        //TODO 先登录 登录成功后进入系统
                        LogMgr.Instance.Init();
                        SystemParams.Load();
                        if (!canCreateNew)
                        {
                            MessageBox.Show(null, "有一个和本程序相同的应用程序已经在运行，请不要同时运行多个本程序。\n\n这个程序即将退出。", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            Environment.Exit(1);
                            return;
                        }


                        //假如更新数据库 就屏蔽下面的东西
#if !UPDATE_DB 
                    var serviceCollection = new ServiceCollection();

                    ConfigureServices(serviceCollection);
                    Global.ServiceProvider = serviceCollection.BuildServiceProvider();
                    ZCForm mainForm = ZCForm.Instance;
                    //mainForm.WindowState = FormWindowState.Maximized;

                    /* MyDbContext db = new MyDbContext();
                     List<BarcodeRecordEntity> list = db.tbBarcode.ToList();*/
                    Application.Run(mainForm);
#else
                    int a = 1;
#endif

                }
            }
            catch (Exception ex)
            {
                Application_ThreadException(null, new ThreadExceptionEventArgs(ex));
            }
            finally
            {
                LogMgr.Instance.Info("关闭应用程序！");
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {

            #region 注册数据库访问接口

            services.AddSingleton<IProductFormulaDAL, ProductFormulaDAL>();

            #endregion

        }


        #region 具体的异常处理函数
        private static void Application_ThreadException(object sender, System.Threading.ThreadExceptionEventArgs e)
        {
            WriteError(e.Exception, true);
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            WriteError(e.ExceptionObject as Exception, false);
        }
        private static void WriteError(Exception ex, bool isUIError)
        {
            StringBuilder sb = new StringBuilder();
            string head = string.Empty;
            sb.AppendLine("**************************************************************************异常文本**************************************************************************");
            sb.AppendLine($"[出现时间]:{DateTime.Now.ToString()}");
            if (ex != null)
            {
                sb.AppendLine($"[异常类型]:{ex.GetType()}");
                head = isUIError ? "UI线程" : "非UI线程";
                sb.AppendLine($"[异常线程]:{head}");
                sb.AppendLine($"[异常信息]:{ex.Message}");
                sb.AppendLine($"[调用堆栈]:{ex.StackTrace}");
            }
            else
            {
                sb.AppendLine($"[空异常]");
            }
            sb.AppendLine("**************************************************************************文本结束**************************************************************************");
            sb.AppendLine();
            sb.AppendLine();
            var filePath = $@"{Application.StartupPath}\Error\{DateTime.Now.ToString("yyyy-MM-dd")}.txt";
            try
            {
                new FileInfo(filePath).Directory.Create();
                using (StreamWriter sw = new StreamWriter(filePath, true, Encoding.UTF8))
                {
                    sw.WriteLine(sb.ToString());
                }
            }
            catch (Exception ex2)
            {

            }
            head += "异常终止!";
            MessageBox.Show(sb.ToString(), head, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Process.GetCurrentProcess().Kill();
        }
        #endregion
    }
}
