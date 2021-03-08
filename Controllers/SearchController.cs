
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
        public SearchController(Context context)
        {
            _context = context;
            allVendors = new List<StreetVendor>();
        }
         
        
        public IActionResult Index(string SearchValue)
        {
            ViewBag.SearchValue = SearchValue;
            string SelectValue = null;
            List<StreetVendor> result;

            if (String.IsNullOrWhiteSpace(SearchValue))
            {
                result = GetAll();
            }
            else
            {
                result = GetSearchedResults(SearchValue);
            }
            try
            {
                SelectValue = Request.Form["sort"];
            }
            catch
            {
                Console.WriteLine("no value selected");
            }
            if (SelectValue != null)
            {
                if (SelectValue.Equals("highestRated"))
                {

                    result = GetVendorsSortedByRating(result);
                }
                else if (SelectValue.Equals("lowestPrice"))
                {
                    result = GetVendorsSortedByPrice(result);
                }

            }
            return View("Index", result);

        }

        [Route("Vendor")]
        public IActionResult Vendor()
        {
            return View();
        }

        // [Route("Sort")]
        // public IActionResult Sort() {
        //     string SelectValue = Request.Form["sort"];
        //     if (SelectValue.Equals("highestRated")) {
        //         return GetVendorsSortedByRating();
        //     }
        //     else if(SelectValue.Equals("lowestPrice")) {
        //         return GetVendorsSortedByPrice();
        //     } else {
        //         return GetAll();
        //     }
        // }

        // [Route("Filter")]
        // public IActionResult Filter(){
        //     string FilterValue = Request.Form["filter"];
        //     if (FilterValue.Equals("open-now")) {
        //         return GetOpenedVendors();
        //     }
        //     else {
        //         return GetAll();
        //     }
        // }

        //does not return a result when 
        private IActionResult NoResult()
        {
            return View();
        }
        
        // private IActionResult Show(){
        //     if()
        // }
    
        // TODO: Implement search algorithm here. There can be method decomposition.
        // This function should return the final search result. 
        private List<StreetVendor> ShowSearchedResults(string SearchValue) {
            Expression<Func<StreetVendor, bool>> lambda = sv => sv.StandEnglishName.Contains(SearchValue) || sv.StandVietnameseName.Contains(SearchValue);
            allVendors = _context.StreetVendor.Where(lambda).ToList();
            foreach (StreetVendor vendor in allVendors) {
                vendor.GetAverageRating();
            }
            return allVendors;
        }
        
        private List<StreetVendor> GetAll(){    
            allVendors = _context.StreetVendor.ToList();
            foreach (StreetVendor vendor in allVendors)
            {
                vendor.GetAverageRating();
            }
            return allVendors;
        }
        
        //function to get all of the vendors that match the search input
        private List<StreetVendor> GetSearchedResults(string SearchValue)
        {
            Expression<Func<StreetVendor, bool>> lambda = sv => sv.StandEnglishName.Contains(SearchValue) || sv.StandVietnameseName.Contains(SearchValue);
            // for(StreetVendor sv in allVendors){
            //     if(sv.StandEnglishName.Contains(SearchValue) || sv.StandVietnameseName.Contains(SearchValue) || sv.M)
            // }
            List<StreetVendor> searchedResults = _context.StreetVendor.Where(lambda).ToList();
            foreach (StreetVendor vendor in searchedResults)
            {
                vendor.GetAverageRating();
            }
            return searchedResults;
        }
        
        //function to get all of the vendors sorted by their price range (mean of highest and lowest prices of each vendor)
        private List<StreetVendor> GetVendorsSortedByPrice(List<StreetVendor> vendors)
        {
            List<StreetVendor> sortedVendors = vendors.OrderBy(sv => (sv.PriceRange[1] + sv.PriceRange[0]) / 2).ToList();
            return sortedVendors;
        }
        
        //function to get all of the vendors sorted by their ratings
        private List<StreetVendor> GetVendorsSortedByRating(List<StreetVendor> vendors)
        {
            List<StreetVendor> sortedVendors = vendors.OrderByDescending(sv => sv.GetAverageRating()).ToList();
            return sortedVendors;
        }

        // private IActionResult GetOpenedVendors(List<StreetVendor> vendors){
        //     // allVendors = _context.StreetVendor.ToList();
        //     List<StreetVendor> opened = new List<StreetVendor>();
        //     string curTime = DateTime.Now.ToString("hh:mm");
        //     Console.WriteLine(curTime);
        //     int curr = GetTime(curTime.Split(":"));
        //     // foreach(){
        //         // if(sv.OpeningHours == null) continue;
        //         // string startTime = sv.OpeningHours[0];
        //         // string endTime = sv.OpeningHours[1];
        //         // int start = GetTime(startTime.Split(":"));
        //         // int end = GetTime(endTime.Split(":"));
        //         // if(start >= curr && end >= curr) opened.Add(sv); 
        //     // }
        //     return View("Index", opened); 
        // }

        // private int GetTime(string[] splitted){
        //     string hour = splitted[0];
        //     string minute = splitted[1];
        //     int h = Int32.Parse(hour);
        //     int m = Int32.Parse(minute)/60;
        //     return h + m;
        // }



    }

}