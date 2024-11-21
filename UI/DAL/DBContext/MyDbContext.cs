using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using ScadaBase.DAL.Interceptor;
using ScanApp.DAL.Entity;

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
                var path = Application.StartupPath;
                DbPath = System.IO.Path.Join(path,"DB", "ScanData.db");
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
