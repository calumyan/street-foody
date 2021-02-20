using Microsoft.EntityFrameworkCore.Migrations;

namespace street_foody.Migrations
{
    public partial class initials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {

            
            migrationBuilder.CreateTable(
                name: "VendorDbSet",
                columns: table => new
                {
                    ID = table.Column<string>(type: "text", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    Location = table.Column<string>(type: "text", nullable: true),
                    Phone = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorDbSet", x => x.ID);
                });


     

            // var Vendors = new List<Vendor>{
            //   new Vendor{ID = "1", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593",  Description = "Trust me: Uncle Tu is the friendliest banh mi vendor you can find on earth!"},
            //   new Vendor{ID = "2", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593",  Description = "Trust me: Uncle Tu is the friendliest banh mi vendor you can find on earth!"},
            //   new Vendor{ID = "3", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593",  Description = "Trust me: Uncle Tu is the friendliest banh mi vendor you can find on earth!"}
            // };


            //  migrationBuilder.InsertData(table: "VendorDbSet",
            //  columns: new[] { "ID", "Name", "Location", "Phone" },
            //  values: new object[] { "1", "Uncle Tu's Bahn Mi", "123 Ly Thai To, Ward 12, District 10, HCMC",  "84 9024728593" });


        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VendorDbSet");
        }

  
    }
}
