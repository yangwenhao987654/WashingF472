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
        /// 产品编号
        /// </summary>
        public string ProductCode { get; set; }


        /// <summary>
        /// 穴位号
        /// </summary>
        public int AcupointNumber { get; set; }

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
        /// 扫码时间
        /// </summary>
        public DateTime ScanTime { get; set; }


        public bool Result { get; set; }

    }
}
