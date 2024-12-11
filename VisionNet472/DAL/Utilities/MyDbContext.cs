using SqlSugar;
using System;
using System.IO;
using System.Windows.Forms;
using LogTool;

namespace ScanApp.DAL.DBContext
{
    public class MyDbContext
    {
        public static string DbPath  =  Path.Combine(Application.StartupPath,"DB","WashingDB");

        private static SqlSugarClient _db;

        public static SqlSugarClient Instance
        {
            get
            {
                if (_db == null)
                {
                    _db = new SqlSugarClient(new ConnectionConfig
                    {
                        ConnectionString = $"Data Source={DbPath}.sqlite;Version=3;",
                        DbType = DbType.Sqlite,
                        IsAutoCloseConnection = true
                    });

                    // SQL日志输出
                    _db.Aop.OnLogExecuted = (sql,pars) =>
                    {
                        LogMgr.Instance.AddSQLLog(($"Executed SQL: {sql}"));
                    };
                    _db.Aop.OnLogExecuting = (sql, pars) =>
                    {
                        LogMgr.Instance.AddSQLLog(($"Executing SQL: {sql}"));
                    };
                }
                return _db;
            }
        }
    }
}
