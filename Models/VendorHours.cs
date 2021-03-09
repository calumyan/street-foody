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
        [Key]
        [Column("vendor_id")]
        public string VendorID{get; set;}
        // public string VendorHoursInfo{
        // get{return VendorHoursInfo;} 
        // set{VendorHoursInfo = VendorID + " " +Location;}}
        public string Location{get;set;}

        [DisplayFormat(DataFormatString = "{hh:mm tt, hh:mm tt}", ApplyFormatInEditMode = true)]
        public System.DateTime[] Sun {get;set;}

        [DisplayFormat(DataFormatString = "{hh:mm tt, hh:mm tt}", ApplyFormatInEditMode = true)]

        public System.DateTime[] Mon {get;set;}

        [DisplayFormat(DataFormatString = "{hh:mm tt, hh:mm tt}", ApplyFormatInEditMode = true)]

        public System.DateTime[] Tue {get;set;}

        [DisplayFormat(DataFormatString = "{hh:mm tt, hh:mm tt}", ApplyFormatInEditMode = true)]

        public System.DateTime[] Wed {get;set;}

        [DisplayFormat(DataFormatString = "{hh:mm tt, hh:mm tt}", ApplyFormatInEditMode = true)]

        public System.DateTime[] Thu {get;set;}

        [DisplayFormat(DataFormatString = "{hh:mm tt, hh:mm tt}", ApplyFormatInEditMode = true)]

        public System.DateTime[] Fri {get;set;}


        [DisplayFormat(DataFormatString = "{hh:mm tt, hh:mm tt}", ApplyFormatInEditMode = true)]
        public System.DateTime[] Sat {get;set;}
        // select * from vendor where id in (select vendor_id from vendor_hours where start_time < ? and end_time > ?);
    }
}
