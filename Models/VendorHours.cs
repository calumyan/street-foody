using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using Microsoft.EntityFrameworkCore; 

namespace street_foody.Models
{    
    public class VendorHours
    {
        public int VendorID{get; set;}
        public string Location{get;set;}
        public string StartTime {get;set;}
        public string EndTime {get;set;}
       

        // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?);
    }
}
