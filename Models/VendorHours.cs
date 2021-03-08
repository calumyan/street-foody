using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace street_foody.Models
{    
    public enum Days {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat,

    }
    public class VendorHours
    {

        [ForeignKey("StreetVendor")]
        public string VendorID{get; set;}
        [Key]
        public string VendorHoursID{get; set;}
        public string Location{get;set;}
        public string VendorDates{get;set;}
        public string StartTime {get;set;}
        public string EndTime {get;set;}
        // public DateTime[] Sun {get;set;}
        // public DateTime[] Mon {get;set;}
        // public DateTime[] Tue {get;set;}
        // public DateTime[] Wed {get;set;}
        // public DateTime[] Thu {get;set;}
        // public DateTime[] Fri {get;set;}
        // public DateTime[] Sat {get;set;}

    }
}
