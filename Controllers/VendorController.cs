using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using street_foody.Models;
using Microsoft.EntityFrameworkCore;

namespace street_foody.Controllers
{
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
            StreetVendor vendor = _context.StreetVendor.Where(v => v.VendorID == ID)
                                        .Include(v => v.Foods)
                                        .ThenInclude(f => f.FoodCategory)  
                                        .ThenInclude(c => c.Foods.Where(f => f.VendorID == ID))
                                        .Include(v => v.VendorHours).FirstOrDefault();
            vendor.FoodCategories = new List<FoodCategory>();
            foreach (Food food in vendor.Foods) {
                FoodCategory category = food.FoodCategory;
                if (!vendor.FoodCategories.Contains(category)) {
                    vendor.FoodCategories.Add(category);
                }
            }
            return View(vendor);
        }

        private TimeSpan CalcTimeSpan(DateTime[] day)
        {
            TimeSpan timeSpan;
            if (day[1].CompareTo(day[0]) == 1)
            {
                timeSpan = day[1].Subtract(day[0]);
            }
            else
            {
                timeSpan = day[1].Subtract(day[0]).Add(TimeSpan.FromHours(24));
            }
            return timeSpan;
        }
    }
}

