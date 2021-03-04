using Microsoft.EntityFrameworkCore;  
namespace street_foody.Models {     
public class Context : DbContext     
  {         
    public Context(DbContextOptions<Context> options): base(options)         
{ 
          
}

    public  DbSet<StreetVendor> StreetVendor { get; set;}
    public DbSet<Food> Food { get; set; }     
    public DbSet<FoodCategory> FoodCategory { get; set; }     
    public DbSet<VendorHours> VendorHours { get; set; }     
  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<StreetVendor>().HasData(
            new StreetVendor{VendorID = "1", StandVietnameseName = "Uncle Myles's Bahn Mi"},
            new StreetVendor{VendorID = "2", StandVietnameseName = "Aunt Andie's Bahn Mi"},
            new StreetVendor{VendorID = "3", StandVietnameseName = "Aunt Carrie's Bahn Mi"},
            new StreetVendor{VendorID = "4", StandVietnameseName = "Aunt Lucy's Bahn Mi"}
        );
    }

    
   } 
}