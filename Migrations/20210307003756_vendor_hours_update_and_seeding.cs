using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class vendor_hours_update_and_seeding : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_vendor_hours",
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

            migrationBuilder.RenameColumn(
                name: "vendor_hours_info",
                table: "vendor_hours",
                newName: "vendor_dates");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "vendor_hours_id",
                table: "vendor_hours");

            migrationBuilder.RenameColumn(
                name: "vendor_dates",
                table: "vendor_hours",
                newName: "vendor_hours_info");

            migrationBuilder.AlterColumn<string>(
                name: "vendor_id",
                table: "vendor_hours",
                type: "text",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours",
                column: "vendor_id");
        }
    }
}
