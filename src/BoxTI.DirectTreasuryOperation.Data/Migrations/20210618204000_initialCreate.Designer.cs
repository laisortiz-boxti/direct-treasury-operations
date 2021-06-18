﻿// <auto-generated />
using System;
using BoxTI.DirectTreasuryOperation.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BoxTI.DirectTreasuryOperation.Data.Migrations
{
    [DbContext(typeof(DirectTreasuryContext))]
    [Migration("20210618204000_initialCreate")]
    partial class initialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 64)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("BoxTI.DirectTreasuryOperation.API.Models.Entities.DirectTreasuryOperations", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("varchar(767)");

                    b.Property<int>("InvestorCode")
                        .HasColumnType("int");

                    b.Property<decimal>("OperationAmount")
                        .HasPrecision(20, 10)
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("OperationDate")
                        .HasColumnType("date");

                    b.Property<double>("Quantity")
                        .HasColumnType("double");

                    b.Property<decimal>("TitleAmount")
                        .HasPrecision(20, 10)
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("TitleMaturityDate")
                        .HasColumnType("date");

                    b.Property<string>("TitleType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("DirectTreasuryOperations");
                });

            modelBuilder.Entity("BoxTI.DirectTreasuryOperation.API.Models.Entities.OperationsAmount", b =>
                {
                    b.Property<decimal>("AmountDifference")
                        .HasPrecision(20, 10)
                        .HasColumnType("decimal(18, 2)");

                    b.Property<DateTime>("FinalOperationDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("InitialOperationDate")
                        .HasColumnType("date");

                    b.HasKey("AmountDifference");

                    b.ToTable("OperationsAmount");
                });
#pragma warning restore 612, 618
        }
    }
}
