using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DWZ_Scada.Forms.ProductFormula;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using ScanApp.DAL.DBContext;
using ScanApp.DAL.Entity;
using Sunny.UI;

namespace UI.Forms.BarcodeRules
{
    public partial class FormRulesQuery : UIForm
    {
        public FormRulesQuery()
        {
            InitializeComponent();
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            int index = dgv.SelectedIndex;

            if (index == -1)
            {
                return;
            }

            int RuleID = (int)dgv.Rows[index].Cells[0].Value;
            FormRulesSetting formRules = new FormRulesSetting(RuleID);
            formRules.ShowDialog();
        }

        private void FormRulesQuery_Load(object sender, EventArgs e)
        {
            SeleteRules();
        }

        private void SeleteRules()
        {
            using (MyDbContext db = new MyDbContext())
            {
                List<BarcodeRule> list = db.tbBarcodeRule.ToList();
                ShowRulesTable(list);
            }
        }

        private void ShowRulesTable(List<BarcodeRule> list)
        {
            
            dgv.Rows.Clear();
            if (!list.Any())
            {
                return;
            }

            dgv.SuspendLayout();
            foreach (BarcodeRule rule in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);
                row.Cells[0].Value = rule.Id;
                row.Cells[1].Value = rule.Name;
                dgv.Rows.Add(row);
            }
            dgv.ResumeLayout();
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            int index = dgv.SelectedIndex;

            if (index == -1)
            {
                return;
            }

            int RuleID = (int)dgv.Rows[index].Cells[0].Value;

            if(DeleteRule(RuleID))
            {
                SeleteRules();
            }
        }

        private bool DeleteRule(int ruleId)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    BarcodeRule rule = db.tbBarcodeRule.FirstOrDefault(r => r.Id == ruleId);
                    if (rule != null)
                    {
                        db.tbBarcodeRule.Remove(rule);
                        int i = db.SaveChanges();
                        UIMessageBox.ShowInfo("删除成功!");
                        return true;
                    }
                }
            }
            catch (Exception e)
            {
                UIMessageBox.ShowError($"删除失败: 此规则已被使用{e.Message}");
                return false;
            }

            return true;
        }

        private void OpenAddForm()
        {
            FormRulesAdd form = new FormRulesAdd();
            form.ShowDialog();
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            OpenAddForm();
            SeleteRules();
        }
    }
}
