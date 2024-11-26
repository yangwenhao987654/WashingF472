using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DWZ_Scada;
using LogTool;
using Microsoft.Extensions.Configuration;
using ScadaBase.DAL.Interceptor;
using ScanApp.DAL.Entity;
using System.IO;

namespace ScanApp.DAL.DBContext
{
    public class MyDbContext : DbContext
    {


        public DbSet<ProductFormulaEntity> tbProductFormula { get; set; }

        public DbSet<BarcodeRecordEntity> tbBarcode { get; set; }

        public DbSet<BarcodeRuleParameter> tbRuleParameter{ get; set; }


        public DbSet<BarcodeRule> tbBarcodeRule{ get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                base.OnConfiguring(optionsBuilder);
                string filePath = SystemParams.Instance.DBFilePath;
                if (!File.Exists(filePath))
                {
                    var path = Application.StartupPath;
                    DbPath = System.IO.Path.Join(path, "DB", "ScanData.db");
                    LogMgr.Instance.Debug($"打开DB:{filePath}失败，\n使用默认DB:{DbPath}");
                }
                else
                {
                    DbPath = filePath;
                    LogMgr.Instance.Debug($"使用指定DB:{DbPath}");
                }
                DbContextOptionsBuilder builder = optionsBuilder.UseSqlite($"Data Source={DbPath}")
                    .AddInterceptors(new MyDbCommandInterceptor())
                    .EnableSensitiveDataLogging();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
         
        }

        public string DbPath { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
