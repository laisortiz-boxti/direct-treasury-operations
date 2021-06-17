using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoxTI.DirectTreasuryOperation.Data.Mappings
{
    public class OperationAmountMap : IEntityTypeConfiguration<OperationAmounts>
    {
        public void Configure(EntityTypeBuilder<OperationAmounts> builder)
        {
            builder.ToTable("OperationAmounts");
            
            builder.HasNoKey();

            builder.Property(x => x.AmountDifference).HasPrecision(20, 10).IsRequired();
            
            builder.Property(x => x.FinalOperationDate).HasColumnType("date").IsRequired();
            
            builder.Property(x => x.InitialOperationDate).HasColumnType("date").IsRequired();
        }
    }
}
