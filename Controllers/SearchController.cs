
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using street_foody.Models;


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

            //the result list of vendors resulted from every action (sort, search etc.), put it into the starting list of vendors everytime of next action
            List<StreetVendor> result;
            List<StreetVendor> allVendors = GetAll();

            if (String.IsNullOrWhiteSpace(SearchValue))
            {
                result = allVendors;
            }
            else
            {
                result = GetSearchedResults(SearchValue, allVendors);
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

        // TODO: Implement search algorithm here. There can be method decomposition.


        private List<StreetVendor> GetAll()
        {
            allVendors = _context.StreetVendor.ToList();
            foreach (StreetVendor streetVendor in allVendors)
            {
                streetVendor.SetAverageRating();
            }
            return allVendors;
        }

        // This function should return the final search result. 
        private List<StreetVendor> GetSearchedResults(string SearchValue, List<StreetVendor> vendors)
        {
            // Expression<Func<StreetVendor, bool>> lambda = streetVendor => streetVendor.EnglishName.Contains(SearchValue) || streetVendor.StandVietnameseName.Contains(SearchValue);
            // allVendors = _context.StreetVendor.Where(lambda).ToList();
            bool toBeAdded = false;
            List<StreetVendor> matchedVendors = new List<StreetVendor>();
            foreach (StreetVendor streetVendor in vendors)
            {
                if (streetVendor.EnglishName.Contains(SearchValue) || streetVendor.VietnameseName.Contains(SearchValue)) toBeAdded = true;
                ICollection<Food> Foods = new Collection<Food>();
                Food f = new Food { FoodID = "1", VietnameseName = "Ba", FoodCategory = new FoodCategory("1", "Súp") };
                Foods.Add(f);

                foreach (Food food in Foods)
                {
                    // if (food != null)
                    // {
                        FoodCategory foodCategory = food.FoodCategory;
                        if (foodCategory != null && foodCategory.EnglishName != null && foodCategory.VietnameseName != null)
                        {
                            if (foodCategory.EnglishName.Contains(SearchValue) || foodCategory.VietnameseName.Contains(SearchValue))
                            {
                                toBeAdded = true;
                            }

                        }

                    // }

                }
                if (toBeAdded) matchedVendors.Add(streetVendor);

            }

            return matchedVendors;
        }

        //function to get Vendors of the vendors sorted by their price range (mean of highest and lowest prices of each vendor)
        private List<StreetVendor> GetVendorsSortedByPrice(List<StreetVendor> vendors)
        {
            List<StreetVendor> sortedVendors = vendors.OrderBy(streetVendor => (streetVendor.PriceRange[1] + streetVendor.PriceRange[0]) / 2).ToList();
            return sortedVendors;
        }

        //function to get Vendors of the vendors sorted by their ratings
        private List<StreetVendor> GetVendorsSortedByRating(List<StreetVendor> vendors)
        {
            List<StreetVendor> sortedVendors = vendors.OrderByDescending(streetVendor => streetVendor.AverageRating).ToList();
            return sortedVendors;
        }

        // private IActionResult GetOpenedVendors(List<StreetVendor> vendors){
        //     // allVendors = _context.StreetVendor.ToList();
        //     List<StreetVendor> opened = new List<StreetVendor>();
        //     string curTime = DateTime.Now.ToString("hh:mm");
        //     Console.WriteLine(curTime);
        //     int curr = GetTime(curTime.Split(":"));
        //     var openedVendors = from streetVendor in _context.StreetVendor select streetVendor where streetVendor.Ven;
        //     // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?)
        //     foreach(StreetVendor streetVendor in vendors){
        //         // if(streetVendor.OpeningHours == null) continue;

        //         select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?)
        //         string startTime = streetVendor.OpeningHours[0];
                //         string endTime = streetVendor.OpeningHours[1];
        //         int start = GetTime(startTime.Split(":"));
        //         int end = GetTime(endTime.Split(":"));
        //         if(start >= curr && end >= curr) opened.Add(streetVendor); 
        //     }
        //     return View("Index", opened); 
        // }

        // private List<StreetVendor> GetVendorsEqualsTo5(List<StreetVendor> vendors){
        //     List<StreetVendor> vendorsGreaterThan5 = new List<StreetVendor>();
        //     foreach(StreetVendor streetVendor in vendors){
        //         if(streetVendor.AverageRating == 5.0){
        //             vendorsGreaterThan5.Add(streetVendor);
        //         }
        //     }
        //     return vendorsGreaterThan5;
        // }

        //  private List<StreetVendor> GetVendorsGreaterEquals4(List<StreetVendor> vendors){
        //     List<StreetVendor> vendorsGreaterThan4 = new List<StreetVendor>();
        //     foreach(StreetVendor streetVendor in vendors){
        //         if(streetVendor.AverageRating >= 4 && streetVendor.AverageRating < 5){
        //             vendorsGreaterThan4.Add(streetVendor);
        //         }
        //     }
        //     return vendorsGreaterThan4;
        // }

        //  private List<StreetVendor> GetVendorsGreaterEquals3(List<StreetVendor> vendors){
        //     List<StreetVendor> vendorsGreaterThan3 = new List<StreetVendor>();
        //     foreach(StreetVendor streetVendor in vendors){
        //         if(streetVendor.AverageRating >= 3 && streetVendor.AverageRating < 4){
        //             vendorsGreaterThan3.Add(streetVendor);
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