using Microsoft.EntityFrameworkCore;  

namespace street_foody.Models {     
public class Context : DbContext     
  {         
    public Context(DbContextOptions<Context> options): base(options)         
{ 
          
}

    public  DbSet<StreetVendor> StreetVendorDbSet { get; set;}
    public DbSet<Food> FoodDbSet { get; set; }     
    public DbSet<FoodCategory> FoodCategoryDbSet { get; set; }     
    public DbSet<VendorHours> VendorHoursDbSet { get; set; }     
  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
               modelBuilder.Entity<StreetVendor>().HasData(
            new StreetVendor{VendorID = "1", StandVietnameseName = "Uncle Myles's Bahn Mi"},
            new StreetVendor{VendorID = "2", StandVietnameseName = "Aunt Andie's Bahn Mi"},
            new StreetVendor{VendorID = "3", StandVietnameseName = "Aunt Carrie's Bahn Mi"},
            new StreetVendor{VendorID = "4", StandVietnameseName = "Aunt Lucy's Bahn Mi"}
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder
        .UseNpgsql("Server=PostgreSQL;Host=localhost;Port=5432;Username=postgres;Password=street-foody;Database=street-foody;")
        .UseSnakeCaseNamingConvention();

   } 
}