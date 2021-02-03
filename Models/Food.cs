using System;
using System.Collections.Generic;
using Microsoft.JSInterop;

namespace street_foody.Models
{
    
    public class Food
    {

        public string FirstName{get; set;}
        public string LastName{get; set;}


        public List<string> Categories{get;set;}

        public double Rating{get; set;}

        [JSInvokable]
        public string GetName(){

            return FirstName + " " + LastName;
        }

        // public List<String> FoodList;




    }
}
