using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DcartFinal.Data.Migrations
{
    public partial class Seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "DateAdded", "DateAvailable", "DateModified", "EAN", "Height", "ISBN", "JAN", "Length", "LengthClassId", "Location", "MPN", "MainImageURL", "ManufacturerId", "Minimum", "Model", "Points", "Price", "Quantity", "SKU", "Shipping", "SortOrder", "Status", "StockStatusId", "Subtract", "TaxClassId", "Title", "UPC", "Viewed", "Weight", "WeightClassId", "Width" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0m, null, null, 0m, 0, null, null, null, 0, 0, "Samsung", 0, 99m, 0, null, (short)0, 0, (short)0, 0, (short)0, 0, null, null, 0, 0m, 0, 0m },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0m, null, null, 0m, 0, null, null, null, 0, 0, "Fridge", 0, 99m, 0, null, (short)0, 0, (short)0, 0, (short)0, 0, null, null, 0, 0m, 0, 0m },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0m, null, null, 0m, 0, null, null, null, 0, 0, "tv", 0, 99m, 0, null, (short)0, 0, (short)0, 0, (short)0, 0, null, null, 0, 0m, 0, 0m },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, 0m, null, null, 0m, 0, null, null, null, 0, 0, "Pool Table", 0, 99m, 0, null, (short)0, 0, (short)0, 0, (short)0, 0, null, null, 0, 0m, 0, 0m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: 7);
        }
    }
}
