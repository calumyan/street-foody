using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class addedaprice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string[]>(
                name: "opening_hours",
                table: "street_vendor",
                type: "text[]",
                nullable: true,
                oldClrType: typeof(int[]),
                oldType: "integer[]",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "5",
                column: "rating_list",
                value: new[] { 10000, 18000 });

            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "7",
                column: "price_range",
                value: new[] { 10000, 10000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int[]>(
                name: "opening_hours",
                table: "street_vendor",
                type: "integer[]",
                nullable: true,
                oldClrType: typeof(string[]),
                oldType: "text[]",
                oldNullable: true);

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
                column: "price_range",
                value: new int[] {999999999, 999999999});
        }
    }
}
