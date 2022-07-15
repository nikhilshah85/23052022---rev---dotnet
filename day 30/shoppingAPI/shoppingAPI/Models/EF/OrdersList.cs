using System;
using System.Collections.Generic;

namespace shoppingAPI.Models.EF
{
    public partial class OrdersList
    {
        public int OrderId { get; set; }
        public DateTime? OrderDate { get; set; }
        public int? ProductId { get; set; }
        public int? OrderQty { get; set; }
        public int? OrderCost { get; set; }
        public string? UserId { get; set; }

        public virtual ProductList? Product { get; set; }
        public virtual Register? User { get; set; }
    }
}
