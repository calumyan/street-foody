using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class fix_typo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_vendor_hours_street_vendor_street_vendor_vendor_id",
                table: "vendor_hours");

            migrationBuilder.DropIndex(
                name: "ix_vendor_hours_street_vendor_vendor_id",
                table: "vendor_hours");

            migrationBuilder.DropColumn(
                name: "street_vendor_vendor_id",
                table: "vendor_hours");

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "10",
                column: "price_range",
                value: new[] { 15000, 20000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "11",
                column: "price_range",
                value: new[] { 10000, 15000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "8",
                column: "price_range",
                value: new[] { 20000, 25000 });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "1",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "10",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "11",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "12",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "13",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "14",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "15",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "2",
                columns: new[] { "fri", "mon", "sat", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "3",
                columns: new[] { "fri", "mon", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 12, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "4",
                columns: new[] { "fri", "mon", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 8, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "5",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "6",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 11, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "7",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 21, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "8",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 23, 59, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "9",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 12, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 12, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "2",
                column: "vietnamese_name",
                value: "Bánh mì Dì Loan");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "street_vendor_vendor_id",
                table: "vendor_hours",
                type: "text",
                nullable: true);

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
                keyValue: "8",
                column: "price_range",
                value: new[] { 20000, 2500 });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "1",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { null, null, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, null, null, null });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "10",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 30, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "11",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "12",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "13",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "14",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "15",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "2",
                columns: new[] { "fri", "mon", "sat", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 5, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "3",
                columns: new[] { "fri", "mon", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 10, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 12, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "4",
                columns: new[] { "fri", "mon", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 6, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 8, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "5",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 9, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "6",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 11, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 17, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "7",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 11, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 21, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "8",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { null, null, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 15, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 23, 59, 0, 0, DateTimeKind.Unspecified) }, null, null, null });

            migrationBuilder.UpdateData(
                table: "vendor_hours",
                keyColumn: "vendor_hours_id",
                keyValue: "9",
                columns: new[] { "fri", "mon", "sat", "sun", "thu", "tue", "wed" },
                values: new object[] { new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) }, new[] { new DateTime(2021, 3, 11, 18, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 3, 11, 22, 0, 0, 0, DateTimeKind.Unspecified) } });

            migrationBuilder.CreateIndex(
                name: "ix_vendor_hours_street_vendor_vendor_id",
                table: "vendor_hours",
                column: "street_vendor_vendor_id");

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
