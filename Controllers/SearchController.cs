
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using street_foody.Models;
using Microsoft.EntityFrameworkCore;

// [Route("api/[controller]")]    
// [ApiController]  
namespace street_foody.Controllers
{

   
    
    public class SearchController : Controller
    {
        private readonly Context _context;          

        public SearchController(Context context){     
               _context = context;   
        } 

        public IActionResult Index() {
            return View();
        }

        public IActionResult Vendor() {
            return View();
        }

        // public async Task<IActionResult> ShowResults(String SearchValue) {
        //     return View("Index", await _context.VendorDbSet.Where(v => v.StandEnglishName.Contains(SearchValue)).ToListAsync());
        // }
      
       
       [HttpGet] 
        public ActionResult<List<Vendor>> GetAll(){     
                return _context.VendorDbSet.ToList(); 
        }
          
//        Dictionary<string, int> map = new Dictionary<>();
//        public string getHighestScoreVendor(Vendor vendor){
             
//        }
       
       
//        public int getScore(string name){
//             int score = 0;
//             string[] words = name.Split(' ');
//             for(int i = 0; i < words.Length(); i++){
//                 string word = words[i];
//                 int count = map[word];
//                 score+=count;
//             }
//             return score;
//        }

// // String, In
//        public Dictionary<string, int> getCount(string searchString){
//            string[] words = searchString.Split(' ');
//            for(int i = 0; i<words.Length(); i++){
//                map.Add(words[i], map.TryGetValue(key, out val)? val+1 : 1);

//            }

//        }
    //    for(int i  = 0; i < )
        
    }

}