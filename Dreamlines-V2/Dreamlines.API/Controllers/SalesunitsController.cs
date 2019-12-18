using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dreamlines.BusinessLogic;
using Dreamlines.DAL;
using Dreamlines.DAL.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dreamlines.API.Controllers
{
    [Route("api/Salesunits")]
    [ApiController]
    public class SalesunitsController : MyMDBController<Salesunit, SalesunitRepository>
    {
        private readonly ISalesunitService _salesunitService;
        

        public SalesunitsController(ISalesunitService salesunitService)
        {
            _salesunitService = salesunitService;
           
        }
        // GET: api/Salesunits
        [HttpGet]
        public IEnumerable<SalesunitDto> Get(int pageIndex,int pageCount)
        {
            var result = _salesunitService.Find();
            return result;
        }

       

        
    }
}
