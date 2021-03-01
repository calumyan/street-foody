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
        public string CategoryVietnameseName{get; set;}
        public string CategoryEnglishName{get; set;}
        public string Description{get;set;}  

        // This constructor is only here for convenience when creating fake data in the SearchController.
        public FoodCategory(string CategoryVietameseName) {
            this.CategoryVietnameseName = CategoryVietameseName;
        }
    }
}
