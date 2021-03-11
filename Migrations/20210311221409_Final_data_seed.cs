using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class Final_data_seed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                column: "rating_list",
                value: new[] { 5 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "7",
                column: "rating_list",
                value: new[] { 5 });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "1",
                columns: new[] { "fri", "mon", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "8",
                columns: new[] { "fri", "mon", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) } });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
                value: new[] { 10000, 5000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "5",
                column: "rating_list",
                value: new int[0]);

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "7",
                column: "rating_list",
                value: new int[0]);

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "1",
                columns: new[] { "fri", "mon", "thu", "tue", "wed" },
                values: new object[] { null, null, null, null, null });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "8",
                columns: new[] { "fri", "mon", "thu", "tue", "wed" },
                values: new object[] { null, null, null, null, null });
        }
    }
}
