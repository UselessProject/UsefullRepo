using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dreamlines.DAL;

namespace Dreamlines.BusinessLogic
{
  public  class SalesunitService: ISalesunitService
    {
        private SalesunitContext _context;

        public SalesunitService(SalesunitContext context)
        {
            _context = context;
        }
        public IEnumerable<SalesunitDto> Find(int pageIndex,int pageCount)
        {
            var result = from salesUnit in _context.Salesunits
                         join ship in _context.Ships on salesUnit.Id equals ship.SalesunitId
                         join booking in _context.Bookings on ship.Id equals booking.ShipId
                         group booking by new
                         {
                             salesUnit.Id,
                             salesUnit.Name
                         }
                           into grp
                         select new SalesunitDto
                         {
                             SalesunitId = grp.Key.Id,
                             SalesunitName = grp.Key.Name, 
                             TotalPrice = grp.Sum(b => b.Price)
                         };

            return result;

        }
    }
}
