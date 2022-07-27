using System;
using System.Collections.Generic;

namespace airlinesWebAPI.Models.EF
{
    public partial class RentalAgency
    {
        public RentalAgency()
        {
            CarReservations = new HashSet<CarReservation>();
        }

        public int AgencyId { get; set; }
        public string? AgencyName { get; set; }
        public string? AgencyLocation { get; set; }

        public virtual ICollection<CarReservation> CarReservations { get; set; }
    }
}
