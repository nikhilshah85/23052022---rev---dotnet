using System;
using System.Collections.Generic;

namespace airlinesWebAPI.Models.EF
{
    public partial class Car
    {
        public int? CarId { get; set; }
        public int? AgencyId { get; set; }
        public int? CarModel { get; set; }
        public int? CarPrice { get; set; }

        public virtual RentalAgency? Agency { get; set; }
    }
}
