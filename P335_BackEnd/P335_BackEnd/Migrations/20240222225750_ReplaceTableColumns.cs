using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace P335_BackEnd.Migrations
{
    /// <inheritdoc />
    public partial class ReplaceTableColumns : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "ProductsImages");

            migrationBuilder.DropColumn(
                name: "IsPrimary",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "Images",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SortOrder",
                table: "Images");

            migrationBuilder.AddColumn<int>(
                name: "SortOrder",
                table: "ProductsImages",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<bool>(
                name: "IsPrimary",
                table: "Images",
                type: "bit",
                nullable: false,
                defaultValue: false);
        }
    }
}
