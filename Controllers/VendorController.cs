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

        public IActionResult Index()
        {
            string id = "5";
            vendor = _context.StreetVendor.Single(v => v.VendorID == id);
            vendor.VendorHours = _context.VendorHours.Where(h => h.VendorID == id).ToList();
            vendor.SetAverageRating();
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

