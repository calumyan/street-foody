
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using street_foody.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

// [Route("api/[controller]")]    
// [ApiController]  
namespace street_foody.Controllers
{
   
    public class SearchController : Controller
    {
        private readonly Context _context;          

        public SearchController(Context context){     
               _context = context;   
        } 

        public IActionResult Index() {
            return View();
        }

        public IActionResult Vendor() {
            return View();
        }

        public async Task<IActionResult> ShowResults(string SearchValue) {
            Expression<Func<StreetVendor, bool>> lambda = v => v.FoodCategories.ToString().Contains(SearchValue) || v.StandEnglishName.ToString().Contains(SearchValue);
            return View("Index", await _context.StreetVendorDbSet.Where(lambda).ToListAsync());
        }
      
       
       [HttpGet] 
        public ActionResult<List<StreetVendor>> GetAll(){     
                return _context.StreetVendorDbSet.ToList(); 
        }
      }

}