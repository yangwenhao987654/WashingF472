using ScanApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UI.BarcodeCheck;

namespace UI.Validator
{
    public class BarcodeValidator
    {
        private static bool Check(string barcode, BarcodeRule rule, out string errorMessage)
        {
            int currentIndex = 0;
            foreach (var param in rule.Parameters)
            {
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

        public static bool Validate(string barcode, ProductFormulaEntity entity, string DateStr,out string err)
        {
            int currentIndex = 0;
            err = "";
            bool result = false;
            switch (entity.BarcodeType)
            {
                case CodeType.Code14:
                   result = CheckCode14(barcode,entity,DateStr,out err);
                    break;
                case CodeType.Code31:
                    result =CheckCode31(barcode,entity,DateStr,out err);
                    break;
                case CodeType.Code40:
                   result = CheckCode40(barcode,entity,DateStr,out err);
                    break;
                case CodeType.Code43:
                   result = CheckCode43(barcode,entity,DateStr,out err);
                    break;
                default:
                    err = $"条码类型未定义";
                    return false;
            }
            return result;
        }

        private static bool CheckCode40(string barcode, ProductFormulaEntity entity, string DateStr, out string err)
        {
            err = "";
            if (barcode.Length!=40)
            {
                err = $"长度不匹配,长度[{barcode.Length}]!=40";
                return false;
            }

            string SpyCode = barcode.Substring(0, 10);
            if (SpyCode != entity.SupplierCode)
            {
                err = $"供应商代码不匹配";
                return false;
            }
            string fixValue = barcode.Substring(23, 1);
            if (fixValue != entity.FixedValue1)
            {
                err = $"固定位不匹配";
                return false;
            }
            string dateStr = barcode.Substring(24, 6);
            if (dateStr != DateStr)
            {
                err = $"日期不匹配";
                return false;
            }

            string part = barcode.Substring(30, 10);
            if (part != entity.PartCode)
            {
                err = $"零件号不匹配";
                return false;
            }
            return true;
        }
        private static bool CheckCode43(string barcode, ProductFormulaEntity entity, string DateStr, out string err)
        {
            err = "";
            if (barcode.Length != 43)
            {
                err = $"长度不匹配,长度[{barcode.Length}]!=43";
                return false;
            }

            string code = barcode.Substring(1, 10);
            if (code != entity.ProductCode)
            {
                err = $"产品编号不匹配";
                return false;
            }

            string SpyCode = barcode.Substring(12, 8);
            if (SpyCode != entity.SupplierCode)
            {
                err = $"供应商代码不匹配";
                return false;
            }
            string dateStr = barcode.Substring(26, 8);
            if (dateStr != DateStr)
            {
                err = $"日期不匹配";
                return false;
            }
            return true;
        }
        private static bool CheckCode31(string barcode, ProductFormulaEntity entity, string DateStr, out string err)
        {
            err = "";
            if (barcode.Length != 31)
            {
                err = $"长度不匹配,长度[{barcode.Length}]!=31";
                return false;
            }
            string code = barcode.Substring(1, 4);
            if (code!=entity.ProductCode)
            {
                err = $"产品编号不匹配";
                return false;
            }

            string SpyCode = barcode.Substring(6, 6);
            if (SpyCode != entity.SupplierCode)
            {
                err = $"供应商代码不匹配";
                return false;
            }
            string dateStr = barcode.Substring(16, 6);
            if (dateStr != DateStr)
            {
                err = $"日期不匹配";
                return false;
            }
            return true;
        }

        private static bool CheckCode14(string barcode, ProductFormulaEntity entity, string DateStr, out string err)
        {
            err = "";
            if (barcode.Length != 14)
            {
                err = $"长度不匹配,长度[{barcode.Length}]!=14";
                return false;
            }

            string fixValue1 = barcode.Substring(0, 2);
            if (fixValue1!=entity.FixedValue1)
            {
                err = $"固定位不匹配";
                return false;
            }
            string dateStr = barcode.Substring(3, 6);
            if (dateStr != DateStr)
            {
                err = $"日期不匹配";
                return false;
            }
            return true;
        }
    }
}
