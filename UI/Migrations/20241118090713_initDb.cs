using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanApp.Migrations
{
    /// <inheritdoc />
    public partial class initDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "tbBarcodeRecord",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductId = table.Column<int>(type: "INTEGER", nullable: false),
                    ProductCode = table.Column<int>(type: "INTEGER", nullable: false),
                    Barcode = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true),
                    ErrInfo = table.Column<string>(type: "TEXT", maxLength: 100, nullable: true, defaultValue: ""),
                    UseDateStr = table.Column<string>(type: "TEXT", maxLength: 20, nullable: true),
                    UseTime = table.Column<DateTime>(type: "TEXT", nullable: false),
                    Result = table.Column<bool>(type: "INTEGER", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbBarcodeRecord", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbBarcodeRule",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbBarcodeRule", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "tbProductFormula",
                columns: table => new
                {
                    ID = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    ProductType = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    ProductName = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    ProductCode = table.Column<string>(type: "TEXT", maxLength: 50, nullable: true),
                    SupplierCode = table.Column<string>(type: "TEXT", nullable: true),
                    BarcodeLength = table.Column<int>(type: "INTEGER", nullable: false),
                    MatchRule = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbProductFormula", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "tbBarcodeParameter",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Name = table.Column<string>(type: "TEXT", nullable: true),
                    Length = table.Column<int>(type: "INTEGER", nullable: false),
                    MatchPattern = table.Column<string>(type: "TEXT", nullable: true),
                    FixedValue = table.Column<string>(type: "TEXT", nullable: true),
                    IsRequired = table.Column<bool>(type: "INTEGER", nullable: false),
                    NeedCheckLength = table.Column<bool>(type: "INTEGER", nullable: false),
                    BarcodeRuleId = table.Column<int>(type: "INTEGER", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tbBarcodeParameter", x => x.Id);
                    table.ForeignKey(
                        name: "FK_tbBarcodeParameter_tbBarcodeRule_BarcodeRuleId",
                        column: x => x.BarcodeRuleId,
                        principalTable: "tbBarcodeRule",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_tbBarcodeParameter_BarcodeRuleId",
                table: "tbBarcodeParameter",
                column: "BarcodeRuleId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "tbBarcodeParameter");

            migrationBuilder.DropTable(
                name: "tbBarcodeRecord");

            migrationBuilder.DropTable(
                name: "tbProductFormula");

            migrationBuilder.DropTable(
                name: "tbBarcodeRule");
        }
    }
}
