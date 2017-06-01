using System;
using System.Collections.Generic;

namespace SportShop.Models
{
    public partial class Products
    {
        public int ObjId { get; set; }
        public string Name { get; set; }
        public int Code { get; set; }
        public string Spintro { get; set; }
        public string Intro { get; set; }
        public int Price { get; set; }
    }
}
