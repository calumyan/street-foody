using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema; 


namespace street_foody.Models
{    

    public class VendorHours
    {
    
        [Key]
        public string VendorHoursID{get; set;}
        public StreetVendor Vendor{get; set;}
        public string Location{get;set;}
        public string VendorDates{get;set;}
        public string StartTime {get;set;}
        public string EndTime {get;set;}

        
    }
}
