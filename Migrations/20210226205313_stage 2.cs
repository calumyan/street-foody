using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class stage2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "VietameseName",
                table: "FoodDbSet",
                newName: "FoodVietameseName");

            migrationBuilder.RenameColumn(
                name: "EnglishName",
                table: "FoodDbSet",
                newName: "FoodEnglishName");

            migrationBuilder.RenameColumn(
                name: "CategoryVietameseName",
                table: "FoodCategoryDbSet",
                newName: "CategoryVietnameseName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "FoodVietameseName",
                table: "FoodDbSet",
                newName: "VietameseName");

            migrationBuilder.RenameColumn(
                name: "FoodEnglishName",
                table: "FoodDbSet",
                newName: "EnglishName");

            migrationBuilder.RenameColumn(
                name: "CategoryVietnameseName",
                table: "FoodCategoryDbSet",
                newName: "CategoryVietameseName");
        }
    }
}
