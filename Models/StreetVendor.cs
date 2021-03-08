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
        public double AverageRating{get;set;}
        public string PhotoUrl{get;set;} 
        
        [NotMapped]
        public List<VendorHours> VendorHours{get;set;}  
        public StreetVendor(){
        }



        // Assigns an appropriate value to AverageRating. 
        public void SetAverageRating(){
            if (RatingList == null) {
                AverageRating = 0;
            }
            if (RatingList.Length == 0) {
                AverageRating = 0;
            }
            double totalRating = 0;
            foreach(var rating in RatingList){
                totalRating+=rating;
            }
            double result = Math.Round(totalRating/RatingList.Length, 1);
<<<<<<< HEAD
            AverageRating = result;
=======
            AverageRating = result.ToString("#.#") + "/5 (" + RatingList.Length + ")";
            return result;
>>>>>>> e40c7dc0730db9007f9864139ce031ab608b9d69
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
