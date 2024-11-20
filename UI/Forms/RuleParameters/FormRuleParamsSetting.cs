using Microsoft.EntityFrameworkCore;
using ScanApp.DAL.DBContext;
using ScanApp.DAL.Entity;
using Sunny.UI;
using System.Data;

namespace UI.Forms.RuleParameters
{
    public partial class FormRuleParamsSetting : UIForm
    {
        public BarcodeRuleParameter Rule { get; set; }

        /// <summary>
        /// 当前规则的顺序
        /// </summary>
        public int Sequence { get; set; }


        /// <summary>
        /// 当前参数的ID
        /// </summary>
        public int RowId { get; set; }
        public FormRuleParamsSetting(int rowId )
        {
            InitializeComponent();
            RowId =rowId;
        }

        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            uiCheckBoxGroup_Time.Visible = cbx_date.Checked;
            tbx_Value.Enabled = !cbx_date.Checked;
        }

        private void uiCheckBox2_CheckedChanged(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void uiCheckBox3_CheckedChanged(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
            uiCheckBoxGroup_Feature.Visible = cbx_feature.Checked;
        }

        private BarcodeRuleParameter LoadRule(BarcodeRuleParameter rule)
        {
            string name = tbx_Name.Text;
            int.TryParse(tbx_Length.Text, out int length);
            if (cbx_date.Checked)
            {
                //时间
                rule.Type = ParamsTypeEnum.Time.ToString();
                rule.Format = tbx_Value.Text;
            }

            if (cbx_Serial.Checked)
            {
                rule.Type = ParamsTypeEnum.SerialNum.ToString();
                rule.Format = tbx_Value.Text;
            }

            if (cbx_feature.Checked)
            {
                rule.Type = ParamsTypeEnum.Feature.ToString();

                if (uiCheckBox_Pre.Checked)
                {
                    rule.Format = ParamsFeatureFormatType.Pre;
                }

                if (uiCheckBox_suffix.Checked)
                {
                    rule.Format = ParamsFeatureFormatType.Suffix;
                }

                if (uiCheckBox_Contain.Checked)
                {
                    rule.Format = ParamsFeatureFormatType.Contain;
                }
            }

            if (cbx_fullMatch.Checked)
            {
                rule.Type = ParamsTypeEnum.FullMatch.ToString();

                rule.Format = tbx_Value.Text;
            }
            rule.FixedValue = tbx_Value.Text;
            rule.Name = name;
            rule.Length = length;
            rule.NeedCheckLength = true;
            rule.IsRequired = true;
            Rule = rule;

            return rule;
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    BarcodeRuleParameter paramRow = db.tbRuleParameter.FirstOrDefault(r => r.Id == RowId);
                    if (paramRow == null)
                    {
                        UIMessageBox.ShowError("查询规则失败");
                        Close();
                        return;
                    }
                    paramRow=LoadRule(paramRow);
                    db.SaveChanges();
                    UIMessageBox.ShowInfo("修改成功");
                    Close();
                    return;
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"添加规则失败:\n{ex.Message} {ex.InnerException?.Message}");
            }
        }

        private void FormRuleParamsAdd_Load(object sender, EventArgs e)
        {
            LoadDetails();
        }

        private void ShowInfo(BarcodeRuleParameter row)
        {
            if (row==null)
            {
                return;
            }
            tbx_Name.Text =row.Name;
            tbx_Length.Text =row.Length.ToString();
            tbx_Value.Text = row.FixedValue;

            switch (row.Type)
            {
                case RuleParamsType.Time:
                    cbx_date.Checked = true;
                    //获取到当前选中的日期
                    ShowDateCheckBox(row.Format);
                    break;
                case RuleParamsType.Feature:
                    //获取到当前选中的特征格式
                    cbx_feature.Checked = true;
                    ShowFeatureCheckBox(row.Format);
                    break;
                case RuleParamsType.FullMatch:
                    cbx_fullMatch.Checked = true;
                    break;
                case RuleParamsType.SerialNum:
                    cbx_Serial.Checked = true;
                    break;
                default:
                    break;

            }
        }

        private void ShowDateCheckBox(string dateFormat)
        {
            switch (dateFormat)
            {
                case ParamsDateFormatType.yyyyMMdd:
                    cbx_date_yyyyMMdd.Checked = true;
                    break;
                case ParamsDateFormatType.yyMMdd:
                    cbx_Date_yyMMdd.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void ShowFeatureCheckBox(string featureFormat)
        {
            switch (featureFormat)
            {
                case ParamsFeatureFormatType.Pre:
                    uiCheckBox_Pre.Checked = true;
                    break;
                case ParamsFeatureFormatType.Suffix:
                    uiCheckBox_suffix.Checked = true;
                    break;
                case ParamsFeatureFormatType.Contain:
                    uiCheckBox_Contain.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void LoadDetails()
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    BarcodeRuleParameter row = db.tbRuleParameter.FirstOrDefault(r => r.Id == RowId);
                    if (row == null)
                    {
                        UIMessageBox.ShowError("查询参数失败");
                        Close();
                        return;
                    }
                    ShowInfo(row);
                    return;
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError($"添加规则失败:\n{ex.Message} {ex.InnerException?.Message}");
            }
        }

        private void uiCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_date_yyyyMMdd.Checked)
            {
                tbx_Length.Text = 8.ToString();
                tbx_Value.Text = "yyyyMMdd";
            }
        }

        private void uiCheckBox7_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_Date_yyMMdd.Checked)
            {
                tbx_Length.Text = 6.ToString();
                tbx_Value.Text = "yyMMdd";
            }
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
