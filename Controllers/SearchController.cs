
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
            // string CheckBoxValue = null;
            List<StreetVendor> result;
            List<StreetVendor> all = GetAll();

            if (String.IsNullOrWhiteSpace(SearchValue))
            {
                result = all;
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
            // try
            // {
            //     CheckBoxValue = Request.Form["price"];
            // }
            // catch
            // {
            //     Console.WriteLine("no value selected");
            // }
            // if (CheckBoxValue!=null)
            // {
            //     if (CheckBoxValue.Equals(""))
            //     {
            //         result = GetVendorsEqualsTo5(result);
            //     }
            //     else if (CheckBoxValue.Equals(""))
            //     {
            //         result = GetVendorsGreaterEquals4(result);
            //     }
            //     else{
            //         result = GetVendorsGreaterEquals3(result);
            //     }

            // }

           



            // if(SearchValue != null){

            // }
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

        //function to get all of the vendors 
        private List<StreetVendor> GetAll()
        {
            allVendors = _context.StreetVendor.ToList();
            foreach (StreetVendor vendor in allVendors)
            {
                vendor.SetAverageRating();
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
                vendor.SetAverageRating();
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
            List<StreetVendor> sortedVendors = vendors.OrderByDescending(sv => sv.AverageRating).ToList();
            return sortedVendors;
        }

        // private IActionResult GetOpenedVendors(List<StreetVendor> vendors){
        //     // allVendors = _context.StreetVendor.ToList();
        //     List<StreetVendor> opened = new List<StreetVendor>();
        //     string curTime = DateTime.Now.ToString("hh:mm");
        //     Console.WriteLine(curTime);
        //     int curr = GetTime(curTime.Split(":"));
        //     var openedVendors = from sv in _context.StreetVendor select sv where sv.Ven;
        //     // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?)
        //     foreach(StreetVendor sv in vendors){
        //         // if(sv.OpeningHours == null) continue;
                
        //         select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?)
        //         string startTime = sv.OpeningHours[0];
        //         string endTime = sv.OpeningHours[1];
        //         int start = GetTime(startTime.Split(":"));
        //         int end = GetTime(endTime.Split(":"));
        //         if(start >= curr && end >= curr) opened.Add(sv); 
        //     }
        //     return View("Index", opened); 
        // }

        // private List<StreetVendor> GetVendorsEqualsTo5(List<StreetVendor> vendors){
        //     List<StreetVendor> vendorsGreaterThan5 = new List<StreetVendor>();
        //     foreach(StreetVendor sv in vendors){
        //         if(sv.AverageRating == 5.0){
        //             vendorsGreaterThan5.Add(sv);
        //         }
        //     }
        //     return vendorsGreaterThan5;
        // }

        //  private List<StreetVendor> GetVendorsGreaterEquals4(List<StreetVendor> vendors){
        //     List<StreetVendor> vendorsGreaterThan4 = new List<StreetVendor>();
        //     foreach(StreetVendor sv in vendors){
        //         if(sv.AverageRating >= 4 && sv.AverageRating < 5){
        //             vendorsGreaterThan4.Add(sv);
        //         }
        //     }
        //     return vendorsGreaterThan4;
        // }

        //  private List<StreetVendor> GetVendorsGreaterEquals3(List<StreetVendor> vendors){
        //     List<StreetVendor> vendorsGreaterThan3 = new List<StreetVendor>();
        //     foreach(StreetVendor sv in vendors){
        //         if(sv.AverageRating >= 3 && sv.AverageRating < 4){
        //             vendorsGreaterThan3.Add(sv);
        //         }
        //     }
        //     return vendorsGreaterThan3;
        // }
        // private List<StreetVendor> GetVendorsByRatingsThreshold(){
            
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