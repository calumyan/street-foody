using System.ComponentModel.DataAnnotations;

namespace street_foody.Models
{
    ///<summary> A specific dish that's served by one vendor. 
    ///</summary>
    public class Food
    {
        [Key]
        public string FoodID{get;set;}
        public string VietnameseName{get; set;}
        public string EnglishName{get;set;}    
        public string Description{get;set;}
        public double Price{get;set;}
        public string FoodCategoryID{get;set;}
        public FoodCategory FoodCategory{get;set;}
        public string VendorID{get;set;}
        public StreetVendor Vendor{get;set;}
        public string PhotoUrl{get;set;}
    }
}
