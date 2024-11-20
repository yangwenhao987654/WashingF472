using Microsoft.EntityFrameworkCore;
using ScanApp.DAL.DBContext;
using ScanApp.DAL.Entity;
using Sunny.UI;

namespace UI.Forms.RuleParameters
{
    public partial class FormRuleParamsAdd : UIForm
    {
        public BarcodeRuleParameter Rule { get; set; }

        /// <summary>
        /// 当前规则的顺序
        /// </summary>
        public int Sequence { get; set; }


        /// <summary>
        /// 当前规则的顺序
        /// </summary>
        public int RuleId { get; set; }
        public FormRuleParamsAdd(int ruleId, int sequence)
        {
            InitializeComponent();
            Sequence = sequence;

            RuleId = ruleId;
        }

        private void uiCheckBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uiCheckBox2_CheckedChanged(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        private void uiCheckBox3_CheckedChanged(object? sender, EventArgs e)
        {
            //throw new NotImplementedException();

        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            string name = tbx_Name.Text;
            int.TryParse(tbx_Length.Text, out int length);
            BarcodeRuleParameter rule = new BarcodeRuleParameter();
            if (uiRadioButton1.Checked)
            {
                //时间
                rule.Type = ParamsTypeEnum.Time.ToString();
                rule.Format = tbx_Value.Text;
            }

            if (uiRadioButton2.Checked)
            {
                rule.Type = ParamsTypeEnum.SerialNum.ToString();
                rule.Format = tbx_Value.Text;
            }

            if (uiRadioButton3.Checked)
            {
                rule.Type = ParamsTypeEnum.Feature.ToString();

                if (rb_Pre.Checked)
                {
                    rule.Format = "Pre";
                }

                if (rb_suffix.Checked)
                {
                    rule.Format = "Suffix";
                }

                if (rb_Contain.Checked)
                {
                    rule.Format = "Contain";
                }
            }

            if (uiRadioButton4.Checked)
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
            rule.Sequence = Sequence;

            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    db.tbRuleParameter.Attach(rule);
                    BarcodeRule row = db.tbBarcodeRule.Include(r => r.Parameters).FirstOrDefault(r => r.Id == RuleId);
                    if (row == null)
                    {
                        UIMessageBox.ShowError("查询规则失败");
                        Close();
                        return;
                    }

                    if (row.Parameters == null)
                    {
                        row.Parameters = new List<BarcodeRuleParameter>();
                    }
                    row.Parameters.Add(rule);
                    db.SaveChanges();
                    UIMessageBox.ShowInfo("添加成功");
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

        }

        private void uiCheckBox8_CheckedChanged(object sender, EventArgs e)
        {
          
        }

        private void uiCheckBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void uiRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            uiGroupBox_Date.Visible = uiRadioButton1.Checked;
            tbx_Value.Enabled = !uiRadioButton1.Checked;
        }

        private void uiRadioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void uiRadioButton3_CheckedChanged(object sender, EventArgs e)
        {
            uiGroupBox_Feature.Visible = uiRadioButton3.Checked;
        }

        private void uiRadioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (uiRadioButton6.Checked)
            {
                tbx_Length.Text = 6.ToString();
                tbx_Value.Text = "yyMMdd";
            }
        }

        private void uiRadioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (uiRadioButton5.Checked)
            {
                tbx_Length.Text = 8.ToString();
                tbx_Value.Text = "yyyyMMdd";
            }
        }
    }
}
