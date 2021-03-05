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
        public string PhotoUrl{get;set;} 
        
        public StreetVendor(){
        }

        public int GetAverageRating(){
            int totalRating = 0;
            int count = 0;
            foreach(int rating in RatingList){
                totalRating+=rating;
                count++;
            }
            return totalRating/count;
        }
        // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?);

        // This constructor is only here for convenience when creating fake data in the SearchController.
        // public StreetVendor(string VNStandName, List<FoodCategory> categories, List<int> RatingList, List<int> PriceRange) {
        //     this.StandVietnameseName = VNStandName; 
        //     this.FoodCategories = categories;
        //     this.PriceRange = PriceRange;
        //     this.RatingList = RatingList;
        // }
    }
}
