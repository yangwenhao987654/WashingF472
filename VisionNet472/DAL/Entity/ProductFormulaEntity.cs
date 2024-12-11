using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace ScanApp.DAL.Entity
{

    [SugarTable("tbProductFormula")]// 指定表名
    public class ProductFormulaEntity
    {

        [SugarColumn(IsPrimaryKey = true, IsIdentity = true)] // 主键，自增列
        public int ID { get; set; }

        /// <summary>
        /// 产品类型
        /// </summary>
        public string ProductType { get; set; }

        /// <summary>
        /// 产品名称
        /// </summary>
        public string ProductName { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public string ProductCode { get; set; }


        /// <summary>
        /// 零件号
        /// </summary>
        public string PartCode { get; set; }


        //供应商代码
        public string SupplierCode { get; set; }

        /// <summary>
        /// 条码长度
        /// </summary>
        public int BarcodeLength { get; set; }

        /// <summary>
        /// 穴位号
        /// </summary>
        public string AcupointNumber { get; set; }

        public string SerialNum { get; set; }

        /// <summary>
        /// 日期格式 6位和8位
        /// </summary>
        public int DateLength { get; set; }


        public string FixedValue1 { get; set; }


        /// <summary>
        /// 条码类型
        /// </summary>
        public int BarcodeType { get; set; }

        /// <summary>
        /// 条码匹配规则
        /// </summary>
        public string MatchRule { get; set; }

    }
}
