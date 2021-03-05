using System.Collections.Generic;
using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class changetomanytomany : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_food_category_db_set_food_db_set_food_id",
                table: "food_category_db_set");

            migrationBuilder.DropForeignKey(
                name: "fk_food_category_db_set_street_vendor_db_set_street_vendor_ven",
                table: "food_category_db_set");

            migrationBuilder.DropForeignKey(
                name: "fk_food_db_set_street_vendor_db_set_street_vendor_vendor_id",
                table: "food_db_set");

            migrationBuilder.DropPrimaryKey(
                name: "pk_vendor_hours_db_set",
                table: "vendor_hours_db_set");

            migrationBuilder.DropPrimaryKey(
                name: "pk_street_vendor_db_set",
                table: "street_vendor_db_set");

            migrationBuilder.DropPrimaryKey(
                name: "pk_food_db_set",
                table: "food_db_set");

            migrationBuilder.DropPrimaryKey(
                name: "pk_food_category_db_set",
                table: "food_category_db_set");

            migrationBuilder.DropIndex(
                name: "ix_food_category_db_set_street_vendor_vendor_id",
                table: "food_category_db_set");

            migrationBuilder.DropColumn(
                name: "average_rating",
                table: "street_vendor_db_set");

            migrationBuilder.DropColumn(
                name: "street_vendor_vendor_id",
                table: "food_category_db_set");

            migrationBuilder.RenameTable(
                name: "vendor_hours_db_set",
                newName: "vendor_hours");

            migrationBuilder.RenameTable(
                name: "street_vendor_db_set",
                newName: "street_vendor");

            migrationBuilder.RenameTable(
                name: "food_db_set",
                newName: "food");

            migrationBuilder.RenameTable(
                name: "food_category_db_set",
                newName: "food_category");

            migrationBuilder.RenameIndex(
                name: "ix_food_db_set_street_vendor_vendor_id",
                table: "food",
                newName: "ix_food_street_vendor_vendor_id");

            migrationBuilder.RenameIndex(
                name: "ix_food_category_db_set_food_id",
                table: "food_category",
                newName: "ix_food_category_food_id");

            // migrationBuilder.AlterColumn<List<int>>(
            //     name: "price_range",
            //     table: "street_vendor",
            //     type: "integer[]",
            //     nullable: true,
            //     oldClrType: typeof(string),
            //     oldType: "text",
            //     oldNullable: true);

            migrationBuilder.DropColumn(
                name: "price_range",
                table: "street_vendor");

            migrationBuilder.AddColumn<List<int>> (
                name: "price_range",
                table: "street_vendor",
                type: "integer[]",
                nullable: true);

            migrationBuilder.AddColumn<List<int>>(
                name: "opening_hours",
                table: "street_vendor",
                type: "integer[]",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours",
                column: "vendor_hours_info");

            migrationBuilder.AddPrimaryKey(
                name: "pk_street_vendor",
                table: "street_vendor",
                column: "vendor_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_food",
                table: "food",
                column: "food_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_food_category",
                table: "food_category",
                column: "food_category_id");

            migrationBuilder.CreateTable(
                name: "food_category_street_vendor",
                columns: table => new
                {
                    food_categories_food_category_id = table.Column<string>(type: "text", nullable: false),
                    street_vendors_vendor_id = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("pk_food_category_street_vendor", x => new { x.food_categories_food_category_id, x.street_vendors_vendor_id });
                    table.ForeignKey(
                        name: "fk_food_category_street_vendor_food_category_food_categories_f",
                        column: x => x.food_categories_food_category_id,
                        principalTable: "food_category",
                        principalColumn: "food_category_id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "fk_food_category_street_vendor_street_vendor_street_vendors_ve",
                        column: x => x.street_vendors_vendor_id,
                        principalTable: "street_vendor",
                        principalColumn: "vendor_id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "ix_food_category_street_vendor_street_vendors_vendor_id",
                table: "food_category_street_vendor",
                column: "street_vendors_vendor_id");

            migrationBuilder.AddForeignKey(
                name: "fk_food_street_vendor_street_vendor_vendor_id",
                table: "food",
                column: "street_vendor_vendor_id",
                principalTable: "street_vendor",
                principalColumn: "vendor_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_food_category_food_food_id",
                table: "food_category",
                column: "food_id",
                principalTable: "food",
                principalColumn: "food_id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "fk_food_street_vendor_street_vendor_vendor_id",
                table: "food");

            migrationBuilder.DropForeignKey(
                name: "fk_food_category_food_food_id",
                table: "food_category");

            migrationBuilder.DropTable(
                name: "food_category_street_vendor");

            migrationBuilder.DropPrimaryKey(
                name: "pk_vendor_hours",
                table: "vendor_hours");

            migrationBuilder.DropPrimaryKey(
                name: "pk_street_vendor",
                table: "street_vendor");

            migrationBuilder.DropPrimaryKey(
                name: "pk_food_category",
                table: "food_category");

            migrationBuilder.DropPrimaryKey(
                name: "pk_food",
                table: "food");

            migrationBuilder.DropColumn(
                name: "opening_hours",
                table: "street_vendor");

            migrationBuilder.RenameTable(
                name: "vendor_hours",
                newName: "vendor_hours_db_set");

            migrationBuilder.RenameTable(
                name: "street_vendor",
                newName: "street_vendor_db_set");

            migrationBuilder.RenameTable(
                name: "food_category",
                newName: "food_category_db_set");

            migrationBuilder.RenameTable(
                name: "food",
                newName: "food_db_set");

            migrationBuilder.RenameIndex(
                name: "ix_food_category_food_id",
                table: "food_category_db_set",
                newName: "ix_food_category_db_set_food_id");

            migrationBuilder.RenameIndex(
                name: "ix_food_street_vendor_vendor_id",
                table: "food_db_set",
                newName: "ix_food_db_set_street_vendor_vendor_id");

            // migrationBuilder.AlterColumn<string>(
            //     name: "price_range",
            //     table: "street_vendor_db_set",
            //     type: "text",
            //     nullable: true,
            //     oldClrType: typeof(List<int>),
            //     oldType: "integer[]",
            //     oldNullable: true);

            migrationBuilder.DropColumn(
                name: "price_range",
                table: "street_vendor");

            migrationBuilder.AddColumn<string> (
                name: "price_range",
                table: "street_vendor",
                type: "text",
                nullable: true);

            migrationBuilder.AddColumn<double>(
                name: "average_rating",
                table: "street_vendor_db_set",
                type: "double precision",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<string>(
                name: "street_vendor_vendor_id",
                table: "food_category_db_set",
                type: "text",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "pk_vendor_hours_db_set",
                table: "vendor_hours_db_set",
                column: "vendor_hours_info");

            migrationBuilder.AddPrimaryKey(
                name: "pk_street_vendor_db_set",
                table: "street_vendor_db_set",
                column: "vendor_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_food_category_db_set",
                table: "food_category_db_set",
                column: "food_category_id");

            migrationBuilder.AddPrimaryKey(
                name: "pk_food_db_set",
                table: "food_db_set",
                column: "food_id");

            migrationBuilder.CreateIndex(
                name: "ix_food_category_db_set_street_vendor_vendor_id",
                table: "food_category_db_set",
                column: "street_vendor_vendor_id");

            migrationBuilder.AddForeignKey(
                name: "fk_food_category_db_set_food_db_set_food_id",
                table: "food_category_db_set",
                column: "food_id",
                principalTable: "food_db_set",
                principalColumn: "food_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_food_category_db_set_street_vendor_db_set_street_vendor_ven",
                table: "food_category_db_set",
                column: "street_vendor_vendor_id",
                principalTable: "street_vendor_db_set",
                principalColumn: "vendor_id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "fk_food_db_set_street_vendor_db_set_street_vendor_vendor_id",
                table: "food_db_set",
                column: "street_vendor_vendor_id",
                principalTable: "street_vendor_db_set",
                principalColumn: "vendor_id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
