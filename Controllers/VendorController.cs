using Microsoft.AspNetCore.Mvc; 
using System.Collections.Generic; 
using System.Linq; 
using street_foody.Models;  

namespace street_foody.Controllers {     
    [Route("Vendor")]
    [ApiController]
   public class VendorController : Controller     
   {        
      private readonly Context _context;       
      public StreetVendor vendor;   
      public VendorController(Context context){     
               _context = context;   
      } 

      public IActionResult Index() {
         string id = "5";
         vendor = _context.StreetVendor.Where(v => v.VendorID == id).ToList()[0];
         // vendor.VendorHours = _context.VendorHours.Where(h => h.VendorID == id).ToList();
         // vendor.GetAverageRating();
         return View(vendor);
      }
   } 
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
        
  