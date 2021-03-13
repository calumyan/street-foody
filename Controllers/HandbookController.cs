using Microsoft.AspNetCore.Mvc;

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