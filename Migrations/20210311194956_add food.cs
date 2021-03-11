using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class addfood : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "street_vendor_vendor_id",
                table: "vendor_hours",
                type: "text",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
