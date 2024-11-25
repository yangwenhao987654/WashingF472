using Microsoft.Extensions.DependencyInjection;
using ScanApp.DAL.Entity;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using UI.BarcodeCheck;
using UI.CtrlCodeInfo;
using UI.DAL.DAL;

namespace DWZ_Scada.Forms.ProductFormula
{
    public partial class FormProductFormulaAdd : UIForm
    {
        public FormProductFormulaAdd()
        {
            InitializeComponent();

        }

        public int LastSelectIndex { get; set; } = -1;


        public int SelectedCodeType { get; set; } = -1;

        private IProductFormulaDAL productFormulaDAL;

        private void uiButton1_Click(object sender, EventArgs e)
        {
            ProductFormulaEntity productFormula = new ProductFormulaEntity();

            if (tbx_Code.Text.IsNullOrEmpty())
            {
                UIMessageBox.ShowError("产品编号不能为空");
                return;
            }

            productFormula.ProductCode = tbx_Code.Text;
            productFormula.ProductName = tbxName.Text;

            List<ProductFormulaEntity> list = productFormulaDAL.SelectAllByProdCode(tbx_Code.Text);
            if (list.Any())
            {
                UIMessageBox.Show($"产品编号配方已经存在,请勿重复添加:[{tbx_Code.Text}]");
                return;
            }

            if (!AddBarcodeInfo(productFormula))
            {
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

        private bool AddBarcodeInfo(ProductFormulaEntity entity)
        {
            bool result = false;
            try
            {
                switch (SelectedCodeType)
                {
                    case -1:
                        UIMessageBox.ShowError("请先选择条码类型");
                        break;
                    case CodeType.Code14:
                        ctrlCode14.GetResult(entity);
                        result = true;
                        break;
                    case CodeType.Code31:
                        ctrlCode31.GetResult(entity);
                        result = true;
                        break;
                    case CodeType.Code40:
                        ctrlCode40.GetResult(entity);
                        result = true;
                        break;
                    case CodeType.Code43:
                        ctrlCode43.GetResult(entity);
                        result = true;
                        break;
                    default:
                        throw new Exception("未支持的条码类型！！!");
                        break;
                }
            }
            catch (Exception e)
            {
                UIMessageBox.ShowError($"添加错误:{e.Message}");
                result = false;
            }
            return result;

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormProductFormulaAdd_Load(object sender, EventArgs e)
        {
            productFormulaDAL = Global.ServiceProvider.GetRequiredService<IProductFormulaDAL>();

            uiComboBox1.Items.Add(CodeType.Code14);
            uiComboBox1.Items.Add(CodeType.Code31);
            uiComboBox1.Items.Add(CodeType.Code40);
            uiComboBox1.Items.Add(CodeType.Code43);
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {

        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == -1 || uiComboBox1.SelectedIndex == LastSelectIndex)
            {
                return;
            }
            LastSelectIndex = uiComboBox1.SelectedIndex;
            int type = (int)uiComboBox1.SelectedItem;
            SelectedCodeType = type;
            foreach (Control ctrl in uiPanel1.Controls)
            {
                ctrl.Visible = false;
            }
            if (type == CodeType.Code31)
            {
                ctrlCode31.Visible = true;
            }
            if (type == CodeType.Code14)
            {
                ctrlCode14.Visible = true;
            }
            if (type == CodeType.Code43)
            {
                ctrlCode43.Visible = true;
            }
            if (type == CodeType.Code40)
            {
                ctrlCode40.Visible = true;
            }
        }

        private void ctrlCode40_Load(object sender, EventArgs e)
        {

        }
    }
}
