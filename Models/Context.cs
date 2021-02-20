using Microsoft.EntityFrameworkCore;  
namespace street_foody.Models {     
public class Context : DbContext     
  {         
    public Context(DbContextOptions<Context> options): base(options)         
{ 
          
}       
    public DbSet<Vendor> VendorDbSet { get; set; }     
  
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
    
    // modelBuilder.Entity<Book>().HasData(
    //     new Book { BookId = 1, AuthorId = 1, Title = "Hamlet" },
    //     new Book { BookId = 2, AuthorId = 1, Title = "King Lear" },
    //     new Book { BookId = 3, AuthorId = 1, Title = "Othello" }
    // );
        modelBuilder.Entity<Vendor>().HasData(
            new Vendor{ID = "1", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593"},
            new Vendor{ID = "2", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593"},
            new Vendor{ID = "3", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593"}
        );
  }

   } 
}