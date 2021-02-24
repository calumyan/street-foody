using System;
using System.Collections.Generic;
using Microsoft.JSInterop;

namespace street_foody.Models
{    
    public class Vendor
    {
        public string ID{get;set;}
        public string StandVietnameseName{get; set;}
        public string StandEnglishName{get; set;}
        public string VendorName{get; set;}
        public Dictionary<string, string> LocationHoursMap{get;set;}
        public string PhoneNumber{get;set;}
        public string Description{get;set;}
        public List<FoodCategory> FoodCategories{get;set;}       
        public List<Food> Menu{get;set;}       
        public string PriceRange{get;set;}       
        public List<int> RatingList{get;set;}
        public double AverageRating{get;set;}      
    }
}
