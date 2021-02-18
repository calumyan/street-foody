using System;
using System.Collections.Generic;
using Microsoft.JSInterop;

namespace street_foody.Models
{
    
    public class Food
    {

        public string Name{get; set;}

        public List<string> Categories{get;set;}

        // public double Rating{get; set;}

        [JSInvokable]
        public string GetName(){

            return Name;
        }
    }
}
