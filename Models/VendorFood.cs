using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace street_foody.Models
{    
    public class VendorFood
    {

        [ForeignKey("StreetVendor")]
        [Key]
        public string VendorID{get; set;}
        [ForeignKey("Food")]
        [Key]
        public string FoodID{get; set;}
        
    }
}
