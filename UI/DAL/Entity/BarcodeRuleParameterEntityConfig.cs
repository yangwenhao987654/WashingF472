using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScanApp.DAL.Entity
{
    public class BarcodeRuleParameterEntityConfig : IEntityTypeConfiguration<BarcodeRuleParameter>
    {
        public void Configure(EntityTypeBuilder<BarcodeRuleParameter> builder)
        {
            builder.ToTable("tbRuleParameter");
            //builder.Property(r => r.ErrInfo).HasDefaultValue("").HasMaxLength(100).IsRequired(false);
            //builder.Property(r => r.ScanTime);

            builder.Property(r => r.MatchPattern).HasMaxLength(100).IsRequired(false);


            builder.Property(r => r.Format).HasMaxLength(100).IsRequired(false);
            builder.Property(r => r.FixedValue).HasMaxLength(100).IsRequired(false);


        }
    }
}
