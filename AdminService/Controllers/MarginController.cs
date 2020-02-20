using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AdminService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MarginController : ControllerBase
    {
       
        // GET: api/Margin
        [HttpGet]
        public IEnumerable<string> Get()
        {
            // READ SERVICE DISCOVERY FROM APP SETTINGS TO MAKE HTTP CALL
            return new string[] { "value1", "value2" };
        }

        // GET: api/Margin/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Margin
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Margin/5
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
