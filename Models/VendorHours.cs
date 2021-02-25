using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 

namespace street_foody.Models
{    
    public class VendorHours
    {

        [ForeignKey("StreetVendor")]
        public string VendorID{get; set;}
        [Key]
        public string VendorHoursInfo{
        get{return VendorHoursInfo;} 
        set{VendorHoursInfo = VendorID + " " +Location+" "+StartTime+" "+EndTime;}
        }
        public string Location{get;set;}
        public string StartTime {get;set;}
        public string EndTime {get;set;}
        // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?);
    }
}
