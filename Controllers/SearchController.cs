
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


namespace street_foody.Controllers
{

   
    [Route("api/search")] 
    [ApiController]  
    public class SearchController : Controller
    {
        //  private readonly IConfiguration _configuration;
        //  private string _connectionString;
        // DbContextOptionsBuilder<ApplicationDbContext> _optionsBuilder;
        
        // DbContextOptionsBuilder<Context> optionsBuilder = new DbContextOptionsBuilder<Context>();
        
       
        
        private readonly Context _context;
         
        public SearchController(Context context){
            //    optionsBuilder.UseNpgsql(Configuration.GetConnectionStringSecureValue("DefaultConnection"));
            //    _context = new Context(optionsBuilder.Options);   
               _context = context;
        } 
        
        [Route("index")] 
        public IActionResult Index() {
            return View();
        }

        [Route("vender")] 
        public IActionResult Vendor() {
            return View();
        }

        // public async Task<IActionResult> ShowResults(string SearchValue) {
        //     Expression<Func<StreetVendor, bool>> lambda = v => v.FoodCategories.ToString().Contains(SearchValue) || v.StandEnglishName.ToString().Contains(SearchValue);
        //     return View("Index", await _context.StreetVendorDbSet.Where(lambda).ToListAsync());
        // }
      
       

    //    [Route("getAll")]
       
       [Route("getAll")] 
       [HttpGet] 
        public ActionResult<List<StreetVendor>> GetAll(){ 
                List<StreetVendor> list =  _context.StreetVendor.ToList(); 
                // return _context.StreetVendorDbSet.ToList(); 
                for (int i = 0; i < list.Count; i++) 
                {
                    Console.WriteLine(list.ElementAt(i).VendorID);
                } 
                
                return _context.StreetVendor.ToList(); 
        }
      }
    

}