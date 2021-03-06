using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class food_category_descriptions_added : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "1",
                column: "description",
                value: " A soup with rice noodles, herbs, and meat. Pho in Saigon tends to have a clearer broth, and can include bean sprouts, fresh sliced chili, hoisin sauce, and additional herbs. Pho is considered to be Vietnam's national dish.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "10",
                column: "description",
                value: "Vietnamese congee, or rice porridge. It can be combined with chicken, duck, or pork and broth, as well as vegetables, and can also be served with youtiao (a type of fried dough).");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "11",
                column: "description",
                value: "A type of thick, chunky soup made from flavored soup base, egg and tapioca starch. Other typical ingredients include quail eggs, crab meat, pig brain, mushrooms and vegetables. In English, known as egg drop soup.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "13",
                column: "description",
                value: "A sandwich made with a short baguette that often includes pork, cucumber, pickled carrots, cilantro, chili, and mayonnaise, or a wide variety of other ingredients and combinations.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "14",
                column: "description",
                value: "A round savory bun filled with meat, eggs, and vegetables including onions and mushrooms. Often include Chinese sausage and hard-boiled egg.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "15",
                column: "description",
                value: "Originally from China, these can include wontons, dumplings and poststickers and other ball/bun shaped dishes eaten with or without soup. Generally, they are meat balls wrapped inside flour wrappers.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "16",
                column: "description",
                value: "Any Vietnamese traditional food that comes in the form of rolls, e.g. summer rolls, egg rolls, bo bia, .... Wrappers are commonly made from rice papers or betel leaves.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "17",
                column: "description",
                value: "These crispy, savory pancakes are made of rice flour, water, and turmeric, fried in a pan and filled with ingredients like pork, prawns, green onion, mung bean, and herbs.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "18",
                column: "description",
                value: "Rice paper wrappers made from a mixture of rice flour with tapioca starch, water and salt. They are thin and light in texture, and often used in egg rolls and spring rolls.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "19",
                column: "description",
                value: "Eggs (usually from a quail, a duck or a chicken), often boiled and fertilized, or soft-boiled.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "2",
                column: "description",
                value: "This noodle dish can be served with or without broth (dry) and includes pork bones, herbs, and a variety of meats and other ingredients.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "20",
                column: "description",
                value: "Sweet cakes are a type of Vietnamese dessert and come in many varieties. Cakes can often include rice flour and coconut milk, and can feature flavors like banana and cassava, among others.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "21",
                column: "description",
                value: "Skewered food in Vietnam can include fried fish balls, grilled corn, grilled sausage, and more.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "23",
                column: "description",
                value: "Sweet gruel is another Vietnamese dessert, with textures ranging from that of a soup to a pudding. Flavors vary, including fruits and chocolates, and often include coconut milk, rice, and/or tapioca.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "3",
                column: "description",
                value: "Noodles made out of wheat flour or egg noodles. These noodles can be thick or thin, and can be served in soups or dry (without broth).");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "4",
                column: "description",
                value: "These thin rice noodles, also known as rice vermicelli, can be found in soups, served with meats and vegetables, or in goi cuon.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "5",
                column: "description",
                value: "Thick tapioca noodles that can be served with a variety of broths and toppings, which can include crab, fish cakes, pork, and more.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "6",
                column: "description",
                value: "Also known as cellophane or glass noodles, these help make up Vietnamese dishes like mien ga, a chicken soup. Often confused with bun, or rice vermicelli, glass noodles can be distinguished by their clear glass-like appearance when cooked.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "7",
                column: "description",
                value: "These noodles are Vietnamese macaroni, and are often included in Vietnamese chicken and noodle soups.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "8",
                column: "description",
                value: "Rice noodle rolls made from thin sheets of fermented rice that are steamed and filled with pork, mushrooms, and shallots.");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "9",
                column: "description",
                value: "This dish is made from broken rice grains, and is quite popular in Saigon. It often includes grilled pork ribs, fried egg, scallions, fresh and pickled vegetables, and fish sauce.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "1",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "10",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "11",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "13",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "14",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "15",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "16",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "17",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "18",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "19",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "2",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "20",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "21",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "23",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "3",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "4",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "5",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "6",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "7",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "8",
                column: "description",
                value: "");

            migrationBuilder.UpdateData(
                table: "food_category",
                keyColumn: "food_category_id",
                keyValue: "9",
                column: "description",
                value: "");
        }
    }
}
