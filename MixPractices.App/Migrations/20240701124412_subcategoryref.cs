using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MixPractices.App.Migrations
{
    /// <inheritdoc />
    public partial class subcategoryref : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_ProductCategories_categoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "categoryId",
                table: "Products",
                newName: "subcategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_categoryId",
                table: "Products",
                newName: "IX_Products_subcategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_SubCategories_subcategoryId",
                table: "Products",
                column: "subcategoryId",
                principalTable: "SubCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Products_SubCategories_subcategoryId",
                table: "Products");

            migrationBuilder.RenameColumn(
                name: "subcategoryId",
                table: "Products",
                newName: "categoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Products_subcategoryId",
                table: "Products",
                newName: "IX_Products_categoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Products_ProductCategories_categoryId",
                table: "Products",
                column: "categoryId",
                principalTable: "ProductCategories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
