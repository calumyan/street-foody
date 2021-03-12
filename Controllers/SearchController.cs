using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using street_foody.Models;

namespace street_foody.Controllers
{
    [Route("Search")]
    [ApiController]
    public class SearchController : Controller
    {
        private readonly Context _context;
        public SearchController(Context context)
        {
            _context = context;
        }


        /// <summary> Renders a list of street vendors with searching and sorting.
        /// </summary>
        public IActionResult Index(string SearchValue)
        {
            ViewBag.SearchValue = SearchValue;
            string SelectValue = null;

            //the result list of vendors resulted from every action (sort, search etc.), put it into the starting list of vendors everytime of next action.
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
            { }
            if (SelectValue != null)
            {
                if (SelectValue.Equals("highestRated"))
                {

                    result = VendorsSortedByRating(result);
                }
                else if (SelectValue.Equals("lowestPrice"))
                {
                    result = VendorsSortedByPrice(result);
                }

            }
            return View("Index", result);

        }

        [Route("Vendor")]
        public IActionResult Vendor()
        {
            StreetVendor vendor;
            string id = "5";
            vendor = _context.StreetVendor.Where(v => v.VendorID == id).FirstOrDefault();
            vendor.VendorHours = _context.VendorHours.Where(h => h.VendorID == id).ToList();
            vendor.SetAverageRating();
            return View(vendor);
        }

        private IActionResult NoResult()
        {
            return View();
        }

        private List<StreetVendor> GetAll()
        {
            // Eager loads all vendors as well as their menu and food categories.
            List<StreetVendor> allVendors = _context.StreetVendor.Include(v => v.Foods)
                                                                .ThenInclude(f => f.FoodCategory).ToList();
            foreach (StreetVendor streetVendor in allVendors)
            {   
                streetVendor.SetAverageRating();

                if (streetVendor.Foods == null) {
                    break;
                }

                streetVendor.FoodCategories = new List<FoodCategory>();
                foreach (Food food in streetVendor.Foods) {
                    FoodCategory category = food.FoodCategory;
                    if (!streetVendor.FoodCategories.Contains(category)) {
                        streetVendor.FoodCategories.Add(category);
                    }
                }
            }
            return allVendors;
        }

        /// <summary> Returns a list of street vendors whose names match the search input. Search value matches vendor's food/vendor's food 
        /// category english and vietnamese name with search value.
        /// Search is case insensitive.
        /// </summary>
        private List<StreetVendor> GetSearchedResults(string SearchValue, List<StreetVendor> vendors)
        {
            List<StreetVendor> matchedVendors = new List<StreetVendor>();
            foreach (StreetVendor vendor in vendors)
            {   
                string SearchValueLowerCase = SearchValue.ToLower();                
                if (NameMatchWithSearchValue(vendor.EnglishName, vendor.VietnameseName, SearchValueLowerCase)) {
                    matchedVendors.Add(vendor);
                }

                if (vendor.Foods == null) {
                    return matchedVendors;
                }

                bool toBeAdded = false;
                foreach (Food food in vendor.Foods)
                {
                    if (NameMatchWithSearchValue(food.VietnameseName, food.EnglishName, SearchValueLowerCase)) toBeAdded = true;
                    FoodCategory foodCategory = food.FoodCategory;
                    if (foodCategory != null)
                    {
                        if (NameMatchWithSearchValue(foodCategory.VietnameseName, foodCategory.EnglishName, SearchValueLowerCase)) toBeAdded = true;
                    }
                }
                if (toBeAdded && !matchedVendors.Contains(vendor)) matchedVendors.Add(vendor);
            }

            return matchedVendors;
        }

        /// <summary> Returns true if either Vietnamese Name or English Name matches with the lowercase SearchValue.  
        ///</summary>
        private bool NameMatchWithSearchValue(string VietnameseName, string EnglishName, string SearchValueLowerCase)
        {
            string EnglishNameLowerCase = EnglishName == null ? "" : EnglishName.ToLower();
            string VietnameseNameLowerCase = VietnameseName == null ? "" : VietnameseName.ToLower();
            return EnglishNameLowerCase.Contains(SearchValueLowerCase) || VietnameseNameLowerCase.Contains(SearchValueLowerCase);
        }
        private List<StreetVendor> VendorsSortedByPrice(List<StreetVendor> vendors)
        {
            // Note: For vendors whose price range we have no data for, we seed in a length 2 array
            //       of positive infinite values. Therefore, PriceRange array is made sure to be of length 2.
            return vendors.OrderBy(streetVendor => (streetVendor.PriceRange[1] + streetVendor.PriceRange[0]) / 2).ToList();
        }

        private List<StreetVendor> VendorsSortedByRating(List<StreetVendor> vendors)
        {
            return vendors.OrderByDescending(streetVendor => streetVendor.AverageRating).ToList();
        }
    }

}