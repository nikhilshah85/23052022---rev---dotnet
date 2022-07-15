using System;
using System.Collections.Generic;

namespace shoppingAPI.Models.EF
{
    public partial class Register
    {
        public Register()
        {
            OrdersLists = new HashSet<OrdersList>();
        }

        public string DesiredUserName { get; set; } = null!;
        public string? DesiredPassword { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAddress { get; set; }
        public int? ContactNo { get; set; }
        public int? Age { get; set; }
        public string? City { get; set; }
        public string? Address { get; set; }

        public virtual ICollection<OrdersList> OrdersLists { get; set; }
    }
}
