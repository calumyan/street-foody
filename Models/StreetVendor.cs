using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace street_foody.Models
{    
    public class StreetVendor
    {
        [Key]
        public string VendorID{get;set;}
        public string VietnameseName{get; set;}
        public string EnglishName{get; set;}
        public string VendorName{get; set;}
        public string PhoneNumber{get;set;}
        public string Description{get;set;}     
        public int[] PriceRange{get;set;}   
        public int[] RatingList{get;set;}

        [NotMapped]
        public double AverageRating{get;set;}
        public string PhotoUrl{get;set;} 

        public ICollection<Food> Foods{get;set;}   

        // Assigns an appropriate value to AverageRating. 
        public void SetAverageRating(){
            double totalRating = 0;
            double length = -1;
            // if (RatingList == null) {
            //     AverageRating = 0;
            // }
            // else if (RatingList.Length == 0) {
            //     AverageRating = 0;
            // }
            if(RatingList == null || RatingList.Length == 0){
                length = -1;
            }
            if(RatingList != null){
                foreach(var rating in RatingList){
                    totalRating+=rating;
                }
                length = RatingList.Length;
            }
            
            double result = Math.Round(totalRating/length, 1);
            AverageRating = result;
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
