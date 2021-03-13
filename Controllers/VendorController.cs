using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using street_foody.Models;
using Microsoft.EntityFrameworkCore;

namespace street_foody.Controllers
{
    /// <summary> 
    /// Controller for vendor pages. Get all data of an individual vendor
    /// from the ID passed in.
    /// </summary>
    [Route("Vendor")]
    [ApiController]
    public class VendorController : Controller
    {
        private readonly Context _context;
        public StreetVendor vendor;
        public VendorController(Context context)
        {
            _context = context;
        }

        public IActionResult Index(string ID)
        {
            // Eager loads the vendor with matching ID, including their location-hours pair(s),
            // categories and foods/dishes of each category.
            StreetVendor vendor = _context.StreetVendor.Where(v => v.VendorID == ID)
                                        .Include(v => v.Foods)
                                        .ThenInclude(f => f.FoodCategory)  
                                        .ThenInclude(c => c.Foods.Where(f => f.VendorID == ID))
                                        .Include(v => v.VendorHours)
                                        .OrderBy(c => c.EnglishName)
                                        .FirstOrDefault();
            vendor.FoodCategories = new List<FoodCategory>();
            foreach (Food food in vendor.Foods) {
                FoodCategory category = food.FoodCategory;
                if (!vendor.FoodCategories.Contains(category)) {
                    vendor.FoodCategories.Add(category);
                }
            }
            return View(vendor);
        }
    }
}

