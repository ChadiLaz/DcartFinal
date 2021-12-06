using Microsoft.EntityFrameworkCore.Migrations;

namespace DcartFinal.Data.Migrations
{
    public partial class AddedRowsToCartTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "MainImageURL",
                table: "Cart",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "Total",
                table: "Cart",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<decimal>(
                name: "UnitPrice",
                table: "Cart",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "MainImageURL",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "Total",
                table: "Cart");

            migrationBuilder.DropColumn(
                name: "UnitPrice",
                table: "Cart");
        }
    }
}
