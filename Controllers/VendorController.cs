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
         } 

<<<<<<< HEAD
[HttpGet] 
public ActionResult<List<Vendor>> GetAll(){     
   return _context.VendorDbSet.ToList(); 
}
   
} 
=======
      [HttpGet] 
      public ActionResult<List<Vendor>> GetAll(){     
         return _context.VendorDbSet.ToList(); 
      }

   } 
>>>>>>> ed9d7d5e5f0c244abbde13c5513650a84970d69b

}