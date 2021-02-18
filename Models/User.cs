using System;
using System.Collections.Generic;
using Microsoft.JSInterop;


namespace street_foody.Models
{
    
    public class User
    {

        public string Name{get; set;}
        
        public List<Badge> BadgesEarned{get; set;}

        public List<Vendor> VendorsVisited{get; set;}

        public List<Vendor> VendorsLiked{get; set;}

        public void AddBadge(Badge Badge){
            BadgesEarned.Add(Badge);

        }


        public void AddVendorVisited(Vendor Vendor){
            VendorsVisited.Add(Vendor);

        }

        public void AddVendorLiked(Vendor Vendor){
            VendorsLiked.Add(Vendor);
        }
    }
}