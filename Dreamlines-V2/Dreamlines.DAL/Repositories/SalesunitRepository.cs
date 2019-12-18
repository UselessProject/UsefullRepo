using System;
using System.Collections.Generic;
using System.Text;
using Dreamlines.DAL.Models;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.Globalization;

namespace Dreamlines.DAL.Repositories
{
   public class SalesunitRepository:  EfCoreRepository<Salesunit, SalesunitContext>
    {
        private readonly SalesunitContext context;
        public SalesunitRepository(SalesunitContext context) : base(context)
        {
            this.context = context;
        }
        public IEnumerable<SalesunitView> Find(int pageIndex, int pageCount,DateTime fromDate,DateTime toDate)
        {
            var strFromDate = fromDate.ToString("yyyyMMddTHHmmssZ");
            var strToDate = toDate.ToString("yyyyMMddTHHmmssZ");

            var result = from salesUnit in context.Salesunits
                         join ship in context.Ships on salesUnit.Id equals ship.SalesunitId
                         join booking in context.Bookings on ship.Id equals booking.ShipId
                         where booking.BookingDate.CompareTo(strFromDate) >= 0 && booking.BookingDate.CompareTo(strToDate) <= 0
                         
                         group booking by new
                         {
                             salesUnit.Id,
                             salesUnit.Name
                         }
                           into grp
                         select new SalesunitView
                         {
                             SalesunitId = grp.Key.Id,
                             SalesunitName = grp.Key.Name,
                             TotalPrice = grp.Sum(b => b.Price)
                         };
            result = result.OrderByDescending(c => c.SalesunitId).Skip(pageIndex).Take(pageCount);
            return result;

        }
    }
}
