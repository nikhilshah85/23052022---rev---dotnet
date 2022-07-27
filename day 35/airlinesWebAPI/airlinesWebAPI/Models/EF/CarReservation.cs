using System;
using System.Collections.Generic;

namespace airlinesWebAPI.Models.EF
{
    public partial class CarReservation
    {
        public int ReservationId { get; set; }
        public int? AgencyId { get; set; }
        public int? CarId { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }

        public virtual RentalAgency? Agency { get; set; }
    }
}
