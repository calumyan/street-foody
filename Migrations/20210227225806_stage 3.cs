using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class stage3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FoodVietameseName",
                table: "FoodDbSet",
                newName: "FoodVietnameseName");

            migrationBuilder.InsertData(
                table: "StreetVendorDbSet",
                columns: new[] { "VendorID", "AverageRating", "Description", "PhoneNumber", "PhotoUrl", "PriceRange", "RatingList", "StandEnglishName", "StandVietnameseName", "VendorName" },
                values: new object[,]
                {
                    { "1", 0.0, null, null, null, null, null, null, "Uncle Myles's Bahn Mi", null },
                    { "2", 0.0, null, null, null, null, null, null, "Aunt Andie's Bahn Mi", null },
                    { "3", 0.0, null, null, null, null, null, null, "Aunt Carrie's Bahn Mi", null },
                    { "4", 0.0, null, null, null, null, null, null, "Aunt Lucy's Bahn Mi", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "StreetVendorDbSet",
                keyColumn: "VendorID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "StreetVendorDbSet",
                keyColumn: "VendorID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "StreetVendorDbSet",
                keyColumn: "VendorID",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "StreetVendorDbSet",
                keyColumn: "VendorID",
                keyValue: "4");

            migrationBuilder.RenameColumn(
                name: "FoodVietnameseName",
                table: "FoodDbSet",
                newName: "FoodVietameseName");
        }
    }
}
