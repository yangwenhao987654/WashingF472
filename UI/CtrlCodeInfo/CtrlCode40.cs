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
    public partial class CtrlCode40 : UserControl
    {
        public CtrlCode40()
        {
            InitializeComponent();
        }

        public void Load(ProductFormulaEntity result)
        {
            tbx_Spy.Text = result.SupplierCode;
            tbx_PartNo.Text = result.PartCode;

            tbxAcq.Text = result.AcupointNumber;
            if (string.IsNullOrEmpty(result.AcupointNumber))
            {
                tbxAcq.Text = "114";
            }
        }

        public ProductFormulaEntity GetResult(ProductFormulaEntity result)
        {
            tbx_PartNo.CheckLength("零件号", 10);
            tbx_Spy.CheckLength("供应商号",10);
            tbxAcq.CheckLength("穴位号", 3);

            result.AcupointNumber = tbxAcq.Text;
            result.BarcodeType = CodeType.Code40;
            result.DateLength = 6;
            result.FixedValue1 = lbl_FixValue1.Text;
            result.PartCode = tbx_PartNo.Text;
            result.SupplierCode = tbx_Spy.Text;
            return result;
        }
    }

 
}
