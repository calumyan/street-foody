using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore; 
using static System.Drawing.Bitmap;
using static System.Drawing.Imaging.Metafile;



namespace street_foody.Models
{   
    public class Food
    {
        public string ID{get;set;}
        public string VietameseName{get; set;}
        public List<string> Categories{get;set;}      
        public string EnglishName{get;set;}
        public string Description{get;set;}
        public double Price{get;set;}
        public List<FoodCategory> FoodCategories{get;set;}  
        public string PhotoUrl{get;set;}
    }
}
