using ScanApp.DAL.Entity;
using UI.BarcodeCheck;
using UI.Extend;

namespace UI.CtrlCodeInfo
{
    public partial class CtrlCode31 : UserControl
    {
        public CtrlCode31()
        {
            InitializeComponent();
        }

        public void Load(ProductFormulaEntity result)
        {
            tbx_Spy.Text = result.SupplierCode;
            tbx_Code.Text = result.ProductCode;
        }

        public ProductFormulaEntity GetResult(ProductFormulaEntity result)
        {
            tbx_Code.CheckLength("产品编号",4);
            tbx_Spy.CheckLength("供应商号", 6);
            result.BarcodeLength = 31;
            result.BarcodeType = CodeType.Code31;
            result.ProductCode = tbx_Code.Text;
            result.SupplierCode = tbx_Spy.Text;
            return result;
        }
    }
}
