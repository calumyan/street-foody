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
        public int[] RatingList{get;set;}

        [NotMapped]
        public string AverageRating{get;set;}
        public string PhotoUrl{get;set;} 
        
        [NotMapped]
        public List<VendorHours> VendorHours{get;set;}  
        public StreetVendor(){
        }

        // Assigns an appropriate value to AverageRating string. 
        // Returns the average rating of this vendor, or returns null if no rating is available yet.
        public double? GetAverageRating(){
            if (RatingList == null) {
                AverageRating = "Not rated yet";
                return null;
            }
            if (RatingList.Length == 0) {
                AverageRating = "Not rated yet";
                return null;
            }
            double totalRating = 0;
            foreach(var rating in RatingList){
                totalRating+=rating;
            }
            double result = Math.Round(totalRating/RatingList.Length, 1);
            AverageRating = result.ToString("#.#") + "/5 (" + RatingList.Length + ")";
            return result;
        }

        // public void addVendorHours()
        // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?);

        // This constructor is only here for convenience when creating fake data in the SearchController.
        // public StreetVendor(string VNStandName, List<int> RatingList, int[] PriceRange) {
        //     this.StandVietnameseName = VNStandName; 
        //     this.PriceRange = PriceRange;
        //     this.RatingList = RatingList;
        // }
    }
}
