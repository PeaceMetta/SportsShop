using System;
using System.Collections.Generic;

namespace SportShop.Models
{
    public partial class Role
    {
        public Role()
        {
            ShopUser = new HashSet<ShopUser>();
        }

        public int ObjId { get; set; }
        public string RoleName { get; set; }

        public virtual ICollection<ShopUser> ShopUser { get; set; }
    }
}
