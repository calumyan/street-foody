
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
    [Route("Search")] 
    [ApiController]  
    public class SearchController : Controller
    {
      private readonly Context _context; 
      public List<StreetVendor> allVendors;         
        public SearchController(Context context){     
               _context = context;
               allVendors = new List<StreetVendor>();
        } 

        [Route("")] 
        public IActionResult Index(string SearchValue) {
            ViewBag.SearchValue = SearchValue;
            if (String.IsNullOrWhiteSpace(SearchValue)) {
                return GetAll();
            }
            else {
                return ShowResults(SearchValue);
            }
        }

        [Route("Vendor")] 
        public IActionResult Vendor() {
            return View();
        }

        [Route("Sort")]
        public IActionResult Sort() {
            Console.WriteLine(allVendors.Count);
            string SelectValue = Request.Form["sort"];
            Console.WriteLine(SelectValue);
            if (SelectValue.Equals("highestRated")) {
                Console.WriteLine("hi");
                return GetVendorsSortedByRating();
            }
            else if(SelectValue.Equals("lowestPrice")) {
                 Console.WriteLine("hi2");
                return GetVendorsSortedByPrice();
            } else {
                return GetVendorsSortedByPrice();
            }
        }

        private IActionResult NoResult() {
            return View();
        }

        private IActionResult ShowResults(string SearchValue) {
            Expression<Func<StreetVendor, bool>> lambda = v => v.StandEnglishName.Contains(SearchValue) || v.StandVietnameseName.Contains(SearchValue);
            allVendors = _context.StreetVendor.Where(lambda).ToList();
            foreach (StreetVendor vendor in allVendors) {
                vendor.GetAverageRating();
            }
            return View("Index", allVendors);
        }
        
        private IActionResult GetAll(){    
            allVendors = _context.StreetVendor.ToList();
            foreach (StreetVendor vendor in allVendors) {
                vendor.GetAverageRating();
            }
            return View("Index", allVendors); 
        }

        private IActionResult GetVendorsSortedByPrice(){
            allVendors = _context.StreetVendor.ToList();
            List<StreetVendor> sorted = allVendors.OrderBy(sv => (sv.PriceRange[1] + sv.PriceRange[0])/2).ToList();
            return View("Index", sorted); 
        }
        
        private IActionResult GetVendorsSortedByRating(){
            allVendors = _context.StreetVendor.ToList();
            List<StreetVendor> sorted = allVendors.OrderByDescending(sv => sv.GetAverageRating()).ToList();
            return View("Index", sorted); 
        }
        
    }

}