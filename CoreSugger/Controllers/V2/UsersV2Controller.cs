using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CoreSugger.Controllers.V2
{
    //[ApiVersion("2")]
    [Route("api/v{v:apiVersion}/users")]
    [ApiController]
    public class UsersV2Controller : ControllerBase
    {
        // GET: api/UsersV2
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1 from Version 2", "value2" };
        }

        // GET: api/UsersV2/5
        [HttpGet("{id}", Name = "Get")]
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/UsersV2
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/UsersV2/5
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


