using System;
using System.Collections.Generic;
using Microsoft.JSInterop;
using System.Drawing;

namespace street_foody.Models
{
    
    public class Badge
    {
        public string ID{get; set;}
        public string Name{get; set;}
        public string Description{get; set;}

        public Image Image{get;set;}

    }
}
