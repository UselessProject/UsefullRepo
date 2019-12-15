using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamlines.DAL
{
    public class Ship
    {
        public int Id { get; set; }
        public int SalesunitId { get; set; }
        public string Name { get; set; }
        public List<Booking> Bookings { get; set; }
        //public Salesunit salesUnit { get; set; }?for DDD
    }
}
