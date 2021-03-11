
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using street_foody.Models;

// [Route("api/[controller]")]    
// [ApiController]  
namespace street_foody.Controllers
{
    public class HandbookController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.IsHome = true;
            return View();
        }
    }

}