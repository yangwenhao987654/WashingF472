using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanApp.DAL.Entity
{
    public class ProductFormulaEntity
    {
        public int ID { get; set; }

        public string ProductType { get; set; }

        public string ProductName { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string ProductCode { get; set; }


        //供应商代码
        public string SupplierCode { get; set; }

        /// <summary>
        /// 条码长度
        /// </summary>
        public int BarcodeLength { get; set; }

        /// <summary>
        /// 条码匹配规则
        /// </summary>
        public string MatchRule { get; set; }

    }
}
