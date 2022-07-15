using System;
using System.Collections.Generic;

namespace shoppingAPI.Models.EF
{
    public partial class ProductList
    {
        public ProductList()
        {
            OrdersLists = new HashSet<OrdersList>();
        }

        public int PId { get; set; }
        public string? PName { get; set; }
        public string? PCategory { get; set; }
        public int? PPrice { get; set; }
        public int? PAvailableQty { get; set; }
        public bool? PIsInStock { get; set; }

        public virtual ICollection<OrdersList> OrdersLists { get; set; }
    }
}
