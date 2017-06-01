using System;
using System.Collections.Generic;

namespace SportShop.Models
{
    public partial class ShopUser
    {
        public ShopUser()
        {
            ShopOrderTheClerkNavigation = new HashSet<ShopOrder>();
            ShopOrderTheSenderNavigation = new HashSet<ShopOrder>();
        }

        public int ObjId { get; set; }
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public int? TheRole { get; set; }
        public string ContactMethod { get; set; }

        public virtual ICollection<ShopOrder> ShopOrderTheClerkNavigation { get; set; }
        public virtual ICollection<ShopOrder> ShopOrderTheSenderNavigation { get; set; }
        public virtual Role TheRoleNavigation { get; set; }
    }
}
