using Microsoft.Extensions.DependencyInjection;
using ScanApp.DAL.Entity;
using ScanApp.DAL.ExecuteSQL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DWZ_Scada.Forms.ProductFormula
{
    public partial class FormProductFormulaAdd : UIForm
    {
        public FormProductFormulaAdd()
        {
            InitializeComponent();

        }

        private IProductFormulaDAL productFormulaDAL;

        private void uiButton1_Click(object sender, EventArgs e)
        {
            ProductFormulaEntity productFormula = new ProductFormulaEntity();

            if (tbx_Code.Text.IsNullOrEmpty())
            {
                UIMessageBox.ShowError("产品编号不能为空");
                return;
            }

            if (tbx_PLCNo.Text.IsNullOrEmpty())
            {
                UIMessageBox.ShowError("PLC料号不能为空");
                return;
            }

            productFormula.ProductCode = tbx_Code.Text;
            productFormula.ProductName = tbxName.Text;
            productFormula.ProductType = tbx_Type.Text;

            List<ProductFormulaEntity> list = productFormulaDAL.SelectAllByProdCode(tbx_Code.Text);
            if (list.Any())
            {
                UIMessageBox.Show($"产品编号配方已经存在,请勿重复添加:[{tbx_Code.Text}]");
                return;
            }

            bool flag = productFormulaDAL.Insert(productFormula);
            if (flag)
            {
                UIMessageBox.Show("配方添加成功");
                this.Close();
            }
            else
            {
                UIMessageBox.ShowError("配方添加失败");
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductFormulaAdd_Load(object sender, EventArgs e)
        {
            productFormulaDAL = Global.ServiceProvider.GetRequiredService<IProductFormulaDAL>();
        }
    }
}
