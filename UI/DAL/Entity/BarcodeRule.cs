using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanApp.DAL.Entity
{
    public class BarcodeRule
    {
        public int Id { get; set; }
        public string Name { get; set; } // 规则名称
        public List<BarcodeRuleParameter> Parameters { get; set; } // 参数列表
    }
}
