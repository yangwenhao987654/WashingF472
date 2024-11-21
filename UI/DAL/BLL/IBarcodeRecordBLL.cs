using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScanApp.DAL.Entity;
using UI.DAL.DAL;

namespace UI.DAL.BLL
{
    public interface IBarcodeRecordBLL
    {
        /// <summary>
        /// 判断条码是否存在
        /// </summary>
        /// <param name="barcode"></param>
        /// <returns></returns>
        public bool IsExist(string barcode);


        public bool Insert(BarcodeRecordEntity entity);


        public List<BarcodeRecordEntity> SelectByBarcode(string barcode);

        public List<BarcodeRecordEntity> SelectByUseDate(string useDate);

        public List<BarcodeRecordEntity> SelectByScanTime(DateTime startTime, DateTime endTime);
    }

    public class BarcodeRecordBLL:IBarcodeRecordBLL
    {

        private readonly IBarcodeRecordDAL _barcodeRecordDAL;

        public BarcodeRecordBLL(IBarcodeRecordDAL barcodeRecordDAL)
        {
            _barcodeRecordDAL = barcodeRecordDAL;
        }
        public bool IsExist(string barcode)
        {
           return _barcodeRecordDAL.SelectSingle(barcode) != null;
        }

        public bool Insert(BarcodeRecordEntity entity)
        {
           return  _barcodeRecordDAL.Insert(entity);
        }

        public List<BarcodeRecordEntity> SelectByBarcode(string barcode)
        {
            return _barcodeRecordDAL.SelectByBarcode(barcode);
        }

        public List<BarcodeRecordEntity> SelectByUseDate(string useDate)
        {
            return _barcodeRecordDAL.SelectByUseDate(useDate);
        }

        public List<BarcodeRecordEntity> SelectByScanTime(DateTime startTime, DateTime endTime)
        {
            return _barcodeRecordDAL.SelectByScanTime(startTime, endTime);
        }
    }
}
