using Microsoft.Extensions.DependencyInjection;
using ScanApp.DAL.Entity;
using ScanApp.DAL.ExecuteSQL;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using ScanApp.DAL.DBContext;
using UI.Forms.RuleParameters;

namespace DWZ_Scada.Forms.ProductFormula
{
    public partial class FormRulesAdd : UIForm
    {
        public FormRulesAdd()
        {
            InitializeComponent();
        }

        public int RuleId { get; set; } = -1;

        public Dictionary<int, int> SeqMap = new Dictionary<int, int>();

        private void uiButton1_Click(object sender, EventArgs e)
        {
            if (SaveDB())
            {
                UIMessageBox.Show("保存成功");
            }
        }

        private bool SaveDB()
        {
            try
            {
                string name = tbxName.Text;
                using (MyDbContext db = new MyDbContext())
                {
                    BarcodeRule rule = db.tbBarcodeRule.Include(r => r.Parameters).FirstOrDefault(r => r.Id == RuleId);
                    if (rule == null)
                    {
                        UIMessageBox.ShowError("查询规则错误");
                        Close();
                        return false;
                    }
                    else
                    {
                        rule.Name = name;
                        List<BarcodeRuleParameter> parameters = rule.Parameters;
                        //更新序号
                        foreach (var item in parameters)
                        {
                            int id = item.Id;
                            if (SeqMap.TryGetValue(id, out int seq))
                            {
                                if (item.Sequence == seq)
                                {
                                    continue;
                                }
                                item.Sequence = seq;
                            }
                            else
                            {
                                UIMessageBox.ShowError("获取排序失败");
                                return false;
                            }
                        }
                        db.SaveChanges();
                        return true;
                    }
                }
            }
            catch (Exception exception)
            {
                UIMessageBox.ShowError($"保存失败:{exception.Message}");
            }
            return false;
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRulesAdd_Load(object sender, EventArgs e)
        {

        }

        private void uiButton3_Click(object sender, EventArgs e)
        {
            if (RuleId == -1)
            {
                try
                {
                    //先建立规则
                    string ruleName = tbxName.Text;
                    if (ruleName == "")
                    {
                        UIMessageBox.ShowError("请输入规则名称");
                        return;
                    }
                    //规则放在这里建立好像并不合适  第一条添加完成之后才建立？
                    using (MyDbContext db = new MyDbContext())
                    {
                        BarcodeRule rule = new BarcodeRule();
                        rule.Name = ruleName;
                        db.tbBarcodeRule.Add(rule);
                        db.SaveChanges();
                        RuleId = rule.Id;
                    }
                }
                catch (Exception exception)
                {
                    UIMessageBox.ShowError("添加规则错误:" + exception.Message);
                    return;
                }
            }

            if (RuleId == -1)
            {
                return;
            }
            //规则添加的入口
            int count = dgv.RowCount;
            //RuleID 
            FormRuleParamsAdd form = new FormRuleParamsAdd(RuleId, count + 1);
            form.ShowDialog();

            List<BarcodeRuleParameter> parameters = null;
            using (MyDbContext db = new MyDbContext())
            {
                BarcodeRule rule = db.tbBarcodeRule.Include(r => r.Parameters).FirstOrDefault(r => r.Id == RuleId);
                parameters = rule.Parameters;
            }
            ShowRuleTable(parameters);
        }

        private void ShowRuleTable(List<BarcodeRuleParameter> list)
        {
            dgv.Rows.Clear();

            if (list == null)
            {
                return;
            }
            dgv.SuspendLayout();
            foreach (var item in list)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgv);
                row.Cells[0].Value = item.Sequence;
                row.Cells[1].Value = item.Name;
                row.Cells[2].Value = item.Length;
                row.Cells[3].Value = item.Type;
                row.Cells[4].Value = item.FixedValue;
                dgv.Rows.Add(row);
            }
            dgv.ResumeLayout();

            dgv.ClearSelection();  //可以清除选中的单元格状态

            //这样能取消选中状态
            dgv.CurrentCell = null;  //index=-1
            //设置-1 会直接返回 不会执行
            //dgv.ClearSelection();
        }


