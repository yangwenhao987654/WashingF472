using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanApp.Migrations
{
    /// <inheritdoc />
    public partial class addPartNo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "PartCode",
                table: "tbProductFormula",
                type: "TEXT",
                maxLength: 50,
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PartCode",
                table: "tbProductFormula");
        }
    }
}
