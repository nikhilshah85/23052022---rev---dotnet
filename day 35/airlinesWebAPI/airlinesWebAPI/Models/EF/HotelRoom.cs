using System;
using System.Collections.Generic;

namespace airlinesWebAPI.Models.EF
{
    public partial class HotelRoom
    {
        public int? RoomId { get; set; }
        public int? HotelId { get; set; }
        public int? RoomNum { get; set; }
        public int? RoomPrice { get; set; }

        public virtual Hotel? Hotel { get; set; }
    }
}
