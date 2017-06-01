using System;
using System.Collections.Generic;

namespace SportShop.Models
{
    public partial class Address
    {
        public int ObjId { get; set; }
        public string City { get; set; }
        public string Area { get; set; }
        public string Street { get; set; }
        public string Road { get; set; }
        public int? HouseId { get; set; }
        public int? ZipCode { get; set; }
    }
}
