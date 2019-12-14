using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamlines.DAL
{
    public class Ship
    {
        public int Id { get; set; }
        public int SalesUnitId { get; set; }
        public string Name { get; set; }
        public List<Booking> Bookings { get; set; }
        //public SalesUnit salesUnit { get; set; }?for DDD
    }
}
