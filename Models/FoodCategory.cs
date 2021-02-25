using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace street_foody.Models
{  
    public class FoodCategory
    {
        [Key]
        public string FoodCategoryID{get;set;}
        public string CategoryVietameseName{get; set;}
        public string CategoryEnglishName{get; set;}
        public string Description{get;set;}  
       
    }
}
