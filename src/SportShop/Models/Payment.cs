using System;
using System.Collections.Generic;

namespace SportShop.Models
{
    public partial class Payment
    {
        public int ObjId { get; set; }
        public int Money { get; set; }
        public string Payway { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public int? Paytime { get; set; }
        public int? TradeNo { get; set; }
    }
}
