using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Dreamlines.DAL;

namespace Dreamlines.BusinessLogic
{
  public  class SalesUnitService: ISalesUnitService
    {
        private SalesUnitngContext _context;

        public SalesUnitService(SalesUnitngContext context)
        {
            _context = context;
        }
        public IEnumerable<SalesUnitDto> Find()
        {
            var result = from salesUnit in _context.SalesUnits
                         join ship in _context.Ships on salesUnit.Id equals ship.SalesUnitId
                         join booking in _context.Bookings on ship.Id equals booking.ShipId
                         group booking by new
                         {
                             salesUnit.Id,
                             salesUnit.Name
                         }
                           into grp
                         select new SalesUnitDto
                         {
                             SalesUnitId = grp.Key.Id,
                             SalesUnitName = grp.Key.Name, 
                             TotalPrice = grp.Sum(b => b.Price)
                         };

            return result;

        }
    }
}
