using System.IO.Ports;
using CommunicationUtilYwh.Device;
using DWZ_Scada.ctrls.LogCtrl;
using DWZ_Scada.Forms.ProductFormula;
using DWZ_Scada.UIUtil;
using LogTool;
using Microsoft.Extensions.DependencyInjection;
using ScanApp.DAL.DBContext;
using ScanApp.DAL.Entity;
using Sunny.UI;
using UI.BarcodeCheck;
using UI.DAL.BLL;
using UI.Forms.BarcodeRules;
using UI.Validator;

namespace DWZ_Scada.Pages.StationPages.OP10
{
    public partial class PageOP10 : UIPage
    {

        private readonly Action _clearAlarmDelegate;

        private Scanner_RS232 scanner;


        private static PageOP10 _instance;
        public static PageOP10 Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (typeof(PageOP10))
                    {
                        if (_instance == null)
                        {
                            _instance = new PageOP10();
                        }
                    }
                }
                return _instance;
            }
        }

        public int SelectCodeType { get; set; } = -1;

        public List<ProductFormulaEntity> list { get; set; } = new List<ProductFormulaEntity>();

        public ProductFormulaEntity SelectProduct { get; set; }

        private IBarcodeRecordBLL barcodeRecordBLL;

        private PageOP10()
        {
            InitializeComponent();
            _instance = this;
            barcodeRecordBLL = Global.ServiceProvider.GetRequiredService<IBarcodeRecordBLL>();
        }

        private async void Page_Load(object sender, EventArgs e)
        {
            //LogMgr.Instance.SetCtrl(listViewEx_Log1);
            LogMgr.Instance.Debug("打开扫码对比软件");

            //OP10MainFunc.Instance.StartAsync();

            myLogCtrl1.BindingControl = uiPanel1;
            Mylog.Instance.Init(myLogCtrl1);

            await Task.Run(async () =>
            {
                using (MyDbContext db = new MyDbContext())
                {
                    list = db.tbProductFormula.ToList();
                }
            });
            uiComboBox1.DataSource = list;
            uiComboBox1.DisplayMember = "ProductName";

            SerialPort port = new SerialPort("COM1");
            scanner = new Scanner_RS232(port);
            bool isOpen = scanner.Open();
            if (!isOpen)
            {
                UIMessageBox.ShowError("扫码枪串口打开失败");
            }

        }


        private void Instance_OnEntryStateChanged(string sn, int result, string msg = "")
        {
            MyUIControler.UpdateEntryStateCtrl(userCtrlEntry1, sn, result, msg);
        }


        private void uiLabel1_Click(object sender, EventArgs e)
        {

        }

        private void PageOP10_FormClosing(object sender, FormClosingEventArgs e)
        {
            LogMgr.Instance.Info("关闭OP10-HttpServer");
            if (!OP10MainFunc.IsInstanceNull)
            {
                OP10MainFunc.Instance?.Dispose();
            }
            LogMgr.Instance.Info("关闭OP10程序");
            _instance = null;
            //调用 Close() 方法,先进入  FormClosing 事件 ，之后再调用Designer类的Dispose
        }


        private void uiButton2_Click(object sender, EventArgs e)
        {
            FormRulesQuery form = new FormRulesQuery();
            form.ShowDialog();
        }

        private void uiComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (uiComboBox1.SelectedIndex == -1)
            {
                return;
            }

            SelectProduct = uiComboBox1.SelectedItem as ProductFormulaEntity;
            if (SelectProduct == null)
            {
                UIMessageBox.ShowInfo("获取产品信息错误");
                return;
            }

            #region 清除原内容

            tbx_Spy.Text = "";
            tbx_Code.Text = "";
            tbx_CodeType.Text = "";
            tbx_DateFormat.Text = "";
            tbx_Part.Text = "";
            tbx_FixValue1.Text = "";
            #endregion

            //TODO 根据条码类型解析产品
            switch (SelectProduct.BarcodeType)
            {
                case CodeType.Code14:
                    tbx_FixValue1.Text = SelectProduct.FixedValue1;
                    tbx_DateFormat.Text = "yyMMdd";
                    break;
                case CodeType.Code31:
                    tbx_Spy.Text = SelectProduct.SupplierCode;
                    tbx_DateFormat.Text = "yyMMdd";
                    break;
                case CodeType.Code40:
                    tbx_Spy.Text = SelectProduct.SupplierCode;
                    tbx_Part.Text = SelectProduct.PartCode;
                    tbx_DateFormat.Text = "yyMMdd";
                    break;
                case CodeType.Code43:
                    tbx_Spy.Text = SelectProduct.SupplierCode;
                    tbx_DateFormat.Text = "yyyyMMdd";
                    break;
                default:
                    UIMessageBox.ShowError("未知的条码类型");
                    return;
                    break;
            }
            SelectCodeType = SelectProduct.BarcodeType;
            //获取当前选中项的信息
            tbx_CodeType.Text = $"{SelectCodeType}位码";
            tbx_Code.Text = $"{SelectProduct.ProductCode}";

            //清空其他内容
        }

        private void uiButton1_Click_1(object sender, EventArgs e)
        {
            if (SelectProduct == null)
            {
                UIMessageBox.ShowError("请先选择产品");
                return;
            }
            try
            {
                string input = tbx_Input.Text;
                DateTime dt = uiDatePicker1.Value;
                string dateStr = dt.ToString(tbx_DateFormat.Text);
                BarcodeValidateResult result = new BarcodeValidateResult();
                if (input!="")
                {
                    result = BarcodeValidator.Validate(input, SelectProduct, dateStr);
                    if (result.IsSuccess)
                    {
                        //TODO 重码判定
                        if (barcodeRecordBLL.IsExist(input))
                        {
                            Mylog.Instance.Error($"[{input}]重码");
                        }
                        //TODO 插入数据
                        Mylog.Instance.Info($"[{input}]校验成功");
                    }
                    else
                    {
                        Mylog.Instance.Error($"[{input}]校验失败,{result.Err}");
                    }
                }
                else
                {
                    result.IsSuccess =false;
                    result.Err = "扫码为空";
                    Mylog.Instance.Error($"[{input}]校验失败,{result.Err}");
                }
                BarcodeRecordEntity entity = new BarcodeRecordEntity();
                entity.Barcode = input;
                entity.AcupointNumber = result.AcupointNumber;
                if (result.IsSuccess)
                {
                    entity.ErrInfo = "扫码成功";
                }
                else
                {
                    entity.ErrInfo = result.Err;
                }
                entity.Result = result.IsSuccess;
                entity.ScanTime =DateTime.Now;
                entity.UseDateStr = dt.ToString("yyyy-MM-dd");
                entity.ProductCode = SelectProduct.ProductCode;
                bool b = barcodeRecordBLL.Insert(entity);
                Mylog.Instance.Debug($"[{input}]保存成功 {b}");
            }
            catch (Exception exception)
            {
                UIMessageBox.ShowError($"校验异常:{exception.Message}");
            }
        }

        private async void uiButton3_Click(object sender, EventArgs e)
        {
            string result = await Task.Run(async () =>
            {
                scanner.Trigger();

                string result = scanner.GetResult();
                return result;
            });

            tbx_Input.Text = result;
        }
    }
}
