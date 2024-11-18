using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanApp.DAL.Entity
{
    public class BarcodeRuleEntityConfig : IEntityTypeConfiguration<BarcodeRule>
    {
        public void Configure(EntityTypeBuilder<BarcodeRule> builder)
        {
            builder.ToTable("tbBarcodeRule");
           


        }
    }
}
