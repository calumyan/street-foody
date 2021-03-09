using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class changeddatabasepropertyname : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_food_street_vendor_street_vendor_vendor_id",
                table: "food");

            migrationBuilder.DropForeignKey(
                name: "fk_food_category_food_food_id",
                table: "food_category");

            migrationBuilder.DropTable(
                name: "food_category_street_vendor");

            migrationBuilder.DropIndex(
                name: "ix_food_category_food_id",
                table: "food_category");

            migrationBuilder.DropIndex(
                name: "ix_food_street_vendor_vendor_id",
                table: "food");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "16");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "17");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "18");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "19");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "20");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "21");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "22");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "23");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "24");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "25");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "26");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "27");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "28");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "29");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "9");

            migrationBuilder.DropColumn(
                name: "category_english_name",
                table: "food_category");

            migrationBuilder.DropColumn(
                name: "categories",
                table: "food");

            migrationBuilder.RenameColumn(
                name: "stand_vietnamese_name",
                table: "street_vendor",
                newName: "vietnamese_name");

            migrationBuilder.RenameColumn(
                name: "stand_english_name",
                table: "street_vendor",
                newName: "english_name");

            migrationBuilder.RenameColumn(
                name: "food_id",
                table: "food_category",
                newName: "vietnamese_name");

            migrationBuilder.RenameColumn(
                name: "category_vietnamese_name",
                table: "food_category",
                newName: "english_name");

            migrationBuilder.RenameColumn(
                name: "street_vendor_vendor_id",
                table: "food",
                newName: "vietnamese_name");

            migrationBuilder.RenameColumn(
                name: "food_vietnamese_name",
                table: "food",
                newName: "food_category_id");

            migrationBuilder.RenameColumn(
                name: "food_english_name",
                table: "food",
                newName: "english_name");

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

            migrationBuilder.CreateIndex(
                name: "ix_food_food_category_id",
                table: "food",
                column: "food_category_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_street_vendor_street_vendors_vendor_id",
                table: "food_street_vendor",
                column: "street_vendors_vendor_id");

            migrationBuilder.AddForeignKey(
                name: "fk_food_food_category_food_category_id",
                table: "food",
                column: "food_category_id",
                principalTable: "food_category",
                principalColumn: "food_category_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_food_food_category_food_category_id",
                table: "food");

            migrationBuilder.DropTable(
                name: "food_street_vendor");

            migrationBuilder.DropIndex(
                name: "ix_food_food_category_id",
                table: "food");

            migrationBuilder.RenameColumn(
                name: "vietnamese_name",
                table: "street_vendor",
                newName: "stand_vietnamese_name");

            migrationBuilder.RenameColumn(
                name: "english_name",
                table: "street_vendor",
                newName: "stand_english_name");

            migrationBuilder.RenameColumn(
                name: "vietnamese_name",
                table: "food_category",
                newName: "food_id");

            migrationBuilder.RenameColumn(
                name: "english_name",
                table: "food_category",
                newName: "category_vietnamese_name");

            migrationBuilder.RenameColumn(
                name: "vietnamese_name",
                table: "food",
                newName: "street_vendor_vendor_id");

            migrationBuilder.RenameColumn(
                name: "food_category_id",
                table: "food",
                newName: "food_vietnamese_name");

            migrationBuilder.RenameColumn(
                name: "english_name",
                table: "food",
                newName: "food_english_name");

            migrationBuilder.AddColumn<string>(
                name: "category_english_name",
                table: "food_category",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string[]>(
                name: "categories",
                table: "food",
                type: "text[]",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "food_category_street_vendor",
                columns: table => new
                {
                    food_categories_food_category_id = table.Column<string>(type: "text", nullable: false),
                    street_vendors_vendor_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_food_category_street_vendor", x => new { x.food_categories_food_category_id, x.street_vendors_vendor_id });
                    table.ForeignKey(
                        name: "fk_food_category_street_vendor_food_category_food_categories_f",
                        column: x => x.food_categories_food_category_id,
                        principalTable: "food_category",
                        principalColumn: "food_category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_food_category_street_vendor_street_vendor_street_vendors_ve",
                        column: x => x.street_vendors_vendor_id,
                        principalTable: "street_vendor",
                        principalColumn: "vendor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "food_category",
                columns: new[] { "food_category_id", "category_english_name", "category_vietnamese_name", "description", "food_id" },
                values: new object[,]
                {
                    { "1", "Pho", "Phở", " A soup with rice noodles, herbs, and meat. Pho in Saigon tends to have a clearer broth, and can include bean sprouts, fresh sliced chili, hoisin sauce, and additional herbs. Pho is considered to be Vietnam's national dish.", null },
                    { "27", "Vietnamese coffee", "Cà phê", "", null },
                    { "26", "Tea", "Trà", "", null },
                    { "25", "Bottled drinks", "Nước đóng chai", "", null },
                    { "24", "Juice", "Nước ép", "", null },
                    { "23", "Sweet gruel", "Chè", "Sweet gruel is another Vietnamese dessert, with textures ranging from that of a soup to a pudding. Flavors vary, including fruits and chocolates, and often include coconut milk, rice, and/or tapioca.", null },
                    { "22", "Fruits", "Trái cây", "", null },
                    { "21", "Skewers", "Xiên que", "Skewered food in Vietnam can include fried fish balls, grilled corn, grilled sausage, and more.", null },
                    { "20", "Sweet cakes", "Bánh ngọt", "Sweet cakes are a type of Vietnamese dessert and come in many varieties. Cakes can often include rice flour and coconut milk, and can feature flavors like banana and cassava, among others.", null },
                    { "19", "Eggs", "Trứng", "Eggs (usually from a quail, a duck or a chicken), often boiled and fertilized, or soft-boiled.", null },
                    { "18", "Rice paper", "Bánh tráng", "Rice paper wrappers made from a mixture of rice flour with tapioca starch, water and salt. They are thin and light in texture, and often used in egg rolls and spring rolls.", null },
                    { "17", "Crispy pancakes", "Pancakes", "These crispy, savory pancakes are made of rice flour, water, and turmeric, fried in a pan and filled with ingredients like pork, prawns, green onion, mung bean, and herbs.", null },
                    { "16", "Rolls", "Cuốn", "Any Vietnamese traditional food that comes in the form of rolls, e.g. summer rolls, egg rolls, bo bia, .... Wrappers are commonly made from rice papers or betel leaves.", null },
                    { "28", "Boba tea", "Trà sữa", "", null },
                    { "15", "Dim sum", "Điểm sấm", "Originally from China, these can include wontons, dumplings and poststickers and other ball/bun shaped dishes eaten with or without soup. Generally, they are meat balls wrapped inside flour wrappers.", null },
                    { "13", "Vietnamese sandwich", "Bánh mì", "A sandwich made with a short baguette that often includes pork, cucumber, pickled carrots, cilantro, chili, and mayonnaise, or a wide variety of other ingredients and combinations.", null },
                    { "12", "Sticky rice", "Xôi", "", null },
                    { "11", "Egg drop soup", "Súp", "A type of thick, chunky soup made from flavored soup base, egg and tapioca starch. Other typical ingredients include quail eggs, crab meat, pig brain, mushrooms and vegetables. In English, known as egg drop soup.", null },
                    { "10", "Congee", "Cháo", "Vietnamese congee, or rice porridge. It can be combined with chicken, duck, or pork and broth, as well as vegetables, and can also be served with youtiao (a type of fried dough).", null },
                    { "9", "Vietnamese broken rice", "Cơm tấm", "This dish is made from broken rice grains, and is quite popular in Saigon. It often includes grilled pork ribs, fried egg, scallions, fresh and pickled vegetables, and fish sauce.", null },
                    { "8", "Steamed rice rolls, Rice noodle rolls", "Bánh cuốn", "Rice noodle rolls made from thin sheets of fermented rice that are steamed and filled with pork, mushrooms, and shallots.", null },
                    { "7", "Vietnamese macaroni", "Nui", "These noodles are Vietnamese macaroni, and are often included in Vietnamese chicken and noodle soups.", null },
                    { "6", "Cellophane noodles/glass noodles", "Miến", "Also known as cellophane or glass noodles, these help make up Vietnamese dishes like mien ga, a chicken soup. Often confused with bun, or rice vermicelli, glass noodles can be distinguished by their clear glass-like appearance when cooked.", null },
                    { "5", "Tapioca noodles, banh canh", "Bánh canh", "Thick tapioca noodles that can be served with a variety of broths and toppings, which can include crab, fish cakes, pork, and more.", null },
                    { "4", "Vietnamese rice vermicelli", "Bún", "These thin rice noodles, also known as rice vermicelli, can be found in soups, served with meats and vegetables, or in goi cuon.", null },
                    { "3", "Egg noodles", "Mì", "Noodles made out of wheat flour or egg noodles. These noodles can be thick or thin, and can be served in soups or dry (without broth).", null },
                    { "2", "Rice noodles, or simply hu tieu", "Hủ tiếu", "This noodle dish can be served with or without broth (dry) and includes pork bones, herbs, and a variety of meats and other ingredients.", null },
                    { "14", "Vietnamese steamed bun", "Bánh bao", "A round savory bun filled with meat, eggs, and vegetables including onions and mushrooms. Often include Chinese sausage and hard-boiled egg.", null },
                    { "29", "Dessert", "Tráng miệng", "", null }
                });

            migrationBuilder.CreateIndex(
                name: "ix_food_category_food_id",
                table: "food_category",
                column: "food_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_street_vendor_vendor_id",
                table: "food",
                column: "street_vendor_vendor_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_category_street_vendor_street_vendors_vendor_id",
                table: "food_category_street_vendor",
                column: "street_vendors_vendor_id");

            migrationBuilder.AddForeignKey(
                name: "fk_food_street_vendor_street_vendor_vendor_id",
                table: "food",
                column: "street_vendor_vendor_id",
                principalTable: "street_vendor",
                principalColumn: "vendor_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_food_category_food_food_id",
                table: "food_category",
                column: "food_id",
                principalTable: "food",
                principalColumn: "food_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
