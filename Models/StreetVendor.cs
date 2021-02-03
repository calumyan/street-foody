using System;
using System.Collections;
using Microsoft.JSInterop;

namespace street_foody.Models
{
   
    public class StreetVendorModel
    {
        public string FirstName{ get; set; }

        public string LastName{ get; set; }

        public string Location{ get; set; }

        public string Phone{ get; set; }

        // public Menu Menu{ get; set; }

        [JSInvokable]
        public string GetFullName(){
            return FirstName + " " + LastName;
        }

    
        [JSInvokable]
        public string GetLocation(){
            return Location;
        }


        


        // public List<String> FoodList;




    }
}
