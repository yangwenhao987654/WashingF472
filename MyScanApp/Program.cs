using LogTool;
using Microsoft.Extensions.DependencyInjection;
using ScanApp.DAL.DBContext;
using ScanApp.DAL.Entity;
using ScanApp.DAL.ExecuteSQL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
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
