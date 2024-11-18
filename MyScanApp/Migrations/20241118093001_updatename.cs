using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ScanApp.Migrations
{
    /// <inheritdoc />
    public partial class updatename : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbBarcodeParameter_tbBarcodeRule_BarcodeRuleId",
                table: "tbBarcodeParameter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbBarcodeParameter",
                table: "tbBarcodeParameter");

            migrationBuilder.RenameTable(
                name: "tbBarcodeParameter",
                newName: "tbRuleParameter");

            migrationBuilder.RenameIndex(
                name: "IX_tbBarcodeParameter_BarcodeRuleId",
                table: "tbRuleParameter",
                newName: "IX_tbRuleParameter_BarcodeRuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbRuleParameter",
                table: "tbRuleParameter",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbRuleParameter_tbBarcodeRule_BarcodeRuleId",
                table: "tbRuleParameter",
                column: "BarcodeRuleId",
                principalTable: "tbBarcodeRule",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_tbRuleParameter_tbBarcodeRule_BarcodeRuleId",
                table: "tbRuleParameter");

            migrationBuilder.DropPrimaryKey(
                name: "PK_tbRuleParameter",
                table: "tbRuleParameter");

            migrationBuilder.RenameTable(
                name: "tbRuleParameter",
                newName: "tbBarcodeParameter");

            migrationBuilder.RenameIndex(
                name: "IX_tbRuleParameter_BarcodeRuleId",
                table: "tbBarcodeParameter",
                newName: "IX_tbBarcodeParameter_BarcodeRuleId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_tbBarcodeParameter",
                table: "tbBarcodeParameter",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_tbBarcodeParameter_tbBarcodeRule_BarcodeRuleId",
                table: "tbBarcodeParameter",
                column: "BarcodeRuleId",
                principalTable: "tbBarcodeRule",
                principalColumn: "Id");
        }
    }
}
