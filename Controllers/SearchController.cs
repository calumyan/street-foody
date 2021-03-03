
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
    [Route("[controller]")]    
    [ApiController]  
   
    public class SearchController : Controller
    {
      private readonly Context _context;          
        public SearchController(Context context){     
               _context = context;
        } 

        public IActionResult Index(string SearchValue) {
            if (SearchValue == "" || SearchValue == null) {
                return GetAll();
            }
            return ShowResults(SearchValue);
        }

        // public IActionResult Vendor() {
        //     return View();
        // }

        [HttpGet("{SearchValue}")]
        public IActionResult ShowResults(string SearchValue) {
            Console.WriteLine("ShowResults executed");
            Expression<Func<StreetVendor, bool>> lambda = v => v.StandVietnameseName.ToString().Contains(SearchValue);
            var results = _context.StreetVendorDbSet.Where(lambda).ToList();
            if (results == null) {
                return NotFound();
            }
            
            return View("Index", results);
        }
        
        [HttpGet("GetAll")]
        public IActionResult GetAll(){    
            List<StreetVendor> allVendors = _context.StreetVendorDbSet.ToList();
            var cs = "Host=localhost;Username=postgres;Password=street-foody;Database=street-foody";
            
            using var con = new NpgsqlConnection(cs);
            con.Open();

            using var cmd = new NpgsqlCommand();
            cmd.Connection = con;
            foreach (var vendor in allVendors) {
                string vendorID = vendor.VendorID;
                cmd.CommandText = "SELECT * FROM \"FoodCategoryDbSet\" WHERE \"StreetVendorVendorID\"=@vendorID";
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
    }
}