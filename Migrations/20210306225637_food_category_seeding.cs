using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class food_category_seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "10");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "11");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "12");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "13");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "14");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "15");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "3");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "4");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "5");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "6");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "7");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "8");

            migrationBuilder.DeleteData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "9");

            migrationBuilder.InsertData(
                table: "food_category",
                columns: new[] { "food_category_id", "category_english_name", "category_vietnamese_name", "description", "food_id" },
                values: new object[,]
                {
                    { "1", "Pho", "Phở", "", null },
                    { "27", "Vietnamese coffee", "Cà phê", "", null },
                    { "26", "Tea", "Trà", "", null },
                    { "25", "Bottled drinks", "Nước đóng chai", "", null },
                    { "24", "Juice", "Nước ép", "", null },
                    { "23", "Sweet gruel", "Chè", "", null },
                    { "22", "Fruits", "Trái cây", "", null },
                    { "21", "Skewers", "Xiên que", "", null },
                    { "20", "Sweet cakes", "Bánh ngọt", "", null },
                    { "19", "Eggs", "Trứng", "", null },
                    { "18", "Rice paper", "Bánh tráng", "", null },
                    { "17", "Crispy pancakes", "Pancakes", "", null },
                    { "16", "Rolls", "Cuốn", "", null },
                    { "28", "Boba tea", "Trà sữa", "", null },
                    { "15", "Dim sum", "Điểm sấm", "", null },
                    { "13", "Vietnamese sandwich", "Bánh mì", "", null },
                    { "12", "Sticky rice", "Xôi", "", null },
                    { "11", "Egg drop soup", "Súp", "", null },
                    { "10", "Congee", "Cháo", "", null },
                    { "9", "Vietnamese broken rice", "Cơm tấm", "", null },
                    { "8", "Steamed rice rolls, Rice noodle rolls", "Bánh cuốn", "", null },
                    { "7", "Vietnamese macaroni", "Nui", "", null },
                    { "6", "Cellophane noodles/glass noodles", "Miến", "", null },
                    { "5", "Tapioca noodles, banh canh", "Bánh canh", "", null },
                    { "4", "Vietnamese rice vermicelli", "Bún", "", null },
                    { "3", "Egg noodles", "Mì", "", null },
                    { "2", "Rice noodles, or simply hu tieu", "Hủ tiếu", "", null },
                    { "14", "Vietnamese steamed bun", "Bánh bao", "", null },
                    { "29", "Dessert", "Tráng miệng", "", null }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.InsertData(
                table: "street_vendor",
                columns: new[] { "vendor_id", "description", "opening_hours", "phone_number", "photo_url", "price_range", "rating_list", "stand_english_name", "stand_vietnamese_name", "vendor_name" },
                values: new object[,]
                {
                    { "1", null, null, null, "https://static.riviu.co/640/image/2020/09/04/bef16221de75b45fea2dd579b5c9a29a_output.jpeg", new[] { 15000, 30000 }, new[] { 4, 4, 4 }, "Tran Binh Trong rice noodles", "Hủ tiếu Trần Bình Trọng", null },
                    { "2", null, null, null, null, new[] { 15000, 20000 }, new[] { 5 }, "Aunty Loan's banh mi", "Bánh mì Dì Loan", null },
                    { "3", null, null, null, null, new[] { 10000, 15000 }, new[] { 5 }, "Miến xào", "Miến xào", null },
                    { "4", null, null, null, null, new[] { 10000, 15000 }, new[] { 3 }, "Sticky rice", "Xôi", null },
                    { "5", null, null, null, "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/156646575_817247045527459_8464517707157016028_n.jpg?_nc_cat=1&ccb=3&_nc_sid=b9115d&_nc_ohc=7qGQxbPz5GIAX94w5F1&_nc_ht=scontent.ffcm1-2.fna&oh=66f3c0a1330121b1100836f404c5ced8&oe=60685917", new[] { 14000, 29000 }, new int[0], "Vinh Vien St. snacks and boba tea", "Ăn vặt, trà sữa đường Vĩnh Viễn", null },
                    { "6", null, null, null, "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/84698123_1286864361515233_6961019376854106112_n.jpg?_nc_cat=108&ccb=3&_nc_sid=730e14&_nc_ohc=E1KHA4sGlc4AX_ZY4Mn&_nc_ht=scontent.ffcm1-2.fna&oh=8a56d06173f2342f91f7da037f89fff0&oe=60666BCB", new[] { 35000, 45000 }, new[] { 5 }, "Bau Sen market beef vermicelli soup", "Bún bò Bàu Sen", null },
                    { "7", null, null, null, "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155165695_240195354407050_2744091707808776661_n.jpg?_nc_cat=101&ccb=3&_nc_sid=8bfeb9&_nc_ohc=05vpqk1kzbAAX9TFzD4&_nc_ht=scontent.ffcm1-2.fna&oh=6b0b19a21677cc60dc3c605d0746e109&oe=606906E4", new int[0], new int[0], "Anva boba tea", "Trà sữa Anva", null },
                    { "8", null, null, null, "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155122691_1246898299037777_4391716006726234458_n.jpg?_nc_cat=107&ccb=3&_nc_sid=b9115d&_nc_ohc=Oh-3nRYX_ywAX_XtP7F&_nc_ht=scontent.ffcm1-2.fna&oh=6d0ae3ea925ae24e6cc4fefe7eb8f5ec&oe=606915A1", new[] { 20000, 25000 }, null, "Chubby sis's sweet sticky rice", "Xôi ngọt chị Ú", null },
                    { "9", null, null, null, "https://scontent.ffcm1-1.fna.fbcdn.net/v/t1.0-9/155512636_546860506277469_3968119529767571609_o.jpg?_nc_cat=109&ccb=3&_nc_sid=b9115d&_nc_ohc=a11O8kknWEQAX-WDDGL&_nc_ht=scontent.ffcm1-1.fna&oh=2bb5aef40ca9ab14683c771ff074e599&oe=6066F325", new[] { 15000, 40000 }, new[] { 5 }, "Tiger Tea", "Tiger Tea", null },
                    { "10", null, null, null, "https://static.riviu.co/960/image/2021/01/23/507d435341a6bf9a8b78f73b2498cff8_output.jpeg", new[] { 15000, 15000 }, new[] { 5, 5, 5, 4 }, "Grandma's rice paper mix", "Bánh tráng Bà Ngoại", null },
                    { "11", null, null, null, "https://cdn01.diadiemanuong.com/ddau/999x/undefined-che-co-thuy-cao-dat-0-56b16e9637305080834967437.jpg", new[] { 10000, 15000 }, new[] { 5, 5, 5, 5 }, "Aunty Thuy's sweet gruel", "Chè cô Thủy", null },
                    { "12", null, null, null, "https://static.riviu.co/960/image/2020/06/15/f38acd6e2f5fa2c9e3529702ddc1f588_output.jpeg", new[] { 20000, 25000 }, new[] { 4 }, "Grandma's banh mi", "Bánh mì Bà Nội", null },
                    { "13", null, null, null, "https://static.riviu.co/960/image/2020/11/23/60cc5128a4dae43cef57378f30e688c0_output.jpeg", new[] { 15000, 20000 }, new[] { 5 }, "Hu tieu go 20k", "Hủ tiếu gõ 20k", null },
                    { "14", null, null, null, "https://static.riviu.co/960/image/2020/12/28/e02c4fae62a8993c43996561df2865a4_output.jpeg", new[] { 30000, 30000 }, new[] { 5 }, "2 uncles' popiah", "Bò bía 2 ông chú", null },
                    { "15", null, null, null, "https://static.riviu.co/960/image/2020/12/04/67fabbc325dd84ba17fdc0e6e63978e9_output.jpeg", new[] { 5000, 40000 }, new[] { 3, 4, 4 }, "Green Box (Gibi)", "Green Box (Gibi)", null }
                });
        }
    }
}
