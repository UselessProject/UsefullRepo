using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dreamlines.BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Dreamlines.API.Controllers
{
    [Route("api/Salesunits")]
    [ApiController]
    public class SalesunitsController : ControllerBase
    {
        private readonly ISalesunitService _salesunitService;
        

        public SalesunitsController(ISalesunitService salesunitService)
        {
            _salesunitService = salesunitService;
           
        }
        // GET: api/Salesunits
        [HttpGet]
        public IEnumerable<SalesunitDto> Get()
        {
            var result = _salesunitService.Find();
            return result;
        }

        // GET: api/Salesunits/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Salesunits
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Salesunits/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
