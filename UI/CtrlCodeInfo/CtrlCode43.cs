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
    public partial class CtrlCode43 : UserControl
    {
        public CtrlCode43()
        {
            InitializeComponent();
        }

        public void Load(ProductFormulaEntity result)
        {
            tbx_code.Text = result.ProductCode;
            tbx_Spy.Text = result.SupplierCode;
        }

        public ProductFormulaEntity GetResult(ProductFormulaEntity result)
        {
            tbx_code.CheckLength("产品编号", 10);
            tbx_Spy.CheckLength("供应商号", 8);

            result.BarcodeType = CodeType.Code40;
            result.DateLength = 8;
            result.FixedValue1 = lbl_FixValue1.Text;
            result.PartCode = tbx_code.Text;
            result.SupplierCode = tbx_Spy.Text;
            return result;
        }
    }
}
