using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UtilUIYwh.ControlWrapper
{
    public class ControlWrapper
    {
        private readonly Control _control;

        public event EventHandler ShowCalled;

        public ControlWrapper(Control ctrl)
        {
            _control = ctrl;
        }

        public void Show(EventHandler eventHandler)
        {
            _control.Show();
            ShowCalled = eventHandler;
            ShowCalled?.Invoke(_control,EventArgs.Empty);
        }
    }
}
