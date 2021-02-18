using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using System.Linq; 
using street_foody.Models;  
namespace TodoApi.Controllers {     
[Route("api/[controller]")]     
[ApiController]     
public class TodoController : ControllerBase     
{        
private readonly Context _context;          
public TodoController(Context context){             
          _context = context;              
          _context.VendorDbSet.Add(new Vendor{ID = "1", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593",  Description = "Trust me: Uncle Tu is the friendliest banh mi vendor you can find on earth!"});
          _context.SaveChanges();
     }            
} 
}