
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
    
        // Context context;
        // public SearchController(Context context){     
        //        context = new Context();
        // } 

        public IActionResult Index() {
            return View();
        }

        public IActionResult Vendor() {
            return View();
        }

        // public async Task<IActionResult> ShowResults(string SearchValue) {
        //     Expression<Func<StreetVendor, bool>> lambda = v => v.FoodCategories.ToString().Contains(SearchValue) || v.StandEnglishName.ToString().Contains(SearchValue);
        //     var results = await _context.StreetVendorDbSet.Where(lambda).ToListAsync();
        //     if (results == null) {
        //         return NotFound();
        //     }
        //     return View("Index", results);
        // }
        
    //    [HttpGet] 
        public IActionResult GetAll(){    
            List<StreetVendor> vendors = new List<StreetVendor>();

            FoodCategory category = new FoodCategory("Bánh mì");
            FoodCategory category1 = new FoodCategory("Bánh bao");

            List<FoodCategory> categories = new List<FoodCategory>();
            categories.Add(category);
            categories.Add(category1);

            StreetVendor vendor1 = new StreetVendor("Bánh mì chú Tư", categories, 4.8, "12,000đ - 20,000đ");
            vendors.Add(vendor1);

            FoodCategory category2 = new FoodCategory("Bánh mì");
            FoodCategory category3 = new FoodCategory("Bánh bao");

            List<FoodCategory> categories1 = new List<FoodCategory>();
            categories1.Add(category2);
            categories1.Add(category3);

            StreetVendor vendor2 = new StreetVendor("Súp cua LHP", categories1, 4.6, "15,000đ - 25,000đ");
            vendors.Add(vendor2);

            StreetVendor vendor3 = new StreetVendor("Súp cua LHP", categories1, 4.6, "15,000đ - 25,000đ");
            vendors.Add(vendor3);

            StreetVendor vendor4 = new StreetVendor("Súp cua LHP", categories1, 4.6, "15,000đ - 25,000đ");
            vendors.Add(vendor4);

            StreetVendor vendor5 = new StreetVendor("Súp cua LHP", categories1, 4.6, "15,000đ - 25,000đ");
            vendors.Add(vendor5);
            // var vendors = await _context.StreetVendorDbSet.ToListAsync();
            // Debug.Print(vendors.ToString());
            // if (vendors == null) {
            //     return Content("null");
            // } else {
            //     return Content(vendors.ToString());
            // }
            return View("Index", vendors); 
        }
      }

}