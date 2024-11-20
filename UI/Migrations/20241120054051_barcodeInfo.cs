using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanApp.Migrations
{
    /// <inheritdoc />
    public partial class barcodeInfo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "AcupointNumber",
                table: "tbProductFormula",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "BarcodeType",
                table: "tbProductFormula",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DateLength",
                table: "tbProductFormula",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FixedValue1",
                table: "tbProductFormula",
                type: "TEXT",
                maxLength: 50,
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SerialNum",
                table: "tbProductFormula",
                type: "TEXT",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AcupointNumber",
                table: "tbProductFormula");

            migrationBuilder.DropColumn(
                name: "BarcodeType",
                table: "tbProductFormula");

            migrationBuilder.DropColumn(
                name: "DateLength",
                table: "tbProductFormula");

            migrationBuilder.DropColumn(
                name: "FixedValue1",
                table: "tbProductFormula");

            migrationBuilder.DropColumn(
                name: "SerialNum",
                table: "tbProductFormula");
        }
    }
}
