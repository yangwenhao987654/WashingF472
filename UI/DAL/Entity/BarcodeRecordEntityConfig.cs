using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanApp.DAL.Entity
{
    public class BarcodeRecordEntityConfig : IEntityTypeConfiguration<BarcodeRecordEntity>
    {
        public void Configure(EntityTypeBuilder<BarcodeRecordEntity> builder)
        {
            builder.ToTable("tbBarcodeRecord");
            builder.Property(r => r.ErrInfo).HasDefaultValue("").HasMaxLength(100).IsRequired(false);
            builder.Property(r => r.UseTime);

            builder.Property(r => r.Barcode).HasMaxLength(100).IsRequired(false);


            builder.Property(r => r.Result).HasDefaultValue(false).IsRequired(true);
            builder.Property(r => r.UseDateStr).HasMaxLength(20).IsRequired(false);


        }
    }
}
