using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using System.Linq; 
using street_foody.Models;  
namespace street_foody.Controllers {     
[Route("api/[controller]")]     
[ApiController]     
public class VendorController : ControllerBase     
{        
private readonly Context _context;          
public VendorController(Context context){  
                     
          _context = context;   
        //   var Vendors = new List<Vendor>{
        //       new Vendor{ID = "1", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593",  Description = "Trust me: Uncle Tu is the friendliest banh mi vendor you can find on earth!"},
        //       new Vendor{ID = "2", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593",  Description = "Trust me: Uncle Tu is the friendliest banh mi vendor you can find on earth!"},
        //       new Vendor{ID = "3", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593",  Description = "Trust me: Uncle Tu is the friendliest banh mi vendor you can find on earth!"}
        //   };
        //   _context.VendorDbSet.AddRange(Vendors);
        //   _context.SaveChanges();
        //   System.Diagnostics.Debug.WriteLine("SomeText");
     } 

[HttpGet] 
public ActionResult<List<Vendor>> GetAll(){     
   return _context.VendorDbSet.ToList(); 
}

// [HttpPost]
// public void Create()
// {
//               var Vendors = new List<Vendor>{
//               new Vendor{ID = "1", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593",  Description = "Trust me: Uncle Tu is the friendliest banh mi vendor you can find on earth!"},
//               new Vendor{ID = "2", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593",  Description = "Trust me: Uncle Tu is the friendliest banh mi vendor you can find on earth!"},
//               new Vendor{ID = "3", Name = "Uncle Tu's Bahn Mi", Location = "123 Ly Thai To, Ward 12, District 10, HCMC", Phone = "84 9024728593",  Description = "Trust me: Uncle Tu is the friendliest banh mi vendor you can find on earth!"}
//             };
//             _context.VendorDbSet.AddRange(Vendors);
//             _context.SaveChanges();

// }
    
} 

 

// public ActionResult<Vendor> 
}