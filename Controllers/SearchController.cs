
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

   
    
    public class SearchController : Controller
    {
      

       Dictionary<string, int> map = new Dictionary<>();
       public String getHighestVendor(Vendor vendor){
            
       }
       

       public int getScore(String name){
            int score = 0;
            string[] words = name.Split(' ');
            for(int i = 0; i < words.length(); i++){
                String word = words[i];
                int count = map[word];
                score+=count;
            }
            return score;
       }

       public Dictionary<string, int> getCount(String searchString){
           map = new Dictionary<>();
           string[] words = searchString.Split(' ');
           for(int i = 0; i<words.length; i++){
               map.Add(words[i], map.TryGetValue(key, out val)? val+1 : 1);

           }

       }
    //    for(int i  = 0; i < )
        
    }

}