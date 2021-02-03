using System;
using System.Collections;

namespace street_foody.Models
{

   
    public class StreetVendorModel
    {
        [JSInvokable]
        public string FirstName{ get; set; }

        public string LastName{ get; set; }

        // [JSInvokable]
        public string Location{get;set;}

        public string Phone{get;set;}

        public Menu Menu{
            get;set;
        }

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
