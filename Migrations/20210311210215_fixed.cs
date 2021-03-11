using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class @fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "4",
                column: "price_range",
                value: new[] { 10000, 5000 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "street_vendor",
                keyColumn: "vendor_id",
                keyValue: "4",
                column: "price_range",
                value: new[] { 100005000 });
        }
    }
}
