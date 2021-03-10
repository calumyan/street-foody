using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class vendor_hours_7_days_change : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "vendor_hours_id",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "end_time",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "start_time",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "vendor_dates",
                table: "vendor_hours");

            migrationBuilder.AlterColumn<string>(
                name: "vendor_id",
                table: "vendor_hours",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddColumn<DateTime[]>(
                name: "fri",
                table: "vendor_hours",
                type: "timestamp without time zone[]",
                nullable: true);

            migrationBuilder.AddColumn<DateTime[]>(
                name: "mon",
                table: "vendor_hours",
                type: "timestamp without time zone[]",
                nullable: true);

            migrationBuilder.AddColumn<DateTime[]>(
                name: "sat",
                table: "vendor_hours",
                type: "timestamp without time zone[]",
                nullable: true);

            migrationBuilder.AddColumn<DateTime[]>(
                name: "sun",
                table: "vendor_hours",
                type: "timestamp without time zone[]",
                nullable: true);

            migrationBuilder.AddColumn<DateTime[]>(
                name: "thu",
                table: "vendor_hours",
                type: "timestamp without time zone[]",
                nullable: true);

            migrationBuilder.AddColumn<DateTime[]>(
                name: "tue",
                table: "vendor_hours",
                type: "timestamp without time zone[]",
                nullable: true);

            migrationBuilder.AddColumn<DateTime[]>(
                name: "wed",
                table: "vendor_hours",
                type: "timestamp without time zone[]",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours",
                column: "vendor_id");

            migrationBuilder.InsertData(
                table: "food_category",
                columns: new[] { "food_category_id", "description", "english_name", "vietnamese_name" },
                values: new object[,]
                {
                    { "1", " A soup with rice noodles, herbs, and meat. Pho in Saigon tends to have a clearer broth, and can include bean sprouts, fresh sliced chili, hoisin sauce, and additional herbs. Pho is considered to be Vietnam's national dish.", "Pho", "Phở" },
                    { "29", "", "Dessert", "Tráng miệng" },
                    { "28", "", "Boba tea", "Trà sữa" },
                    { "27", "", "Vietnamese coffee", "Cà phê" },
                    { "26", "", "Tea", "Trà" },
                    { "25", "", "Bottled drinks", "Nước đóng chai" },
                    { "24", "", "Juice", "Nước ép" },
                    { "23", "Sweet gruel is another Vietnamese dessert, with textures ranging from that of a soup to a pudding. Flavors vary, including fruits and chocolates, and often include coconut milk, rice, and/or tapioca.", "Sweet gruel", "Chè" },
                    { "21", "Skewered food in Vietnam can include fried fish balls, grilled corn, grilled sausage, and more.", "Skewers", "Xiên que" },
                    { "20", "Sweet cakes are a type of Vietnamese dessert and come in many varieties. Cakes can often include rice flour and coconut milk, and can feature flavors like banana and cassava, among others.", "Sweet cakes", "Bánh ngọt" },
                    { "19", "Eggs (usually from a quail, a duck or a chicken), often boiled and fertilized, or soft-boiled.", "Eggs", "Trứng" },
                    { "18", "Rice paper wrappers made from a mixture of rice flour with tapioca starch, water and salt. They are thin and light in texture, and often used in egg rolls and spring rolls.", "Rice paper", "Bánh tráng" },
                    { "17", "These crispy, savory pancakes are made of rice flour, water, and turmeric, fried in a pan and filled with ingredients like pork, prawns, green onion, mung bean, and herbs.", "Crispy pancakes", "Pancakes" },
                    { "16", "Any Vietnamese traditional food that comes in the form of rolls, e.g. summer rolls, egg rolls, bo bia, .... Wrappers are commonly made from rice papers or betel leaves.", "Rolls", "Cuốn" },
                    { "22", "", "Fruits", "Trái cây" },
                    { "14", "A round savory bun filled with meat, eggs, and vegetables including onions and mushrooms. Often include Chinese sausage and hard-boiled egg.", "Vietnamese steamed bun", "Bánh bao" },
                    { "13", "A sandwich made with a short baguette that often includes pork, cucumber, pickled carrots, cilantro, chili, and mayonnaise, or a wide variety of other ingredients and combinations.", "Vietnamese sandwich", "Bánh mì" },
                    { "12", "", "Sticky rice", "Xôi" },
                    { "11", "A type of thick, chunky soup made from flavored soup base, egg and tapioca starch. Other typical ingredients include quail eggs, crab meat, pig brain, mushrooms and vegetables. In English, known as egg drop soup.", "Egg drop soup", "Súp" },
                    { "10", "Vietnamese congee, or rice porridge. It can be combined with chicken, duck, or pork and broth, as well as vegetables, and can also be served with youtiao (a type of fried dough).", "Congee", "Cháo" },
                    { "9", "This dish is made from broken rice grains, and is quite popular in Saigon. It often includes grilled pork ribs, fried egg, scallions, fresh and pickled vegetables, and fish sauce.", "Vietnamese broken rice", "Cơm tấm" },
                    { "15", "Originally from China, these can include wontons, dumplings and poststickers and other ball/bun shaped dishes eaten with or without soup. Generally, they are meat balls wrapped inside flour wrappers.", "Dim sum", "Điểm sấm" },
                    { "8", "Rice noodle rolls made from thin sheets of fermented rice that are steamed and filled with pork, mushrooms, and shallots.", "Steamed rice rolls, Rice noodle rolls", "Bánh cuốn" },
                    { "7", "These noodles are Vietnamese macaroni, and are often included in Vietnamese chicken and noodle soups.", "Vietnamese macaroni", "Nui" },
                    { "6", "Also known as cellophane or glass noodles, these help make up Vietnamese dishes like mien ga, a chicken soup. Often confused with bun, or rice vermicelli, glass noodles can be distinguished by their clear glass-like appearance when cooked.", "Cellophane noodles/glass noodles", "Miến" },
                    { "5", "Thick tapioca noodles that can be served with a variety of broths and toppings, which can include crab, fish cakes, pork, and more.", "Tapioca noodles, banh canh", "Bánh canh" },
                    { "4", "These thin rice noodles, also known as rice vermicelli, can be found in soups, served with meats and vegetables, or in goi cuon.", "Vietnamese rice vermicelli", "Bún" },
                    { "3", "Noodles made out of wheat flour or egg noodles. These noodles can be thick or thin, and can be served in soups or dry (without broth).", "Egg noodles", "Mì" },
                    { "2", "This noodle dish can be served with or without broth (dry) and includes pork bones, herbs, and a variety of meats and other ingredients.", "Rice noodles, or simply hu tieu", "Hủ tiếu" }
                });

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
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 0, 0, 0, DateTimeKind.Unspecified) } });

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
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "6",
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 11, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 23, 59, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_id",
                keyValue: "7",
                columns: new[] { "sat", "sun" },
                values: new object[] { new[] { new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 9, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 9, 21, 0, 0, 0, DateTimeKind.Unspecified) } });

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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours");

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
                name: "fri",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "mon",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "sat",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "sun",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "thu",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "tue",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "wed",
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
                name: "end_time",
                table: "vendor_hours",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "start_time",
                table: "vendor_hours",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "vendor_dates",
                table: "vendor_hours",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours",
                column: "vendor_hours_id");

            migrationBuilder.InsertData(
                table: "vendor_hours",
                columns: new[] { "vendor_hours_id", "end_time", "location", "start_time", "vendor_dates", "vendor_id" },
                values: new object[,]
                {
                    { "1", "9pm", "359 Tran Binh Trong, Ward 1, District 10, HCMC", "3pm", "Sun-Sat", "1" },
                    { "2", "11am", "15 D5 St., Ward 25, Binh Thanh District, HCMC", "5am", "Mon-Sat", "2" },
                    { "3", "12pm", "10-12 Dinh Tien Hoang St., Ben Nghe Ward, District 1, HCMC", "10am", "Mon-Fri", "3" },
                    { "4", "8am", "217 Hong Bang, Ward 1, District 5, HCMC", "6am", "Mon-Fri", "4" },
                    { "5", "10pm", "82 Vinh Vien, Ward 2, District 10, HCMC", "9am", "Sun-Sat", "5" },
                    { "6", "12am", "138 Nguyen Trai, Ward 3, District 5", "5pm", "Sun-Sat", "6" },
                    { "7", "9pm", "267 Pham Van Chi, Ward 3, District 6", "11am", "Sun-Sat", "7" },
                    { "8", "N/A", "8 Phan Van Han, Ward 19, Binh Thanh District", "3pm", "Sun-Sat", "8" },
                    { "9", "10pm", "27 Thanh Da, Ward 27, Binh Thanh District", "6pm", "Sun-Sat", "9" },
                    { "10", "10pm", "623/20 CMT8, P.15, Q.10", "5:30pm", "Sun-Sat", "10" },
                    { "11", "5pm", "897/29 Tran Hung Dao, Ward 01, District 5, HCMC", "11am", "Sun-Sat", "11" },
                    { "12", "9pm", "246/55A Hoa Hung, Ward 13, District 10", "6am", "Sun-Sat", "12" },
                    { "13", "10pm", "48 Kha Van Can St., Binh Chanh Ward, Thu Duc District", "6pm", "Sun-Sat", "13" },
                    { "14", "10pm", "Le Van Tam Park", "5pm", "Sun-Sat", "14" },
                    { "15", "11pm", "38 Phạm Ngọc Thạch, P.6, Q.3, HCM", "12pm", "Sun-Sat", "15" }
                });
        }
    }
}
