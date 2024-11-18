using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanApp.DAL.Entity
{
    public class BarcodeRuleParameter
    {
        public int Id { get; set; }
        public string Name { get; set; } // 参数名称
        public int Length { get; set; } // 参数长度

        /// <summary>
        /// 匹配类型 1.时间  2.流水号 3.指定字符
        /// </summary>
        public string Type { get; set; }

        /// <summary>
        /// 匹配格式 时间类型，对应时间字符串的格式
        /// </summary>
        public string Format { get; set; }
        public string MatchPattern { get; set; } // 匹配正则表达式
        public string FixedValue { get; set; } // 固定值（可选）
        public bool IsRequired { get; set; } // 是否必需

        /// <summary>
        /// 进行长度校验
        /// </summary>
        public bool NeedCheckLength { get; set; } // 参数长度
    }
}
