using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace street_foody.Models
{  
    ///<summary> 
    /// A collection of similar foods/dishes, from which we can look for vendors offering
    /// similar food types, or know general offerings of a specific vendor.
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
    }
}