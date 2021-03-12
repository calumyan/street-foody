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
        

        ///<summary> absolute url of image hosted on CDN
        ///</summary>
        public string PhotoUrl{get;set;} 
        [Required]
        public ICollection<VendorHours> VendorHours{get;set;}
        public ICollection<Food> Foods{get;set;}     

        ///<summary> 
        /// Instance variables not mapped to database, used only to pass data from controller to views.
        ///</summary>
        [NotMapped]
        public double AverageRating{get;set;}
        [NotMapped]
        public List<FoodCategory> FoodCategories{get;set;}

        /// <summary> 
        /// Computes average rating from the RatingList and assigns
        /// the result to the unmapped AverageRating for later use in Razor view pages. 
        /// </summary> 
        public void SetAverageRating(){
            double totalRating = 0;
            double length = -1;
            if(RatingList == null || RatingList.Length == 0){
                length = -1;
            } else  {
                foreach(var rating in RatingList){
                    totalRating+=rating;
                }
                length = RatingList.Length;
            }
            
            double result = Math.Round(totalRating/length, 1);
            AverageRating = result;
        }
    }
}
