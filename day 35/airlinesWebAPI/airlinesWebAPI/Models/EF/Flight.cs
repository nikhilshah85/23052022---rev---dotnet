using System;
using System.Collections.Generic;

namespace airlinesWebAPI.Models.EF
{
    public partial class Flight
    {
        public Flight()
        {
            Customers = new HashSet<Customer>();
        }

        public int FlightId { get; set; }
        public string? FromCity { get; set; }
        public string? ToCity { get; set; }
        public string? Takeoff { get; set; }
        public string? Landingtime { get; set; }
        public double? Price { get; set; }

        public virtual ICollection<Customer> Customers { get; set; }
    }
}
