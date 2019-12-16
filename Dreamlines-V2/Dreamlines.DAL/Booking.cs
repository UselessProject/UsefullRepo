using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamlines.DAL
{
    public class Booking
    {
        public int Id { get; set; }
        public int ShipId { get; set; }
        public string BookingDate { get; set; }
        public double Price { get; set; }
    }
}
