using DIPTest.Ctrl;
using System;
namespace DWZ_Scada.UIUtil
{
    public class MyUIControler
    {
     
        public static void UpdateTestStateCtrl(UserCtrlResult ctrl, string sn, int result,string err="")
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new Action<UserCtrlResult, string, int,string>(UpdateTestStateCtrl), ctrl, sn, result,err);
                return;
            }

            if (result == 0)
            {
                ctrl.Start(sn);
            }
            else if (result == 1)
            {
                ctrl.Pass(sn);
            }
            else if (result == 2)
            {
                ctrl.Fail(sn, err);
            }
            else
            {
                ctrl.Init();
            }
        }

        public static void UpdateEntryStateCtrl(UserCtrlEntry ctrl, string sn, int result,string msg="")
        {
            if (ctrl.InvokeRequired)
            {
                ctrl.Invoke(new Action<UserCtrlEntry, string, int,string>(UpdateEntryStateCtrl), ctrl, sn, result,msg);
                return;
            }

            if (result == 0)
            {
                ctrl.Start(sn);
            }
            else if (result == 1)
            {
                ctrl.Pass(sn);
            }
            else if (result == 2)
            {
                ctrl.Fail(sn,msg);
            }
            else
            {
                ctrl.Init();
            }
        }
    }
}
