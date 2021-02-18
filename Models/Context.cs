using Microsoft.EntityFrameworkCore;  
namespace street_foody.Models {     
public class Context : DbContext     
  {         
    public Context(DbContextOptions<Context> options): base(options)         
{ 
          
}       
    public DbSet<Vendor> VendorDbSet { get; set; }     
  
   } 
}