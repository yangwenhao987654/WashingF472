using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LogTool;
using Microsoft.EntityFrameworkCore;
using ScanApp.DAL.DBContext;
using ScanApp.DAL.Entity;

namespace UI.DAL.DAL
{
    public interface IBarcodeRecordDAL
    {
        public BarcodeRecordEntity SelectSingle(string barcode);

        public bool Insert(BarcodeRecordEntity dto);

        public List<BarcodeRecordEntity> SelectByBarcode(string barcode);

        public List<BarcodeRecordEntity> SelectByUseDate(string useDate);

        public List<BarcodeRecordEntity> SelectByScanTime(DateTime startTime, DateTime endTime);

        List<BarcodeRecordEntity> SelectByResult(DateTime startTime, DateTime endTime, bool isGood);
    }

    public class BarcodeRecordDAL : IBarcodeRecordDAL
    {
        public BarcodeRecordEntity SelectSingle(string barcode)
        {
            using (MyDbContext db = new MyDbContext())
            {
                BarcodeRecordEntity result = db.tbBarcode.AsNoTracking().FirstOrDefault(r => r.Barcode == barcode);
                return result;
            }
        }

        public bool Insert(BarcodeRecordEntity dto)
        {
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    db.tbBarcode.Attach(dto);
                    db.tbBarcode.Add(dto);
                    db.SaveChanges();
                }

                return true;
            }
            catch (Exception e)
            {
                LogMgr.Instance.Error($"插入barcode记录错误:{e.Message}\n {e.StackTrace}");
                return false;
            }
        }

        public List<BarcodeRecordEntity> SelectByBarcode(string barcode)
        {
            List<BarcodeRecordEntity> list =null;
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    list =db.tbBarcode.AsNoTracking().Where(r=>r.Barcode==barcode).ToList();
                }
                return list;
            }
            catch (Exception e)
            {
                LogMgr.Instance.Error($"查询条码[{barcode}]记录错误:{e.Message}\n {e.StackTrace}");
                return list;
            }
        }

        public List<BarcodeRecordEntity> SelectByUseDate(string useDate)
        {
            List<BarcodeRecordEntity> list = null;
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    list = db.tbBarcode.AsNoTracking().Where(r => r.UseDateStr == useDate).ToList();
                }
                return list;
            }
            catch (Exception e)
            {
                LogMgr.Instance.Error($"查询日期[{useDate}]记录错误:{e.Message}\n {e.StackTrace}");
                return list;
            }
        }

        public List<BarcodeRecordEntity> SelectByScanTime(DateTime startTime, DateTime endTime)
        {
            List<BarcodeRecordEntity> list = null;
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    list = db.tbBarcode.Where(r => r.ScanTime >= startTime &&r.ScanTime<=endTime).ToList();
                }
                return list;
            }
            catch (Exception e)
            {
                LogMgr.Instance.Error($"查询日期:[{startTime}]=>[{endTime}]记录错误:{e.Message}\n {e.StackTrace}");
                return list;
            }
        }

        public List<BarcodeRecordEntity> SelectByResult(DateTime startTime, DateTime endTime, bool isGood)
        {
            List<BarcodeRecordEntity> list = null;
            try
            {
                using (MyDbContext db = new MyDbContext())
                {
                    list = db.tbBarcode.Where(r => r.ScanTime >= startTime && r.ScanTime <= endTime &&r.Result==isGood).ToList();
                }
                return list;
            }
            catch (Exception e)
            {
                LogMgr.Instance.Error($"查询日期:[{startTime}]=>[{endTime}]记录错误:{e.Message}\n {e.StackTrace}");
                return list;
            }
        }
    }
}
