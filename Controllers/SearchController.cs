
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
using Npgsql;
using System.Text;

namespace street_foody.Controllers
{
    [Route("search")] 
    [ApiController]  
    public class SearchController : Controller
    {
      private readonly Context _context; 
    //   private List<StreetVendor> allVendors;         
        public SearchController(Context context){     
               _context = context;
               

        } 

        [Route("index")] 
        public IActionResult Index(string SearchValue) {
            Console.WriteLine("blabla " + SearchValue);
            string SelectValue = Request.Query["sort"].ToString();
            if (String.IsNullOrWhiteSpace(SearchValue)) {
                return GetAll();
            }
            else if (SelectValue.Equals("highestRated")) {
                Console.WriteLine("hi");

                return GetVendorsSortedByRating();
            }
            else if(SelectValue.Equals("lowestPrice")) {
                 Console.WriteLine("hi2");
                 return GetVendorsSortedByPrice();
            }
            return ShowResults(SearchValue);
        }

        [Route("vender")] 
        public IActionResult Vendor() {
            return View();
        }

        private IActionResult ShowResults(string SearchValue) {
            Console.WriteLine("ShowResults executed");
            Expression<Func<StreetVendor, bool>> lambda = v => v.StandVietnameseName.ToString().Contains(SearchValue);
            var results = _context.StreetVendor.Where(lambda).ToList();
            
            if (results == null) {
                return NotFound();
            }
            return View("Index", results);
        }
        
        [Route("getAll")] 
        [HttpGet] 
        private IActionResult GetAll(){    
            // This method can (and should) be rewritten using LINQ to make things look much simpler.
            // List<StreetVendor> allVendors = _context.StreetVendor.ToList();
            var cs = "Host=localhost;Username=postgres;Password=street-foody;Database=street-foody";
            List<StreetVendor> allVendors =  _context.StreetVendor.ToList();
            for(int i  =0; i < allVendors.Count; i++){
                Console.WriteLine(allVendors.ElementAt(i));
            }
            
            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            // cmd.Connection = con;
            foreach (var vendor in allVendors) {
                string vendorID = vendor.VendorID;
                cmd.CommandText = "SELECT * FROM \"food_category_db_set\" WHERE \"street_vendor_vendor_id\"=@vendorID";
                cmd.Parameters.AddWithValue("@vendorID", vendorID);
                using NpgsqlDataReader rdr = cmd.ExecuteReader();
                List<FoodCategory> categories = new List<FoodCategory>();
                int i = 10;
                while (rdr.Read()) {
                    FoodCategory category = new FoodCategory($"{i}", rdr.GetString(1));
                    categories.Add(category);
                }
                vendor.FoodCategories = categories;
            }
            Console.WriteLine("GetAll executed");
            return View("Index", allVendors); 
        }

        private IActionResult GetVendorsSortedByPrice(){
            List<StreetVendor> allVendors =  _context.StreetVendor.ToList();
            List<StreetVendor> sorted = allVendors.OrderBy(sv => (sv.PriceRange[1] + sv.PriceRange[0]/2)).ToList();
            return View("Index", sorted); 
        }
        
        private IActionResult GetVendorsSortedByRating(){
            List<StreetVendor> allVendors =  _context.StreetVendor.ToList();
            List<StreetVendor> sorted = allVendors.OrderByDescending(sv => sv.GetAverageRating()).ToList();
            return View("Index", sorted); 
        }
        
        
    }

    
}