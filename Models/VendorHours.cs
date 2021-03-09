using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System;

namespace street_foody.Models
{    
    public enum Days {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat,

    }
    public class VendorHours
    {

        [ForeignKey("StreetVendor")]
        [Key]
        public string VendorID{get; set;}
        // public string VendorHoursInfo{
        // get{return VendorHoursInfo;} 
        // set{VendorHoursInfo = VendorID + " " +Location;}}
        public string Location{get;set;}

        public DateTime[] Sun {get;set;}

        public DateTime[] Mon {get;set;}

        public DateTime[] Tue {get;set;}

        public DateTime[] Wed {get;set;}

        public DateTime[] Thu {get;set;}

        public DateTime[] Fri {get;set;}

        public DateTime[] Sat {get;set;}
        // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?);

    }
}
