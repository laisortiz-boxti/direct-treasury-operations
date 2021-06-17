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
        }
    }
}
