using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace street_foody.Models
{  
    ///<summary> Food cateogry for each food. 
    ///</summary>
    public class FoodCategory
    {
        [Key]
        public string FoodCategoryID{get;set;}
        public string VietnameseName{get; set;}
        public string EnglishName{get; set;}
        public string Description{get;set;}  
        public ICollection<Food> Foods{get;set;}
        public FoodCategory(){}
        // This constructor is only here for convenience when creating fake data in the SearchController.
        public FoodCategory(string FoodCategoryID, string VietnameseName) {
            this.FoodCategoryID = FoodCategoryID;
            this.VietnameseName = VietnameseName;
        }
    }
}