        private void uiButton6_Click(object sender, EventArgs e)
        {
            int index = dgv.SelectedIndex;
            if (index == -1)
            {
                return;
            }
            try
            {
                int id = (int)dgv.Rows[index].Cells[5].Value;
                using (MyDbContext db = new MyDbContext())
                {
                    BarcodeRule rule = db.tbBarcodeRule.Include(r => r.Parameters).FirstOrDefault(r => r.Id == RuleId);
                    if (rule != null)
                    {
                        BarcodeRuleParameter row = rule.Parameters.Where(r => r.Id == id).FirstOrDefault();
                        if (row == null)
                        {
                            return;
                        }
                        rule.Parameters.Remove(row);
                        ShowRuleTable(rule.Parameters);
                        rule.Parameters = UpdateSeq(rule.Parameters);
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                UIMessageBox.ShowError("删除规则错误:" + ex.Message);
            }
        }

        private List<BarcodeRuleParameter> UpdateSeq(List<BarcodeRuleParameter> parameters)
        {
            foreach (var item in parameters)
            {
                int id = item.Id;
                if (SeqMap.TryGetValue(id, out int seq))
                {
                    if (item.Sequence == seq)
                    {
                        continue;
                    }
                    item.Sequence = seq;
                }
                else
                {
                    UIMessageBox.ShowError("获取排序失败");
                }
            }
            return parameters;
        }

        private void ReflashRules()
        {
            List<BarcodeRuleParameter> parameters = null;
            using (MyDbContext db = new MyDbContext())
            {
                BarcodeRule rule = db.tbBarcodeRule.Include(r => r.Parameters).FirstOrDefault(r => r.Id == RuleId);
                parameters = rule.Parameters;
            }
            ShowRuleTable(parameters);
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            //获取当前选中的行
            //获取当前选中的行

            //判断是不是最后一行 最后一行不能下移
            int curIndex = dgv.SelectedIndex;
            int count = dgv.Rows.Count;
            if (curIndex >= count - 1 || curIndex==-1)
            {
                return;
            }

            try
            {
                int curID = (int)dgv.Rows[curIndex].Cells[5].Value;

                int seq1 = (int)dgv.Rows[curIndex].Cells[0].Value + 1;
                //dgv.Rows[curIndex].Cells[0].Value = seq1 + 1;
                int next = curIndex + 1;
                int seq2 = (int)dgv.Rows[next].Cells[0].Value - 1;
                int nextId = (int)dgv.Rows[next].Cells[5].Value;
                //dgv.Rows[next].Cells[0].Value = seq2 - 1;
                SeqMap[curID] = seq1;
                SeqMap[nextId] = seq2;
                SaveDB();
                ReflashRules();
            }
            catch (Exception exception)
            {
                UIMessageBox.ShowError($"下移错误:{exception.Message}");
            }
        }

        private void uiButton4_Click(object sender, EventArgs e)
        {
            //判断是不是第一行 第一行不能上移
            int curIndex = dgv.SelectedIndex;
            if (curIndex <= 0)
            {
                return;
            }
            try
            {
                int curID = (int)dgv.Rows[curIndex].Cells[5].Value;

                int seq1 = (int)dgv.Rows[curIndex].Cells[0].Value - 1;
                //dgv.Rows[curIndex].Cells[0].Value = seq1 + 1;
                int last = curIndex - 1;
                int seq2 = (int)dgv.Rows[last].Cells[0].Value + 1;
                int lastID = (int)dgv.Rows[last].Cells[5].Value;
                //dgv.Rows[next].Cells[0].Value = seq2 - 1;
                SeqMap[curID] = seq1;
                SeqMap[lastID] = seq2;
                SaveDB();
                ReflashRules();
                dgv.SelectedIndex = curIndex - 1;
            }
            catch (Exception exception)
            {
                UIMessageBox.ShowError($"上移错误:{exception.Message}");
            }
        }

        private void uiButton7_Click(object sender, EventArgs e)
        {
            int index = dgv.SelectedIndex;
            if (index == -1)
            {
                return;
            }

            int id = (int)dgv.Rows[index].Cells[5].Value;
            FormRuleParamsSetting form = new FormRuleParamsSetting(id);
            form.ShowDialog();
            ReflashRules();
        }
    }
}
