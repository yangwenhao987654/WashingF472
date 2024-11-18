using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanApp.DAL.Entity
{
    /// <summary>
    /// 设备报警信息表
    /// </summary>
    public class BarcodeRecordEntity
    {
        public int Id { get; set; }

        /// <summary>
        /// 产品ID
        /// </summary>
        public int ProductId { get; set; }

        /// <summary>
        /// 产品编号
        /// </summary>
        public int ProductCode { get; set; }

        /// <summary>
        /// 条码内容 
        /// </summary>
        public string Barcode { get; set; }

        /// <summary>
        /// 错误信息 
        /// </summary>
        public string ErrInfo { get; set; }

        /// <summary>
        /// 生产日期 YYYY-MM-dd
        /// </summary>
        public string UseDateStr { get; set; }

        /// <summary>
        /// 生产时间
        /// </summary>
        public DateTime UseTime { get; set; }


        public bool Result { get; set; }

    }
}
