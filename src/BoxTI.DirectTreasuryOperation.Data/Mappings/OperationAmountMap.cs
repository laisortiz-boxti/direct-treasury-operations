﻿using BoxTI.DirectTreasuryOperation.API.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BoxTI.DirectTreasuryOperation.Data.Mappings
{
    public class OperationAmountMap : IEntityTypeConfiguration<OperationAmount>
    {
        public void Configure(EntityTypeBuilder<OperationAmount> builder)
        {
            builder.ToTable("OperationAmount");
            
            builder.HasNoKey();

            builder.Property(x => x.AmountDifference).HasPrecision(20, 10).IsRequired();
            
            builder.Property(x => x.FinalOperationDate).HasColumnType("date").IsRequired();
            
            builder.Property(x => x.IniitalOperationDate).HasColumnType("date").IsRequired();
        }
    }
}
