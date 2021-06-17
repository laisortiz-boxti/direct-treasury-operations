using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoxTI.DirectTreasuryOperation.Data.Mappings
{
    public class DirectTreasuryOperationMap : IEntityTypeConfiguration<DirectTreasuryOperations>
    {
        public void Configure(EntityTypeBuilder<DirectTreasuryOperations> builder)
        {
            builder.ToTable("DirectTreasuryOperations");
            
            builder.HasKey(d => d.Id);
            
            builder.Property(x => x.BondAmount).HasPrecision(20, 10).IsRequired();
            
            builder.Property(x => x.InvestorCode).IsRequired();
            
            builder.Property(x => x.Quantity).IsRequired();
            
            builder.Property(x => x.OperationAmount).HasPrecision(20, 10).IsRequired();
            
            builder.Property(x => x.BondAmount).HasPrecision(20, 10).IsRequired();
            
            builder.Property(x => x.OperationDate).HasColumnType("date").IsRequired();
            
            builder.Property(x => x.BondMaturityDate).HasColumnType("date").IsRequired();
        }
    }
}
