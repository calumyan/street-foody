using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class v2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendorDbSet");

            migrationBuilder.CreateTable(
                name: "StreetVendorDbSet",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    StandVietnameseName = table.Column<string>(type: "text", nullable: true),
                    StandEnglishName = table.Column<string>(type: "text", nullable: true),
                    VendorName = table.Column<string>(type: "text", nullable: true),
                    PhoneNumber = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    PriceRange = table.Column<string>(type: "text", nullable: true),
                    RatingList = table.Column<List<int>>(type: "integer[]", nullable: true),
                    AverageRating = table.Column<double>(type: "double precision", nullable: false),
                    PhotoUrl = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_StreetVendorDbSet", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "FoodDbSet",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    VietameseName = table.Column<string>(type: "text", nullable: true),
                    Categories = table.Column<List<string>>(type: "text[]", nullable: true),
                    EnglishName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Price = table.Column<double>(type: "double precision", nullable: false),
                    PhotoUrl = table.Column<string>(type: "text", nullable: true),
                    StreetVendorID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodDbSet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FoodDbSet_StreetVendorDbSet_StreetVendorID",
                        column: x => x.StreetVendorID,
                        principalTable: "StreetVendorDbSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "FoodCategoryDbSet",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    CategoryVietameseName = table.Column<string>(type: "text", nullable: true),
                    CategoryEnglishName = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    FoodID = table.Column<string>(type: "text", nullable: true),
                    StreetVendorID = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FoodCategoryDbSet", x => x.ID);
                    table.ForeignKey(
                        name: "FK_FoodCategoryDbSet_FoodDbSet_FoodID",
                        column: x => x.FoodID,
                        principalTable: "FoodDbSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_FoodCategoryDbSet_StreetVendorDbSet_StreetVendorID",
                        column: x => x.StreetVendorID,
                        principalTable: "StreetVendorDbSet",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategoryDbSet_FoodID",
                table: "FoodCategoryDbSet",
                column: "FoodID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodCategoryDbSet_StreetVendorID",
                table: "FoodCategoryDbSet",
                column: "StreetVendorID");

            migrationBuilder.CreateIndex(
                name: "IX_FoodDbSet_StreetVendorID",
                table: "FoodDbSet",
                column: "StreetVendorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "FoodCategoryDbSet");

            migrationBuilder.DropTable(
                name: "FoodDbSet");

            migrationBuilder.DropTable(
                name: "StreetVendorDbSet");

            migrationBuilder.CreateTable(
                name: "VendorDbSet",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorDbSet", x => x.ID);
                });

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
    }
}
