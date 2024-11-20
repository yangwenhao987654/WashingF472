using ScanApp.DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Validator
{
    public class BarcodeValidator
    {
        public bool Validate(string barcode, BarcodeRule rule, out string errorMessage)
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
    }
}
