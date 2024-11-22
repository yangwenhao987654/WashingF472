using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ScanApp.DAL.Entity
{
    public class BarcodeRecordEntityConfig : IEntityTypeConfiguration<BarcodeRecordEntity>
    {
        public void Configure(EntityTypeBuilder<BarcodeRecordEntity> builder)
        {
            builder.ToTable("tbBarcodeRecord");
            builder.Property(r => r.ErrInfo).HasDefaultValue("").HasMaxLength(100).IsRequired(false);
            /* builder.Property(r => r.ScanTime).HasConversion(v => v.ToString("yyyy-MM-dd HH:mm:ss fff"),
                 v => DateTime.Parse(v)); // 存储为 ISO 8601 格式;*/
            builder.Property(r => r.ScanTime);

            builder.Property(r => r.Barcode).HasMaxLength(100).IsRequired(false);


            builder.Property(r => r.Result).HasDefaultValue(false).IsRequired(true);
            builder.Property(r => r.UseDateStr).HasMaxLength(20).IsRequired(false);


        }
    }
}
