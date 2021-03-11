using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class OnetoMany_relationships_built : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_vendor_hours_street_vendor_street_vendor_vendor_id",
                table: "vendor_hours");

            migrationBuilder.DropTable(
                name: "food_street_vendor");

            migrationBuilder.DropPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours");

            migrationBuilder.DropIndex(
                name: "ix_vendor_hours_street_vendor_vendor_id",
                table: "vendor_hours");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "9");

            migrationBuilder.DropColumn(
                name: "street_vendor_vendor_id",
                table: "vendor_hours");

            migrationBuilder.AlterColumn<string>(
                name: "vendor_id",
                table: "vendor_hours",
                type: "text",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AddColumn<string>(
                name: "vendor_hours_id",
                table: "vendor_hours",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "vendor_id",
                table: "food",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours",
                column: "vendor_hours_id");

            migrationBuilder.InsertData(
                table: "food",
                columns: new[] { "food_id", "description", "english_name", "food_category_id", "photo_url", "price", "vendor_id", "vietnamese_name" },
                values: new object[,]
                {
                    { "1", null, "Mixed rice noodle soup", "2", null, 25000.0, "1", "Hủ tiếu thập cẩm" },
                    { "36", null, "Skewer (fish/beef/shrimp balls)", "21", null, 6000.0, "15", "Xiên que cá/bò/tôm:" },
                    { "35", null, "Egg cream milk tea", "28", null, 25000.0, "15", "Trà sữa kem trứng" },
                    { "33", null, "Fruit tea (mango, peach, apple, lychee, strawberry, kiwi)", "28", null, 20000.0, "15", "Trà trái cây (xoài, đào, táo, vải, dâu, kiwi)" },
                    { "32", null, "Milk tea (oolong, chocolate, matcha, oreo)", "28", null, 20000.0, "15", "Trà sữa (oolong, chocolate, matcha, oreo)" },
                    { "31", null, "Popiah (10 rolls)", "16", null, 30000.0, "14", "Bò bía (10 cuốn)" },
                    { "29", null, "Banh mi with grilled prok and cheese", "13", null, 27000.0, "12", "Bánh mì thịt nướng phô mai" },
                    { "28", null, "Banh mi with grilled pork and omelette", "13", null, 27000.0, "12", "Bánh mì thịt nướng ốp la" },
                    { "27", null, "Banh mi with grilled pork", "13", null, 22000.0, "12", "Bánh mì thịt nướng" },
                    { "26", null, "Sweet green bean gruel", "23", null, 15000.0, "11", "Chè đậu xanh" },
                    { "24", null, "Sweet gruel mixed combo", "23", null, 10000.0, "11", "Chè thập cẩm" },
                    { "22", null, "Rice paper mix with quail eggs", "19", null, 15000.0, "10", "Bánh tráng trộn trứng cút" },
                    { "21", null, "Fruit milk tea", "28", null, 15000.0, "9", "Trà sữa trái cây" },
                    { "20", null, "Combos", "28", null, 27000.0, "9", "Combos" },
                    { "19", null, "Milk tea without toppings", "28", null, 17000.0, "9", "Trà sữa không topping" },
                    { "18", null, "9-color sweet sticky rice", "12", null, 20000.0, "8", "Xôi 9 màu" },
                    { "30", null, "Hu tieu go with fishcake, meat, and beef ball", "2", null, 20000.0, "13", "Hủ tiếu gõ chả, thịt, bò viên" },
                    { "15", null, "Milk tea with boba, flan cake and cheese ball", "28", null, 45000.0, "7", "Trà sữa trân châu, bánh flan, phô mai viên" },
                    { "2", null, "Cold cut", "13", null, 15000.0, "2", "Bánh mì thịt nguội" },
                    { "3", null, "Mixed stir-fried glass noodles", "6", null, 10000.0, "3", "Miến" },
                    { "4", null, "Rice vermicelli", "4", null, 10000.0, "3", "Bún" },
                    { "5", null, "Vietnamese macaroni", "7", null, 10000.0, "3", "Nui xào thập cẩm" },
                    { "6", null, "Additional mixed stir-fried glass noodles", "6", null, 3000.0, "3", "Thêm miến" },
                    { "7", null, "Additional rice vermicelli", "4", null, 3000.0, "3", "Thêm Bún" },
                    { "8", null, "Additional Vietnamese macaroni", "7", null, 3000.0, "3", "Thêm nui xào thập cẩm" },
                    { "34", null, "Savory sticky rice - large", "12", null, 15000.0, "4", "Xôi mặn - size lớn" },
                    { "10", null, "Boba tea", "28", null, 20000.0, "5", "Trà sữa" },
                    { "11", null, "Soft-boiled quail eggs (10ct)", "19", null, 15000.0, "5", "Trúng cút lòng đào (10 trứng)" },
                    { "12", null, "Soft-boiled chicken eggs (2ct)", "19", null, 14000.0, "5", "Trứng gà lòng đào (2 trứng)" },
                    { "13", null, "3 story tower combo", "29", null, 29000.0, "5", "Tháp 3 tầng combo" },
                    { "14", null, "Mixed beef vermicelli soup", "4", null, 35000.0, "6", "Bún bò thập cẩm" },
                    { "9", null, "Savory sticky rice - medium", "12", null, 10000.0, "4", "Xôi mặn - size vừa" },
                    { "16", null, "Mixed beef + pig's trotter vermicelli soup", "4", null, 45000.0, "6", "Bún bò thập cẩm + giò" }
                });

            migrationBuilder.InsertData(
                table: "food_category",
                columns: new[] { "food_category_id", "description", "english_name", "vietnamese_name" },
                values: new object[] { "30", "", "Other", "Other" });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "10",
                column: "price_range",
                value: new[] { 15000, 5000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "11",
                column: "price_range",
                value: new[] { 10000, 50000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "3",
                column: "price_range",
                value: new[] { 10000, 5000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "4",
                column: "price_range",
                value: new[] { 100005000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "5",
                column: "vietnamese_name",
                value: "Ăn vặt,trà sữa đường Vĩnh Viễn");

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "8",
                column: "price_range",
                value: new[] { 20000, 2500 });

            migrationBuilder.InsertData(
                table: "vendor_hours",
                columns: new[] { "vendor_hours_id", "fri", "location", "mon", "sat", "sun", "thu", "tue", "vendor_id", "wed" },
                values: new object[,]
                {
                    { "3", new[] { new DateTime(2021, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) }, "10-12 Dinh Tien Hoang St., Ben Nghe Ward, District 1, HCMC", new[] { new DateTime(2021, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, null, new[] { new DateTime(2021, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) }, "3", new[] { new DateTime(2021, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) } },
                    { "15", null, "38 Phạm Ngọc Thạch, P.6, Q.3, HCMC", null, new[] { new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, "15", null },
                    { "14", null, "Le Van Tam Park", null, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, "14", null },
                    { "13", null, "48 Kha Van Can St., Binh Chanh Ward, Thu Duc District", null, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, "13", null },
                    { "1", null, "359 Tran Binh Trong, Ward 1, District 10, HCMC", null, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, "1", null },
                    { "12", null, "246/55A Hoa Hung, Ward 13, District 10", null, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, "12", null },
                    { "10", null, "623/20 CMT8, P.15, Q.10", null, new[] { new DateTime(2021, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, "10", null },
                    { "9", null, "27 Thanh Da, Ward 27, Binh Thanh District", null, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, "9", null },
                    { "8", null, "8 Phan Van Han, Ward 19, Binh Thanh District", null, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, null, null, "8", null },
                    { "7", new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, "267 Pham Van Chi, Ward 3, District 6", new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, "7", new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) } },
                    { "6", new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, "138 Nguyen Trai, Ward 3, District 5", new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, "6", new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) } },
                    { "5", new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, "82 Vinh Vien, Ward 2, District 10, HCMC", new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, "5", new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) } },
                    { "4", new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) }, "217 Hong Bang, Ward 1, District 5, HCMC", new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, null, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) }, "4", new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) } },
                    { "11", null, "897/29 Tran Hung Dao, Ward 01, District 5, HCMC", null, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, "11", null },
                    { "2", new[] { new DateTime(2021, 3, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) }, "15 D5 St., Ward 25, Binh Thanh District, HCMC", new[] { new DateTime(2021, 3, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, new[] { new DateTime(2021, 3, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) }, "2", new[] { new DateTime(2021, 3, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) } }
                });

            migrationBuilder.InsertData(
                table: "food",
                columns: new[] { "food_id", "description", "english_name", "food_category_id", "photo_url", "price", "vendor_id", "vietnamese_name" },
                values: new object[,]
                {
                    { "17", null, "Cheese ball (1ct)", "30", null, 2000.0, "7", "Phô mai viên (1 viên)" },
                    { "23", null, "Grass jelly mix (1 lit.)", "30", null, 15000.0, "11", "Sương sáo thập cẩm (1 lit.)" },
                    { "25", null, "Fruit cocktails", "30", null, 15000.0, "11", "Cốc tai trái cây" },
                    { "37", null, "Fried wontons (1ct)", "30", null, 10000.0, "15", "Hoành thánh chiên (1ct)" },
                    { "38", null, "Cheese-soaked potato", "30", null, 20000.0, "15", "Khoai tây lắc phô mai" },
                    { "39", null, "Cheese-soaked rice cake", "30", null, 20000.0, "15", "Bánh gạo lắc phô mai" }
                });

            migrationBuilder.CreateIndex(
                name: "ix_vendor_hours_vendor_id",
                table: "vendor_hours",
                column: "vendor_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_vendor_id",
                table: "food",
                column: "vendor_id");

            migrationBuilder.AddForeignKey(
                name: "fk_food_street_vendor_vendor_id",
                table: "food",
                column: "vendor_id",
                principalTable: "street_vendor",
                principalColumn: "vendor_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_vendor_hours_street_vendor_vendor_id",
                table: "vendor_hours",
                column: "vendor_id",
                principalTable: "street_vendor",
                principalColumn: "vendor_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_food_street_vendor_vendor_id",
                table: "food");

            migrationBuilder.DropForeignKey(
                name: "fk_vendor_hours_street_vendor_vendor_id",
                table: "vendor_hours");

            migrationBuilder.DropPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours");

            migrationBuilder.DropIndex(
                name: "ix_vendor_hours_vendor_id",
                table: "vendor_hours");

            migrationBuilder.DropIndex(
                name: "ix_food_vendor_id",
                table: "food");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "30");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "31");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "32");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "33");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "34");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "35");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "36");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "37");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "38");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "39");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "food",
                keyColumn: "food_id",
                keyValue: "9");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "30");

            migrationBuilder.DropColumn(
                name: "vendor_hours_id",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "vendor_id",
                table: "food");

            migrationBuilder.AlterColumn<string>(
                name: "vendor_id",
                table: "vendor_hours",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "street_vendor_vendor_id",
                table: "vendor_hours",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours",
                column: "vendor_id");

            migrationBuilder.CreateTable(
                name: "food_street_vendor",
                columns: table => new
                {
                    foods_food_id = table.Column<string>(type: "text", nullable: false),
                    street_vendors_vendor_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_food_street_vendor", x => new { x.foods_food_id, x.street_vendors_vendor_id });
                    table.ForeignKey(
                        name: "fk_food_street_vendor_food_foods_food_id",
                        column: x => x.foods_food_id,
                        principalTable: "food",
                        principalColumn: "food_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_food_street_vendor_street_vendor_street_vendors_vendor_id",
                        column: x => x.street_vendors_vendor_id,
                        principalTable: "street_vendor",
                        principalColumn: "vendor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "10",
                column: "price_range",
                value: new[] { 15000, 15000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "11",
                column: "price_range",
                value: new[] { 10000, 15000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "3",
                column: "price_range",
                value: new[] { 10000, 15000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "4",
                column: "price_range",
                value: new[] { 10000, 15000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "5",
                column: "vietnamese_name",
                value: "Ăn vặt, trà sữa đường Vĩnh Viễn");

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "8",
                column: "price_range",
                value: new[] { 20000, 25000 });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "1",
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "10",
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "11",
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "12",
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "13",
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "14",
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "15",
                columns: new[] { "location", "sat", "sun" },
                values: new object[] { "38 Phạm Ngọc Thạch, P.6, Q.3, HCM", new[] { new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "2",
                columns: new[] { "fri", "mon", "sat", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "3",
                columns: new[] { "fri", "mon", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "4",
                columns: new[] { "fri", "mon", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 8, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "5",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { null, null, new[] { new DateTime(2021, 3, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, null });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "6",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { null, null, new[] { new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 59, 0, 0, DateTimeKind.Unspecified) }, null, null, null });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "7",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { null, null, new[] { new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, null });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "8",
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 59, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "9",
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.CreateIndex(
                name: "ix_vendor_hours_street_vendor_vendor_id",
                table: "vendor_hours",
                column: "street_vendor_vendor_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_street_vendor_street_vendors_vendor_id",
                table: "food_street_vendor",
                column: "street_vendors_vendor_id");

            migrationBuilder.AddForeignKey(
                name: "fk_vendor_hours_street_vendor_street_vendor_vendor_id",
                table: "vendor_hours",
                column: "street_vendor_vendor_id",
                principalTable: "street_vendor",
                principalColumn: "vendor_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
