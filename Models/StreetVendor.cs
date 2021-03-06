using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace street_foody.Models
{    
    public class StreetVendor
    {

        [Key]
        public string VendorID{get;set;}
        public string StandVietnameseName{get; set;}
        public string StandEnglishName{get; set;}
        public string VendorName{get; set;}
        public string PhoneNumber{get;set;}
        public string Description{get;set;}
        public List<FoodCategory> FoodCategories{get;set;}       
        public List<Food> Menu{get;set;}       
        public int[] PriceRange{get;set;}   
        public int[] OpeningHours{get;set;}
        public List<int> RatingList{get;set;}

        public string AverageRating{get;set;}
        public string PhotoUrl{get;set;} 
        
        public StreetVendor(){
        }

        public double GetAverageRating(){
            if (RatingList.Count == 0) return 0;
            int totalRating = 0;
            foreach(var rating in RatingList){
                totalRating+=rating;
            }
            return totalRating/RatingList.Count;
        }
        // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?);

        // This constructor is only here for convenience when creating fake data in the SearchController.
        public StreetVendor(string VNStandName, List<int> RatingList, int[] PriceRange) {
            this.StandVietnameseName = VNStandName; 
            this.PriceRange = PriceRange;
            this.RatingList = RatingList;
        }
    }
}
