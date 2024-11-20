using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScanApp.DAL.Entity;
using UI.BarcodeCheck;
using UI.Extend;

namespace UI.CtrlCodeInfo
{
    public partial class CtrlCode14 : UserControl
    {
        public CtrlCode14()
        {
            InitializeComponent();
        }

        public void Load(ProductFormulaEntity result)
        {
            tbx_FixValue1.Text = result.FixedValue1;
        }

        public ProductFormulaEntity GetResult(ProductFormulaEntity result)
        {
            tbx_FixValue1.CheckLength("固定位", 2);
       
            result.BarcodeType = CodeType.Code14;
            result.DateLength = 8;
            result.FixedValue1 = tbx_FixValue1.Text;
            result.DateLength = 6;
       
            return result;
        }
    }
}
