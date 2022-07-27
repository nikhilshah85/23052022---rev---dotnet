using System;
using System.Collections.Generic;

namespace airlinesWebAPI.Models.EF
{
    public partial class HotelReservation
    {
        public int ReservationId { get; set; }
        public int? HotelId { get; set; }
        public int? RoomId { get; set; }
        public DateTime? CheckIn { get; set; }
        public DateTime? CheckOut { get; set; }

        public virtual Hotel? Hotel { get; set; }
    }
}
