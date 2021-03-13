using System.ComponentModel.DataAnnotations;
using System;

namespace street_foody.Models
{    
    ///<summary> 
    /// The opening hours associated with a single location of a vendor.
    /// A vendor may have one or multiple location-hours pair(s).
    ///</summary>
    public class VendorHours
    {
        [Key]
        public string VendorHoursID{get; set;}
        [Required]
        public string Location{get;set;}

        ///<summary> Each day column is not required. To specify a closed day, leave the column null.
        ///</summary>
        public DateTime[] Sun {get;set;}
        public DateTime[] Mon {get;set;}
        public DateTime[] Tue {get;set;}
        public DateTime[] Wed {get;set;}
        public DateTime[] Thu {get;set;}
        public DateTime[] Fri {get;set;}
        public DateTime[] Sat {get;set;}
        public string VendorID{get;set;}
        public StreetVendor Vendor{get;set;}
    }
}
