using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace street_foody.Models
{    
    
    public class VendorCategory
    {

        [ForeignKey("StreetVendor")]
        public string VendorID{get; set;}
        [ForeignKey("FoodCategory")]
        public string FoodCategoryID{get; set;}
        
        
    }
}
