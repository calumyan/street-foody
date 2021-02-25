using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class v1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "VendorDbSet",
                type: "text",
                nullable: true);

            migrationBuilder.InsertData(
                table: "VendorDbSet",
                columns: new[] { "ID", "Description", "Location", "Name", "Phone" },
                values: new object[,]
                {
                    { "1", null, "123 Ly Thai To, Ward 12, District 10, HCMC", "Uncle Tu's Bahn Mi", "84 9024728593" },
                    { "2", null, "123 Ly Thai To, Ward 12, District 10, HCMC", "Uncle Tu's Bahn Mi", "84 9024728593" },
                    { "3", null, "123 Ly Thai To, Ward 12, District 10, HCMC", "Uncle Tu's Bahn Mi", "84 9024728593" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "VendorDbSet",
                keyColumn: "ID",
                keyValue: "1");

            migrationBuilder.DeleteData(
                table: "VendorDbSet",
                keyColumn: "ID",
                keyValue: "2");

            migrationBuilder.DeleteData(
                table: "VendorDbSet",
                keyColumn: "ID",
                keyValue: "3");

            migrationBuilder.DropColumn(
                name: "Description",
                table: "VendorDbSet");
        }
    }
}
