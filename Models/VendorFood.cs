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
        public string VendorID{get; set;}
        [ForeignKey("Food")]
        public string FoodID{get; set;}

        
        // public string Location{get;set;}
        // public string VendorDates{get;set;}
        // public string StartTime {get;set;}
        // public string EndTime {get;set;}

        
    }
}
