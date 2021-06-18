using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BoxTI.DirectTreasuryOperation.Data.Migrations
{
    public partial class initialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DirectTreasuryOperations",
                columns: table => new
                {
                    Id = table.Column<string>(type: "varchar(767)", nullable: false),
                    InvestorCode = table.Column<int>(type: "int", nullable: false),
                    OperationDate = table.Column<DateTime>(type: "date", nullable: false),
                    TitleType = table.Column<string>(type: "text", nullable: false),
                    TitleMaturityDate = table.Column<DateTime>(type: "date", nullable: false),
                    Quantity = table.Column<double>(type: "double", nullable: false),
                    TitleAmount = table.Column<decimal>(type: "decimal(18, 2)", precision: 20, scale: 10, nullable: false),
                    OperationAmount = table.Column<decimal>(type: "decimal(18, 2)", precision: 20, scale: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DirectTreasuryOperations", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OperationsAmount",
                columns: table => new
                {
                    AmountDifference = table.Column<decimal>(type: "decimal(18, 2)", precision: 20, scale: 10, nullable: false),
                    InitialOperationDate = table.Column<DateTime>(type: "date", nullable: false),
                    FinalOperationDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OperationsAmount", x => x.AmountDifference);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DirectTreasuryOperations");

            migrationBuilder.DropTable(
                name: "OperationsAmount");
        }
    }
}
