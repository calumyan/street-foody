using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategoryDbSet_StreetVendorDbSet_StreetVendorID",
                table: "FoodCategoryDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodDbSet_StreetVendorDbSet_StreetVendorID",
                table: "FoodDbSet");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "StreetVendorDbSet",
                newName: "VendorID");

            migrationBuilder.RenameColumn(
                name: "StreetVendorID",
                table: "FoodDbSet",
                newName: "StreetVendorVendorID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "FoodDbSet",
                newName: "FoodID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodDbSet_StreetVendorID",
                table: "FoodDbSet",
                newName: "IX_FoodDbSet_StreetVendorVendorID");

            migrationBuilder.RenameColumn(
                name: "StreetVendorID",
                table: "FoodCategoryDbSet",
                newName: "StreetVendorVendorID");

            migrationBuilder.RenameColumn(
                name: "ID",
                table: "FoodCategoryDbSet",
                newName: "FoodCategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodCategoryDbSet_StreetVendorID",
                table: "FoodCategoryDbSet",
                newName: "IX_FoodCategoryDbSet_StreetVendorVendorID");

            migrationBuilder.CreateTable(
                name: "VendorHoursDbSet",
                columns: table => new
                {
                    VendorHoursInfo = table.Column<string>(type: "text", nullable: false),
                    VendorID = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    StartTime = table.Column<string>(type: "text", nullable: true),
                    EndTime = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorHoursDbSet", x => x.VendorHoursInfo);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategoryDbSet_StreetVendorDbSet_StreetVendorVendorID",
                table: "FoodCategoryDbSet",
                column: "StreetVendorVendorID",
                principalTable: "StreetVendorDbSet",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDbSet_StreetVendorDbSet_StreetVendorVendorID",
                table: "FoodDbSet",
                column: "StreetVendorVendorID",
                principalTable: "StreetVendorDbSet",
                principalColumn: "VendorID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FoodCategoryDbSet_StreetVendorDbSet_StreetVendorVendorID",
                table: "FoodCategoryDbSet");

            migrationBuilder.DropForeignKey(
                name: "FK_FoodDbSet_StreetVendorDbSet_StreetVendorVendorID",
                table: "FoodDbSet");

            migrationBuilder.DropTable(
                name: "VendorHoursDbSet");

            migrationBuilder.RenameColumn(
                name: "VendorID",
                table: "StreetVendorDbSet",
                newName: "ID");

            migrationBuilder.RenameColumn(
                name: "StreetVendorVendorID",
                table: "FoodDbSet",
                newName: "StreetVendorID");

            migrationBuilder.RenameColumn(
                name: "FoodID",
                table: "FoodDbSet",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodDbSet_StreetVendorVendorID",
                table: "FoodDbSet",
                newName: "IX_FoodDbSet_StreetVendorID");

            migrationBuilder.RenameColumn(
                name: "StreetVendorVendorID",
                table: "FoodCategoryDbSet",
                newName: "StreetVendorID");

            migrationBuilder.RenameColumn(
                name: "FoodCategoryID",
                table: "FoodCategoryDbSet",
                newName: "ID");

            migrationBuilder.RenameIndex(
                name: "IX_FoodCategoryDbSet_StreetVendorVendorID",
                table: "FoodCategoryDbSet",
                newName: "IX_FoodCategoryDbSet_StreetVendorID");

            migrationBuilder.AddForeignKey(
                name: "FK_FoodCategoryDbSet_StreetVendorDbSet_StreetVendorID",
                table: "FoodCategoryDbSet",
                column: "StreetVendorID",
                principalTable: "StreetVendorDbSet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_FoodDbSet_StreetVendorDbSet_StreetVendorID",
                table: "FoodDbSet",
                column: "StreetVendorID",
                principalTable: "StreetVendorDbSet",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
