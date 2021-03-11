using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 
using System;

namespace street_foody.Models
{    
    ///<summary> The opening hours for each vendor. They vary by different locations of each vendor.
    ///</summary>
    public enum Days {
        Sun, Mon, Tue, Wed, Thu, Fri, Sat,
    }
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
