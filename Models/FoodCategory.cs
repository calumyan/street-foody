using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore; 

namespace street_foody.Models
{  
    public class FoodCategory
    {
        public string ID{get;set;}
        public string CategoryVietameseName{get; set;}
        public string CategoryEnglishName{get; set;}
        public string Description{get;set;}  
       
    }
}
