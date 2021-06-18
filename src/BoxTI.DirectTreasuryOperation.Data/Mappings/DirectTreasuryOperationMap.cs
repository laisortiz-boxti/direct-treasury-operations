using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.ComponentModel.DataAnnotations.Schema;

namespace BoxTI.DirectTreasuryOperation.Data.Mappings
{
    public class DirectTreasuryOperationMap : IEntityTypeConfiguration<DirectTreasuryOperations>
    {
        public void Configure(EntityTypeBuilder<DirectTreasuryOperations> builder)
        {
            builder.HasKey(d => d.Id);

            builder.Property(x => x.InvestorCode).IsRequired();
            
            builder.Property(x => x.OperationDate).HasColumnType("date").IsRequired();
            
            builder.Property(x => x.TitleType).IsRequired();

            builder.Property(x => x.TitleMaturityDate).HasColumnType("date").IsRequired();
            
            builder.Property(x => x.Quantity).IsRequired();
            
            builder.Property(x => x.TitleAmount).HasPrecision(20, 10).IsRequired();
            
            builder.Property(x => x.OperationAmount).HasPrecision(20, 10).IsRequired();
        }
    }
}
