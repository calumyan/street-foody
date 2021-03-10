using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class vendor_seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "1",
                columns: new[] { "photo_url", "price_range", "rating_list", "stand_english_name", "stand_vietnamese_name" },
                values: new object[] { "https://static.riviu.co/640/image/2020/09/04/bef16221de75b45fea2dd579b5c9a29a_output.jpeg", new[] { 15000, 30000 }, new[] { 4, 4, 4 }, "Tran Binh Trong rice noodles", "Hủ tiếu Trần Bình Trọng" });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "2",
                columns: new[] { "price_range", "rating_list", "stand_english_name", "stand_vietnamese_name" },
                values: new object[] { new[] { 15000, 20000 }, new[] { 5 }, "Aunty Loan's banh mi", "Bánh mì Dì Loan" });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "3",
                columns: new[] { "price_range", "rating_list", "stand_english_name", "stand_vietnamese_name" },
                values: new object[] { new[] { 10000, 15000 }, new[] { 5 }, "Miến xào", "Miến xào" });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "4",
                columns: new[] { "price_range", "rating_list", "stand_english_name", "stand_vietnamese_name" },
                values: new object[] { new[] { 10000, 15000 }, new[] { 3 }, "Sticky rice", "Xôi" });

            migrationBuilder.InsertData(
                table: "street_vendor",
                columns: new[] { "vendor_id", "description", "opening_hours", "phone_number", "photo_url", "price_range", "rating_list", "stand_english_name", "stand_vietnamese_name", "vendor_name" },
                values: new object[,]
                {
                    { "5", null, null, null, "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/156646575_817247045527459_8464517707157016028_n.jpg?_nc_cat=1&ccb=3&_nc_sid=b9115d&_nc_ohc=7qGQxbPz5GIAX94w5F1&_nc_ht=scontent.ffcm1-2.fna&oh=66f3c0a1330121b1100836f404c5ced8&oe=60685917", new[] { 14000, 29000 }, new int[0], "Vinh Vien St. snacks and boba tea", "Ăn vặt, trà sữa đường Vĩnh Viễn", null },
                    { "6", null, null, null, "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/84698123_1286864361515233_6961019376854106112_n.jpg?_nc_cat=108&ccb=3&_nc_sid=730e14&_nc_ohc=E1KHA4sGlc4AX_ZY4Mn&_nc_ht=scontent.ffcm1-2.fna&oh=8a56d06173f2342f91f7da037f89fff0&oe=60666BCB", new[] { 35000, 45000 }, new[] { 5 }, "Bau Sen market beef vermicelli soup", "Bún bò Bàu Sen", null },
                    { "7", null, null, null, "https://scontent.ffcm1-2.fna.fbcdn.net/v/t1.0-9/155165695_240195354407050_2744091707808776661_n.jpg?_nc_cat=101&ccb=3&_nc_sid=8bfeb9&_nc_ohc=05vpqk1kzbAAX9TFzD4&_nc_ht=scontent.ffcm1-2.fna&oh=6b0b19a21677cc60dc3c605d0746e109&oe=606906E4", new int[] {999999999, 999999999}, new int[0], "Anva boba tea", "Trà sữa Anva", null },
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "1",
                columns: new[] { "photo_url", "price_range", "rating_list", "stand_english_name", "stand_vietnamese_name" },
                values: new object[] { null, null, null, null, "Uncle Myles's Bahn Mi" });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "2",
                columns: new[] { "price_range", "rating_list", "stand_english_name", "stand_vietnamese_name" },
                values: new object[] { null, null, null, "Aunt Andie's Bahn Mi" });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "3",
                columns: new[] { "price_range", "rating_list", "stand_english_name", "stand_vietnamese_name" },
                values: new object[] { null, null, null, "Aunt Carrie's Bahn Mi" });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "4",
                columns: new[] { "price_range", "rating_list", "stand_english_name", "stand_vietnamese_name" },
                values: new object[] { null, null, null, "Aunt Lucy's Bahn Mi" });
        }
    }
}
