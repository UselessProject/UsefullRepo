using System;
using System.Collections.Generic;
using System.Text;

namespace Dreamlines.DAL
{
    public class SalesUnit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Country { get; set; }
        public string Currency { get; set; }
        public List<Ship> Ships { get; set; }
    }
}
