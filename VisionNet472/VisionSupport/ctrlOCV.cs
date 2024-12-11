
using System;
using System.Collections.Generic;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using PaddleOCRSharp_Vpro;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using DWZ_Scada;
using LogTool;

namespace AutoTF.UserCtrls
{

    public partial class ctrlOCV : UserControl
    {

        Stopwatch stopwatch = new Stopwatch();

        Stopwatch s1 = new Stopwatch();

        Stopwatch s2 = new Stopwatch();
        Stopwatch s5 = new Stopwatch();

        public object mylock = new object();

        public CogToolBlock TB;

        /// <summary>
        /// VPP初始化完成
        /// </summary>
        public bool IsVppInitFinish;
        public string VPPPath;
        public ctrlOCV()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception e)
            {
               
            }
        }

        /// <summary>
        /// 初始化图像处理VPP
        /// </summary>
        /// <param name="vppPath"></param>
        /// <returns></returns>
        public bool InitVpro(string vppPath)
        {
            if (string.IsNullOrEmpty(vppPath))
            {
                throw new Exception("VPP路径为空!!!");
            }
            if (vppPath == VPPPath)
            {
                return IsVppInitFinish;
            }
            try
            {
                //释放之前的ToolBlock工具
                if (TB != null)
                {
                    TB.Dispose();
                    GC.Collect();
                    Thread.Sleep(20);
                }
                VPPPath = vppPath;
                TB = CogSerializer.LoadObjectFromFile(vppPath) as CogToolBlock;
                IsVppInitFinish = true;
                return true;
            }
            catch (Exception e)
            {
                IsVppInitFinish = false;
                throw new Exception($"初始化VPP失败:  错误信息：{e.Message} \n 路径:{vppPath}");
            }
        }

        private void uiButton1_Click(object sender, EventArgs e)
        {
            try
            {
                if (TB == null)
                {
                    MessageBox.Show(this.ParentForm, "加载Vpp错误");
                    return;
                }
                FormEditVPP formEditVpp = new FormEditVPP(TB, Global.VppPath);
                formEditVpp.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                if (ex.InnerException != null)
                {
                    MessageBox.Show(ex.InnerException.Message);
                }
            }
        }

        private void uiButton3_Click(object sender, EventArgs e)
        {

        }

        public void TestPhoto()
        {
            if (TB != null)
            {
                TB.Run();
            }
        }

        private void DisplayDeal(ICogRecord record, bool isOK)
        {
            try
            {
                if (record != null)
                {
                    cogDisplayControl1.cogRecordDisplay1.Record = null;
                    cogDisplayControl1.cogRecordDisplay1.Image = null;
                    cogDisplayControl1.cogRecordDisplay1.InteractiveGraphics.Clear();
                    cogDisplayControl1.cogRecordDisplay1.StaticGraphics.Clear();
                    //cogDisplayControl1.cogRecordDisplay1.Image = tb.Outputs["OutputImage"].Value as CogImage8Grey;

                    cogDisplayControl1.cogRecordDisplay1.Record = record;
                    //SaveImageToQueue(tb.Outputs["OutputImage"].Value as CogImage8Grey, Convert.ToUInt64(Global.CurrentDsyCode), isOK);
                    cogDisplayControl1.cogRecordDisplay1.AutoFit = true;
                    //是否保存图片
                    /* if (SystemParams.Instance.EnableSaveImage)
                     {
                         SaveImageToQueue(cogDisplayControl1.cogRecordDisplay1.CreateContentBitmap(Cognex.VisionPro.Display.CogDisplayContentBitmapConstants.Display, null, 0), Convert.ToUInt64(Global.CurrentDsyCode), isOK);
                     }*/
                }
            }
            catch (Exception e)
            {
                LogMgr.Instance.Error("存图错误:" + e.Message);
            }
        }

        // 删除旧的图像文件方法
        private void DeleteOldImageFiles(string directoryPath, int maxImageCount)
        {
            try
            {
                // 获取目录下的所有图像文件
                string[] imageFiles = Directory.GetFiles(directoryPath, "*.bmp");

                // 如果图像文件数量超过设定的最大数量
                if (imageFiles.Length > maxImageCount)
                {
                    // 按文件创建时间排序
                    Array.Sort(imageFiles, (x, y) => String.CompareOrdinal(File.GetCreationTime(x).ToString(CultureInfo.InvariantCulture), File.GetCreationTime(y).ToString(CultureInfo.CurrentCulture)));

                    // 删除多余的文件，保留最新的 maxImageCount 个文件
                    for (int i = 0; i < imageFiles.Length - maxImageCount; i++)
                    {
                        File.Delete(imageFiles[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                // 处理删除文件失败的异常
                LogMgr.Instance.Error("Failed to delete old image files: " + ex.Message);
            }
        }

        public void SaveNGImageFile(string oldfilePath, string dsyName)
        {
            try
            {
                string filePath = "Pic" + "\\NG\\" + DateTime.Now.ToString("yyyy-MM-dd") + $"\\{dsyName}";
                if (!Directory.Exists(filePath))
                {
                    Directory.CreateDirectory(filePath);
                }
                //Copy 把oldfilePath的图片Copy到filePath下
                if (File.Exists(oldfilePath))
                {
                    string fileName = Path.GetFileName(oldfilePath);
                    string newFilePath = Path.Combine(filePath, fileName);

                    File.Copy(oldfilePath, newFilePath, true);
                }
            }
            catch (Exception ex)
            {
                LogMgr.Instance.Error($"保存NG图片错误,图片路径:{oldfilePath},溶媒：{dsyName}");
            }
        }

        /// <summary>
        /// 相机实时
        /// </summary>
        /// <param name="record"></param>
        /// <param name="tool"></param>
        /// <param name="s"></param>
        private void CameraLive(CogRecordDisplay record, CogToolBlock tool, bool s)
        {
            record.StaticGraphics.Clear();
            record.InteractiveGraphics.Clear();
            record.Image = null;
            record.Fit(true);
            try
            {
                if (s)
                {
                    record.StartLiveDisplay(((CogAcqFifoTool)tool.Tools["CogAcqFifoTool1"]).Operator);
                }
                else
                {
                    record.StopLiveDisplay();
                }
                record.Fit(true);
                record.AutoFit = true;
            }
            catch(Exception e)
            {
                MessageBox.Show($"实时取像出现错误，请打开视觉设置查看相机配置是否正确！\n异常信息:{e.Message}");
                LogMgr.Instance.Error($"实时取像出现错误，请打开视觉设置查看相机配置是否正确！\n异常信息:{e.Message}");
            }
        }

        private void ctrlOCV_Load(object sender, EventArgs e)
        {
            try
            {
                InitCogDispalyUI();
                cogDisplayControl1.ButtonDoubleClick += cogDisplayControl1_DoubleClick;
                //启动文件自动删除服务
                /*if (Global.IsRunTimeMode)
                {
                    //初步确定是这个类导致的问题 这个类里面引用了Cognex.VisionPro.ImageFile.dll
                    ImageSaveQueue.gInit();
                    ImageFolderCleanupService.gInit();
                }*/
            }
            catch (Exception ex)
            {
                //throw new Exception("加载OCR组件错误:" + ex.Message);
            }
        }


        private void cogDisplayControl1_DoubleClick()
        {
            SetCogDisplayMaximum();
        }

        /// <summary>
        /// 显示CogDisplay相机控件
        /// </summary>
        private void InitCogDispalyUI()
        {
            cogDisplayControl1.txt1.Text = "AI输液袋检测视觉";
        }

        private void cogDisplayControl1_Load(object sender, EventArgs e)
        {

        }

        private void cogDisplayControl1_DoubleClick(object sender, EventArgs e)
        {

        }

        private void ctrlOCV_DoubleClick(object sender, EventArgs e)
        {

        }

        private void SetCogDisplayMaximum()//最大化显示窗体
        {
            FormCustom popupForm = new FormCustom(cogDisplayControl1);
            //cogDisplayControl1.ButtonDoubleClick -= cogDisplayControl1_DoubleClick;
            popupForm.CustomFormClosed += ClosedHandler;
            popupForm.ShowDialog();

        }

        private void ClosedHandler(object sender, EventArgs e)
        {
            panel1.Controls.Add(cogDisplayControl1);
           // cogDisplayControl1.ButtonDoubleClick += cogDisplayControl1_DoubleClick;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_DoubleClick(object sender, EventArgs e)
        {
            SetCogDisplayMaximum();
        }

        private void uiButton5_Click(object sender, EventArgs e)
        {
            CameraLive(cogDisplayControl1.cogRecordDisplay1, TB, true);
        }

        private void uiButton2_Click(object sender, EventArgs e)
        {
            TriggerVisionHandle();
           // LogMgr.Instance.Info($"用户:[{SystemParams.Instance.Op}] 执行VPP运行！ [{Path.GetFileName(Global.VppBasePath)}]");
        }

        public void UpdateResult(string msg)
        {
            rtbx_Msg.Invoke(new Action(() =>
            {
                //listBox1.Items.Add($" NG 耗时:{stopwatch.Elapsed}");
                rtbx_Msg.Text =msg;
                //listBox1.Items.Add(DateTime.Now.ToString() + "视觉NG");
            }));
        }

        public bool TriggerVisionHandle()
        {
            LogMgr.Instance.Info("开始视觉处理");
            UpdateResult("开始拍照");
            bool result = false;
            stopwatch.Restart();

            //s1 VPP运行总耗时
            s1.Restart();
            string errMsg = "";
            bool f = false;
            Stopwatch sw2 = Stopwatch.StartNew();
            //TB.Outputs["ImagePath"].Value = "";
            TB.Run();
            sw2.Stop();
            LogMgr.Instance.Debug($" TB.Run 耗时:{sw2.Elapsed.TotalMilliseconds} ms");
            CogToolResultConstants statusResult = TB.RunStatus.Result;
            if (statusResult == CogToolResultConstants.Error)
            {
                errMsg = TB.RunStatus.Message;
                LogMgr.Instance.Error("错误:" + errMsg);
            }
            Stopwatch sw = Stopwatch.StartNew();
            ICogRecord record = TB.CreateLastRunRecord().SubRecords[0];
            Task.Run(() => { DisplayDeal(record, true); });
            sw.Stop();
            LogMgr.Instance.Debug($"存图 耗时:{sw.Elapsed.TotalMilliseconds} ms");
            s1.Stop();
            LogMgr.Instance.Debug($"TB handle 耗时:{s1.Elapsed.TotalMilliseconds} ms");

    
            stopwatch.Stop();
            string res = result ? "OK" : "NG";
           
            UpdateResult($"{res}:[{stopwatch.Elapsed.TotalSeconds}] {errMsg}");
            
            if (!result)
            {
                LogMgr.Instance.Error("OCR识别失败" + errMsg);
                //保存NG图片
                string path = "";
                string prodName = "产品1";
                //Task.Run(() => { SaveNGImageFile(path, prodName); });
            }
            LogMgr.Instance.Info($"视觉处理完成 VPP总耗时:[{s1.Elapsed.TotalMilliseconds}]ms  TB.RUN耗时:[{s2.Elapsed.TotalMilliseconds}]ms  OCR识别:[{s5.Elapsed.TotalMilliseconds}]ms");
            return result;
        }

        private void 复制ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // 检查是否有选中的文本
            if (!string.IsNullOrEmpty(rtbx_Msg.SelectedText))
            {
                Clipboard.SetText(rtbx_Msg.SelectedText); // 将选中内容复制到剪贴板
            }
            else
            {
                
            }
        }
    }
}
