using System;
using System.Collections.Generic;

namespace SportShop.Models
{
    public partial class Favor
    {
        public int ObjId { get; set; }
        public string Product { get; set; }
        public int? Amount { get; set; }
        public int? Price { get; set; }
    }
}
