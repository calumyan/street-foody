using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System;

namespace street_foody.Models
{    
    
    public class VendorHours
    {

        [ForeignKey("StreetVendor")]
        public string VendorID;

        [Key]
        public string VendorHoursID{get; set;}
        // public string VendorHoursInfo{
        // get{return VendorHoursInfo;} 
        // set{VendorHoursInfo = VendorID + " " +Location;}}


        [Required]
        public string Location{get;set;}

        // Each day column is not required. To specify a closed day, leave the column null.
        public DateTime[] Sun {get;set;}

        public DateTime[] Mon {get;set;}

        public DateTime[] Tue {get;set;}

        public DateTime[] Wed {get;set;}

        public DateTime[] Thu {get;set;}

        public DateTime[] Fri {get;set;}

        public DateTime[] Sat {get;set;}
        // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?);

    }

    public enum Days {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat,

    }
}
