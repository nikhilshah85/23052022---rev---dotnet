using System;
using System.Collections.Generic;

namespace airlinesWebAPI.Models.EF
{
    public partial class Customer
    {
        public int CustId { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? EmailAdress { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public int? ContactNo { get; set; }
        public int? Flightid { get; set; }
        public double? Balance { get; set; }

        public virtual Flight? Flight { get; set; }
    }
}
