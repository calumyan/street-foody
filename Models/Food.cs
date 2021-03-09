using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore; 
using static System.Drawing.Bitmap;
using static System.Drawing.Imaging.Metafile;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
namespace street_foody.Models
{   
    public class Food
    {
        [Key]
        public string FoodID{get;set;}
        public string VietnameseName{get; set;}
        public string EnglishName{get;set;}    
        public string Description{get;set;}
        public double Price{get;set;}
        public FoodCategory FoodCategory{get;set;}
        public string PhotoUrl{get;set;}
        public ICollection<StreetVendor> StreetVendors{get;set;}
    }
}
