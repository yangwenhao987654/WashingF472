using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Extensions.Configuration;
using ScadaBase.DAL.Entity;
using ScadaBase.DAL.Interceptor;

namespace ScadaBase.DAL.DBContext
{
    public class MyDbContext : DbContext
    {

        public DbSet<OpUser> OpUsers { get; set; }

        public DbSet<Role> Roles { get; set; }

        public DbSet<ProductFormulaEntity> tbProductFormula { get; set; }

        public DbSet<DeviceAlarmEntity> tbDeviceAlarms { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var config = new ConfigurationBuilder()
                .AddJsonFile("appSettings.json")
                .Build();
            base.OnConfiguring(optionsBuilder);
            var path = Application.StartupPath;
            DbPath = System.IO.Path.Join(path, "ScanData.db");
            optionsBuilder.UseSqlite($"Data Source={DbPath}")
                .AddInterceptors(new MyDbCommandInterceptor())
                .EnableSensitiveDataLogging();
        }

        public string DbPath { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
        }
    }
}
