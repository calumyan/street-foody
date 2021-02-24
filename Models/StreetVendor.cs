using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore; 

namespace street_foody.Models
{    
    public class StreetVendor
    {
        public string ID{get;set;}
        public string StandVietameseName{get; set;}
        public string StandEnglishName{get; set;}
        public string VendorName{get; set;}
        public string PhoneNumber{get;set;}
        public string Description{get;set;}
        public List<FoodCategory> FoodCategories{get;set;}       
        public string PriceRange{get;set;}       
        public List<int> RatingList{get;set;}
        public double AverageRating{get;set;} 

        public string PhotoUrl{get;set;}     

        // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?);
    }
}
