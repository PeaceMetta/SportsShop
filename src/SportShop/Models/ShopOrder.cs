using System;
using System.Collections.Generic;

namespace SportShop.Models
{
    public partial class ShopOrder
    {
        public int ObjId { get; set; }
        public string TheUser { get; set; }
        public DateTime? OrderTime { get; set; }
        public string Product { get; set; }
        public int? Money { get; set; }
        public int? ThePayment { get; set; }
        public string TheReceiver { get; set; }
        public int? TheClerk { get; set; }
        public int? TheSender { get; set; }
        public int? OrderState { get; set; }

        public virtual ShopUser TheClerkNavigation { get; set; }
        public virtual ShopUser TheSenderNavigation { get; set; }
    }
}
