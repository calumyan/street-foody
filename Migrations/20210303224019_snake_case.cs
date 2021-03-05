using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class snake_case : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategoryDbSet_FoodDbSet_FoodID",
                table: "FoodCategoryDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategoryDbSet_StreetVendorDbSet_StreetVendorVendorID",
                table: "FoodCategoryDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodDbSet_StreetVendorDbSet_StreetVendorVendorID",
                table: "FoodDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_VendorHoursDbSet",
                table: "VendorHoursDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StreetVendorDbSet",
                table: "StreetVendorDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodDbSet",
                table: "FoodDbSet");

            migrationBuilder.DropPrimaryKey(
                name: "PK_FoodCategoryDbSet",
                table: "FoodCategoryDbSet");

            migrationBuilder.RenameTable(
                name: "VendorHoursDbSet",
                newName: "vendor_hours_db_set");

            migrationBuilder.RenameTable(
                name: "StreetVendorDbSet",
                newName: "street_vendor_db_set");

            migrationBuilder.RenameTable(
                name: "FoodDbSet",
                newName: "food_db_set");

            migrationBuilder.RenameTable(
                name: "FoodCategoryDbSet",
                newName: "food_category_db_set");

            migrationBuilder.RenameColumn(
                name: "Location",
                table: "vendor_hours_db_set",
                newName: "location");

            migrationBuilder.RenameColumn(
                name: "VendorID",
                table: "vendor_hours_db_set",
                newName: "vendor_id");

            migrationBuilder.RenameColumn(
                name: "StartTime",
                table: "vendor_hours_db_set",
                newName: "start_time");

            migrationBuilder.RenameColumn(
                name: "EndTime",
                table: "vendor_hours_db_set",
                newName: "end_time");

            migrationBuilder.RenameColumn(
                name: "VendorHoursInfo",
                table: "vendor_hours_db_set",
                newName: "vendor_hours_info");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "street_vendor_db_set",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "VendorName",
                table: "street_vendor_db_set",
                newName: "vendor_name");

            migrationBuilder.RenameColumn(
                name: "StandVietnameseName",
                table: "street_vendor_db_set",
                newName: "stand_vietnamese_name");

            migrationBuilder.RenameColumn(
                name: "StandEnglishName",
                table: "street_vendor_db_set",
                newName: "stand_english_name");

            migrationBuilder.RenameColumn(
                name: "RatingList",
                table: "street_vendor_db_set",
                newName: "rating_list");

            migrationBuilder.RenameColumn(
                name: "PriceRange",
                table: "street_vendor_db_set",
                newName: "price_range");

            migrationBuilder.RenameColumn(
                name: "PhotoUrl",
                table: "street_vendor_db_set",
                newName: "photo_url");

            migrationBuilder.RenameColumn(
                name: "PhoneNumber",
                table: "street_vendor_db_set",
                newName: "phone_number");

            migrationBuilder.RenameColumn(
                name: "AverageRating",
                table: "street_vendor_db_set",
                newName: "average_rating");

            migrationBuilder.RenameColumn(
                name: "VendorID",
                table: "street_vendor_db_set",
                newName: "vendor_id");

            migrationBuilder.RenameColumn(
                name: "Price",
                table: "food_db_set",
                newName: "price");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "food_db_set",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "Categories",
                table: "food_db_set",
                newName: "categories");

            migrationBuilder.RenameColumn(
                name: "StreetVendorVendorID",
                table: "food_db_set",
                newName: "street_vendor_vendor_id");

            migrationBuilder.RenameColumn(
                name: "PhotoUrl",
                table: "food_db_set",
                newName: "photo_url");

            migrationBuilder.RenameColumn(
                name: "FoodEnglishName",
                table: "food_db_set",
                newName: "food_english_name");

            migrationBuilder.RenameColumn(
                name: "FoodID",
                table: "food_db_set",
                newName: "food_id");

            migrationBuilder.RenameColumn(
                name: "FoodVietnameseName",
                table: "food_db_set",
                newName: "food_vietnamese_name");

            migrationBuilder.RenameIndex(
                name: "IX_FoodDbSet_StreetVendorVendorID",
                table: "food_db_set",
                newName: "ix_food_db_set_street_vendor_vendor_id");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "food_category_db_set",
                newName: "description");

            migrationBuilder.RenameColumn(
                name: "StreetVendorVendorID",
                table: "food_category_db_set",
                newName: "street_vendor_vendor_id");

            migrationBuilder.RenameColumn(
                name: "FoodID",
                table: "food_category_db_set",
                newName: "food_id");

            migrationBuilder.RenameColumn(
                name: "CategoryVietnameseName",
                table: "food_category_db_set",
                newName: "category_vietnamese_name");

            migrationBuilder.RenameColumn(
                name: "CategoryEnglishName",
                table: "food_category_db_set",
                newName: "category_english_name");

            migrationBuilder.RenameColumn(
                name: "FoodCategoryID",
                table: "food_category_db_set",
                newName: "food_category_id");

            migrationBuilder.RenameIndex(
                name: "IX_FoodCategoryDbSet_StreetVendorVendorID",
                table: "food_category_db_set",
                newName: "ix_food_category_db_set_street_vendor_vendor_id");

            migrationBuilder.RenameIndex(
                name: "IX_FoodCategoryDbSet_FoodID",
                table: "food_category_db_set",
                newName: "ix_food_category_db_set_food_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_vendor_hours_db_set",
                table: "vendor_hours_db_set",
                column: "vendor_hours_info");

            migrationBuilder.AddPrimaryKey(
                name: "pk_street_vendor_db_set",
                table: "street_vendor_db_set",
                column: "vendor_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_food_db_set",
                table: "food_db_set",
                column: "food_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_food_category_db_set",
                table: "food_category_db_set",
                column: "food_category_id");

            migrationBuilder.AddForeignKey(
                name: "fk_food_category_db_set_food_db_set_food_id",
                table: "food_category_db_set",
                column: "food_id",
                principalTable: "food_db_set",
                principalColumn: "food_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_food_category_db_set_street_vendor_db_set_street_vendor_ven",
                table: "food_category_db_set",
                column: "street_vendor_vendor_id",
                principalTable: "street_vendor_db_set",
                principalColumn: "vendor_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_food_db_set_street_vendor_db_set_street_vendor_vendor_id",
                table: "food_db_set",
                column: "street_vendor_vendor_id",
                principalTable: "street_vendor_db_set",
                principalColumn: "vendor_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_food_category_db_set_food_db_set_food_id",
                table: "food_category_db_set");

            migrationBuilder.DropForeignKey(
                name: "fk_food_category_db_set_street_vendor_db_set_street_vendor_ven",
                table: "food_category_db_set");

            migrationBuilder.DropForeignKey(
                name: "fk_food_db_set_street_vendor_db_set_street_vendor_vendor_id",
                table: "food_db_set");

            migrationBuilder.DropPrimaryKey(
                name: "pk_vendor_hours_db_set",
                table: "vendor_hours_db_set");

            migrationBuilder.DropPrimaryKey(
                name: "pk_street_vendor_db_set",
                table: "street_vendor_db_set");

            migrationBuilder.DropPrimaryKey(
                name: "pk_food_db_set",
                table: "food_db_set");

            migrationBuilder.DropPrimaryKey(
                name: "pk_food_category_db_set",
                table: "food_category_db_set");

            migrationBuilder.RenameTable(
                name: "vendor_hours_db_set",
                newName: "VendorHoursDbSet");

            migrationBuilder.RenameTable(
                name: "street_vendor_db_set",
                newName: "StreetVendorDbSet");

            migrationBuilder.RenameTable(
                name: "food_db_set",
                newName: "FoodDbSet");

            migrationBuilder.RenameTable(
                name: "food_category_db_set",
                newName: "FoodCategoryDbSet");

            migrationBuilder.RenameColumn(
                name: "location",
                table: "VendorHoursDbSet",
                newName: "Location");

            migrationBuilder.RenameColumn(
                name: "vendor_id",
                table: "VendorHoursDbSet",
                newName: "VendorID");

            migrationBuilder.RenameColumn(
                name: "start_time",
                table: "VendorHoursDbSet",
                newName: "StartTime");

            migrationBuilder.RenameColumn(
                name: "end_time",
                table: "VendorHoursDbSet",
                newName: "EndTime");

            migrationBuilder.RenameColumn(
                name: "vendor_hours_info",
                table: "VendorHoursDbSet",
                newName: "VendorHoursInfo");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "StreetVendorDbSet",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "vendor_name",
                table: "StreetVendorDbSet",
                newName: "VendorName");

            migrationBuilder.RenameColumn(
                name: "stand_vietnamese_name",
                table: "StreetVendorDbSet",
                newName: "StandVietnameseName");

            migrationBuilder.RenameColumn(
                name: "stand_english_name",
                table: "StreetVendorDbSet",
                newName: "StandEnglishName");

            migrationBuilder.RenameColumn(
                name: "rating_list",
                table: "StreetVendorDbSet",
                newName: "RatingList");

            migrationBuilder.RenameColumn(
                name: "price_range",
                table: "StreetVendorDbSet",
                newName: "PriceRange");

            migrationBuilder.RenameColumn(
                name: "photo_url",
                table: "StreetVendorDbSet",
                newName: "PhotoUrl");

            migrationBuilder.RenameColumn(
                name: "phone_number",
                table: "StreetVendorDbSet",
                newName: "PhoneNumber");

            migrationBuilder.RenameColumn(
                name: "average_rating",
                table: "StreetVendorDbSet",
                newName: "AverageRating");

            migrationBuilder.RenameColumn(
                name: "vendor_id",
                table: "StreetVendorDbSet",
                newName: "VendorID");

            migrationBuilder.RenameColumn(
                name: "price",
                table: "FoodDbSet",
                newName: "Price");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "FoodDbSet",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "categories",
                table: "FoodDbSet",
                newName: "Categories");

            migrationBuilder.RenameColumn(
                name: "street_vendor_vendor_id",
                table: "FoodDbSet",
                newName: "StreetVendorVendorID");

            migrationBuilder.RenameColumn(
                name: "photo_url",
                table: "FoodDbSet",
                newName: "PhotoUrl");

            migrationBuilder.RenameColumn(
                name: "food_english_name",
                table: "FoodDbSet",
                newName: "FoodEnglishName");

            migrationBuilder.RenameColumn(
                name: "food_id",
                table: "FoodDbSet",
                newName: "FoodID");

            migrationBuilder.RenameColumn(
                name: "food_vietnamese_name",
                table: "FoodDbSet",
                newName: "FoodVietameseName");

            migrationBuilder.RenameIndex(
                name: "ix_food_db_set_street_vendor_vendor_id",
                table: "FoodDbSet",
                newName: "IX_FoodDbSet_StreetVendorVendorID");

            migrationBuilder.RenameColumn(
                name: "description",
                table: "FoodCategoryDbSet",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "street_vendor_vendor_id",
                table: "FoodCategoryDbSet",
                newName: "StreetVendorVendorID");

            migrationBuilder.RenameColumn(
                name: "food_id",
                table: "FoodCategoryDbSet",
                newName: "FoodID");

            migrationBuilder.RenameColumn(
                name: "category_vietnamese_name",
                table: "FoodCategoryDbSet",
                newName: "CategoryVietnameseName");

            migrationBuilder.RenameColumn(
                name: "category_english_name",
                table: "FoodCategoryDbSet",
                newName: "CategoryEnglishName");

            migrationBuilder.RenameColumn(
                name: "food_category_id",
                table: "FoodCategoryDbSet",
                newName: "FoodCategoryID");

            migrationBuilder.RenameIndex(
                name: "ix_food_category_db_set_street_vendor_vendor_id",
                table: "FoodCategoryDbSet",
                newName: "IX_FoodCategoryDbSet_StreetVendorVendorID");

            migrationBuilder.RenameIndex(
                name: "ix_food_category_db_set_food_id",
                table: "FoodCategoryDbSet",
                newName: "IX_FoodCategoryDbSet_FoodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_VendorHoursDbSet",
                table: "VendorHoursDbSet",
                column: "VendorHoursInfo");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StreetVendorDbSet",
                table: "StreetVendorDbSet",
                column: "VendorID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodDbSet",
                table: "FoodDbSet",
                column: "FoodID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_FoodCategoryDbSet",
                table: "FoodCategoryDbSet",
                column: "FoodCategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategoryDbSet_FoodDbSet_FoodID",
                table: "FoodCategoryDbSet",
                column: "FoodID",
                principalTable: "FoodDbSet",
                principalColumn: "FoodID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategoryDbSet_StreetVendorDbSet_StreetVendorVendorID",
                table: "FoodCategoryDbSet",
                column: "StreetVendorVendorID",
                principalTable: "StreetVendorDbSet",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDbSet_StreetVendorDbSet_StreetVendorVendorID",
                table: "FoodDbSet",
                column: "StreetVendorVendorID",
                principalTable: "StreetVendorDbSet",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
