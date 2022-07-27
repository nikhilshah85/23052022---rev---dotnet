using System;
using System.Collections.Generic;

namespace airlinesWebAPI.Models.EF
{
    public partial class Hotel
    {
        public Hotel()
        {
            HotelReservations = new HashSet<HotelReservation>();
        }

        public int HotelId { get; set; }
        public string? HotelName { get; set; }
        public string? HotelCity { get; set; }

        public virtual ICollection<HotelReservation> HotelReservations { get; set; }
    }
}
