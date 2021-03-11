
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using street_foody.Models;

namespace street_foody.Controllers
{
    [Route("Handbook")]
    [ApiController]
    public class HandbookController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.IsHome = true;
            return View();
        }
    }

}