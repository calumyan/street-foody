using Microsoft.EntityFrameworkCore;  
namespace street_foody.Models {     
public class Context : DbContext     
  {         
    public Context(DbContextOptions<Context> options): base(options)         
{ 
          
}       
    // public DbSet<Vendor> VendorDbSet { get; set; }     
    
    // public DbSet<StreetVendor> StreetVendorDbSet { get; set; } 

    public  DbSet<StreetVendor> StreetVendorDbSet { get; set;}
    public DbSet<Food> FoodDbSet { get; set; }     
    public DbSet<FoodCategory> FoodCategoryDbSet { get; set; }     
  
    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     modelBuilder.Entity<Vendor>().HasData(
    //         // new Vendor{ID = "1", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593"},
    //         // new Vendor{ID = "2", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593"},
    //         // new Vendor{ID = "3", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593"}
    //     );
    // }

   } 
}