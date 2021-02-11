using Microsoft.EntityFrameworkCore;  
namespace street_foody.Models {     
public class UserContext : DbContext     
  {         
    public UserContext(DbContextOptions<UserContext> options): base(options)         
{         
}       
    public DbSet<User> UserDbSet { get; set; }     
  
   } 
}