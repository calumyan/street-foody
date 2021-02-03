using System;

namespace street_foody.Models
{

   
    public class StreetVendorModel
    {
        // [JSInvokable]

        
        public string FirstName{ get; set; }

        public string LastName{ get; set; }

        // [JSInvokable]
        public string Location{get;set;}

        [JSInvokable]
        public string GetFullName(){

            return FirstName + " " + LastName;
        }

    
        public string GetLocation(){

            return Location;
        }


        


        // public List<String> FoodList;




    }
}
