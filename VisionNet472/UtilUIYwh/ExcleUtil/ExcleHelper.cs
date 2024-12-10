using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LogTool;

namespace SJTU_UI.ExcleUtil
{
    public class ExcleHelper
    {
        public static bool DataGridViewToCSV(DataGridView dgv)
        {
            if (dgv.Rows.Count==0)
            {
                MessageBox.Show("没有可导出的数据","提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return false;
            }
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 0;
            saveFileDialog.RestoreDirectory = true;
            saveFileDialog.CreatePrompt =true;
            saveFileDialog.FileName = null;
            saveFileDialog.Title = "保存";
            if (saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                Stream stream = saveFileDialog.OpenFile();
                StreamWriter sw= new StreamWriter(stream,System.Text.Encoding.GetEncoding(-0));
                string strLine = "";
                try
                {
                    //表头
                    for (int i = 0; i < dgv.ColumnCount; i++)
                    {

                        if (i>0)
                        {
                            strLine += ",";
                        }

                        strLine += dgv.Columns[i].HeaderText;
                    }

                    strLine.Remove(strLine.Length - 1);
                    sw.WriteLine(strLine);
                    strLine = "";
                    for (int j = 0; j < dgv.Rows.Count; j++)
                    {

                        strLine = "";
                        int colCount = dgv.Columns.Count;
                        for (int k = 0; k < colCount; k++)
                        {
                            if (k>0 && k < colCount)
                            {
                                strLine += ",";
                            }

                            if (dgv.Rows[j].Cells[k].Value==null)
                            {
                                strLine += "";
                            }
                            else
                            {
                                string cell = dgv.Rows[j].Cells[k].Value.ToString().Trim();
                                cell = cell.Replace("\"", "\"\"");
                                strLine += cell;
                            }
                        }
                        sw.WriteLine(strLine);
                    }
                    sw.Close();
                    stream.Close();
                    LogMgr.Instance.Info($"数据导出成功: 路径=>{saveFileDialog.FileName.ToString()}");
                    MessageBox.Show("导出成功");
                }
                catch (Exception e)
                {
                   LogMgr.Instance.Error("导出错误:"+e.Message);
                   MessageBox.Show("导出错误:" + e.Message);
                   return false;
                }
            }
            return true;
        }
    }
}
