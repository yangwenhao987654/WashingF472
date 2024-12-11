using DWZ_Scada.Pages;
using System.Windows.Forms;
using TestFrameworkForm;

namespace APP.Core
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //ZCForm mainForm = ZCForm.Instance;
            Application.Run(new FormTest());
        }
    }
}