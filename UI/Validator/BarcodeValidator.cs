using ScanApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogTool;
using UI.BarcodeCheck;
using TouchSocket.Core;

namespace UI.Validator
{
    public class BarcodeValidator
    {
        private static bool Check(string barcode, BarcodeRule rule, out string errorMessage)
        {
            int currentIndex = 0;
            foreach (var param in rule.Parameters)
            {
                //TODO 条码参数类型校验
                switch (param.Type)
                {
                    case "":
                        break;
                }
                // 截取当前参数内容
                if (currentIndex + param.Length > barcode.Length)
                {
                    errorMessage = $"条码长度不足，无法匹配参数 {param.Name}";
                    return false;
                }

                string segment = barcode.Substring(currentIndex, param.Length);

                // 校验固定值
                if (!string.IsNullOrEmpty(param.FixedValue) && segment != param.FixedValue)
                {
                    errorMessage = $"参数 {param.Name} 固定值不匹配，期望：{param.FixedValue}，实际：{segment}";
                    return false;
                }

                // 校验正则
                if (!string.IsNullOrEmpty(param.MatchPattern) && !System.Text.RegularExpressions.Regex.IsMatch(segment, param.MatchPattern))
                {
                    errorMessage = $"参数 {param.Name} 格式不匹配";
                    return false;
                }

                currentIndex += param.Length; // 移动索引
            }

            errorMessage = null;
            return true;
        }

        public static BarcodeValidateResult Validate(string barcode, ProductFormulaEntity entity, string DateStr)
        {
            BarcodeValidateResult result = new BarcodeValidateResult();
            int currentIndex = 0;
            result.Err = "";
            result.IsSuccess = false;
            switch (entity.BarcodeType)
            {
                case CodeType.Code14:
                   result = CheckCode14(barcode,entity,DateStr);
                    break;
                case CodeType.Code31:
                    result =CheckCode31(barcode,entity,DateStr);
                    break;
                case CodeType.Code40:
                   result = CheckCode40(barcode,entity,DateStr);
                    break;
                case CodeType.Code43:
                   result = CheckCode43(barcode,entity,DateStr);
                    break;
                default:
                    result.Err = $"条码类型未定义";
                    return result;
            }
            return result;
        }

        private static BarcodeValidateResult CheckCode40(string barcode, ProductFormulaEntity entity, string DateStr)
        {
            BarcodeValidateResult result = new BarcodeValidateResult();
            result.Err = "";
            result.IsSuccess = false;
            if (barcode.Length!=40)
            {
                result.Err = $"长度不匹配,长度[{barcode.Length}]!=40";
                return result;
            }

            string SpyCode = barcode.Substring(0, 10);
            if (SpyCode != entity.SupplierCode)
            {
                result.Err = $"供应商代码不匹配";
                return result;
            }
            string fixValue = barcode.Substring(23, 1);
            if (fixValue != entity.FixedValue1)
            {
                result.Err = $"固定位不匹配";
                return result;
            }
            string dateStr = barcode.Substring(24, 6);
            if (dateStr != DateStr)
            {
                result.Err = $"日期不匹配";
                return result;
            }

            string part = barcode.Substring(30, 10);
            if (part != entity.PartCode)
            {
                result.Err = $"零件号不匹配";
                return result;
            }
            //TODO 获取穴位号
            int acqNum = GetAcqNum(barcode,10,3);
            if (acqNum==0)
            {
                result.Err = "穴位号错误";
                return result;
            }
            result.AcupointNumber = acqNum;
            result.IsSuccess =true;
            return result;
        }

        private static int GetAcqNum(string input, int startIndex, int length)
        {
            int num = 0;
            try
            {
                string value = input.Substring(startIndex, length);
                bool flag = int.TryParse(value, out num);
            }
            catch (Exception e)
            {
                LogMgr.Instance.Error($"解析穴位号错误:{e.Message}\n{e.StackTrace}");
            }

            return num;
        }

        private static BarcodeValidateResult CheckCode43(string barcode, ProductFormulaEntity entity, string dateStr)
        {
            BarcodeValidateResult result = new BarcodeValidateResult();
            result.Err = "";
            result.IsSuccess = false;
            if (barcode.Length != 43)
            {
                result.Err = $"长度不匹配,长度[{barcode.Length}]!=43";
                return result;
            }

            string code = barcode.Substring(1, 10);
            if (code != entity.ProductCode)
            {
                result.Err = $"产品编号不匹配";
                return result;
            }

            string SpyCode = barcode.Substring(12, 8);
            if (SpyCode != entity.SupplierCode)
            {
                result.Err = $"供应商代码不匹配";
                return result;
            }
            string resDateStr = barcode.Substring(26, 8);
            if (dateStr != resDateStr)
            {
                result.Err = $"日期不匹配";
                return result;
            }

            int acqNum = GetAcqNum(barcode, 21, 4);
            if (acqNum == 0)
            {
                result.Err = "穴位号错误";
                return result;
            }
            result.IsSuccess = true;
            result.AcupointNumber = acqNum;
            return result;
        }
        private static BarcodeValidateResult CheckCode31(string barcode, ProductFormulaEntity entity, string DateStr)
        {
            BarcodeValidateResult result = new BarcodeValidateResult();
            result.Err = "";
            result.IsSuccess = false;
            if (barcode.Length != 31)
            {
                result.Err = $"长度不匹配,长度[{barcode.Length}]!=31";
                return result;
            }
            string code = barcode.Substring(1, 4);
            if (code!=entity.ProductCode)
            {
                result.Err = $"产品编号不匹配";
                return result;
            }

            string SpyCode = barcode.Substring(6, 6);
            if (SpyCode != entity.SupplierCode)
            {
                result.Err = $"供应商代码不匹配";
                return result;
            }
            string dateStr = barcode.Substring(16, 6);
            if (dateStr != DateStr)
            {
                result.Err = $"日期不匹配";
                return result;
            }
            int acqNum = GetAcqNum(barcode, 13, 2);
            if (acqNum == 0)
            {
                result.Err = "穴位号错误";
                return result;
            }
            result.IsSuccess = true;
            result.AcupointNumber = acqNum;
            return result;
        }

        private static BarcodeValidateResult CheckCode14(string barcode, ProductFormulaEntity entity, string DateStr)
        {
            BarcodeValidateResult result = new BarcodeValidateResult();
            result.Err = "";
            result.IsSuccess = false;
            if (barcode.Length != 14)
            {
                result.Err = $"长度不匹配,长度[{barcode.Length}]!=14";
                return result;
            }

            string fixValue1 = barcode.Substring(0, 2);
            if (fixValue1!=entity.FixedValue1)
            {
                result.Err = $"固定位不匹配";
                return result;
            }
            string dateStr = barcode.Substring(3, 6);
            if (dateStr != DateStr)
            {
                result.Err = $"日期不匹配";
                return result;
            }
            int acqNum = GetAcqNum(barcode, 2, 1);
            if (acqNum == 0)
            {
                result.Err = "穴位号错误";
                return result;
            }
            result.IsSuccess = true;
            result.AcupointNumber = acqNum;
            return result;
        }
    }

    /// <summary>
    /// 条码检验结构
    /// </summary>
    public class BarcodeValidateResult
    {
        public bool IsSuccess { get; set; }

        public string Err { get; set; }

        public int AcupointNumber { get; set; }
    }
}
