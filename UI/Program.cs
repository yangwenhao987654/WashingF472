using DWZ_Scada;
using DWZ_Scada.Pages;
using LogTool;
using Microsoft.Extensions.DependencyInjection;
using System.Text;
using UI.DAL.BLL;
using UI.DAL.DAL;

namespace UI
{
    internal static class Program  
    {

        /// <summary>
        /// Ӧ�ó��������ڵ㡣
        /// </summary>
        [STAThread]
        static void Main()
        {
            #region ֻ�����һ������
            #endregion
            try
            {

                bool canCreateNew;
                string mutexName = System.Reflection.Assembly.GetEntryAssembly().FullName;
                using (Mutex m = new Mutex(false, mutexName, out canCreateNew))
                {
                    //GC.RegisterForFullGCNotification(GarbageCollectionNotificationCallback,null));
                    #region ����ȫ���쳣,Task���г��ֵ��쳣�޷��ڴ˲���.
                    Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);
                    //����UI�쳣
                    Application.ThreadException += Application_ThreadException;
                    //�����UI�쳣
                    AppDomain.CurrentDomain.UnhandledException += CurrentDomain_UnhandledException;
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    #endregion
                    //TODO �ȵ�¼ ��¼�ɹ������ϵͳ
                    LogMgr.Instance.Init();
                    SystemParams.Load();
                    if (!canCreateNew)
                    {
                        MessageBox.Show(null, "��һ���ͱ�������ͬ��Ӧ�ó����Ѿ������У��벻Ҫͬʱ���ж��������\n\n������򼴽��˳���", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        Environment.Exit(1);
                        return;
                    }


                    //����������ݿ� ����������Ķ���
#if !UPDATE_DB
                    var serviceCollection = new ServiceCollection();

                    ConfigureServices(serviceCollection);
                    Global.ServiceProvider = serviceCollection.BuildServiceProvider();
                    ZCForm mainForm = ZCForm.Instance;
                    //mainForm.WindowState = FormWindowState.Maximized;

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
                LogMgr.Instance.Info("�ر�Ӧ�ó���");
            }
        }

        private static void ConfigureServices(ServiceCollection services)
        {

            #region ע�����ݿ���ʽӿ�

            services.AddSingleton<IProductFormulaDAL, ProductFormulaDAL>();

            services.AddSingleton<IBarcodeRecordBLL, BarcodeRecordBLL>();

            services.AddSingleton<IBarcodeRecordDAL, BarcodeRecordDAL>();
            #endregion

        }


        #region ������쳣������
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
            sb.AppendLine("**************************************************************************�쳣�ı�**************************************************************************");
            sb.AppendLine($"[����ʱ��]:{DateTime.Now.ToString()}");
            if (ex != null)
            {
                sb.AppendLine($"[�쳣����]:{ex.GetType()}");
                head = isUIError ? "UI�߳�" : "��UI�߳�";
                sb.AppendLine($"[�쳣�߳�]:{head}");
                sb.AppendLine($"[�쳣��Ϣ]:{ex.Message}");
                sb.AppendLine($"[���ö�ջ]:{ex.StackTrace}");
            }
            else
            {
                sb.AppendLine($"[���쳣]");
            }
            sb.AppendLine("**************************************************************************�ı�����**************************************************************************");
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
            head += "�쳣��ֹ!";
            MessageBox.Show(sb.ToString(), head, MessageBoxButtons.OK, MessageBoxIcon.Error);
            //Process.GetCurrentProcess().Kill();
        }
        #endregion
    }
}
