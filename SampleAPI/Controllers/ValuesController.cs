using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace SampleAPI.Controllers
{
    [Route("api/[controller]")]
    //[Microsoft.AspNetCore.Authorization.Authorize]
    public class ValuesController : Controller
    {
        private readonly IConfiguration configuration;

        public ValuesController(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // GET api/values
        [HttpGet]
        [Authorize]
        public IEnumerable<string> Get()
        {
            var s = configuration["Data-API-Secret"];
            return new string[] { s };
        }

        // POST api/values
        [HttpPost]
        public string Post([FromBody]string value)
        {
            return $"You posted {value}";
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public string Put(int id, [FromBody]string value)
        {
            return $"You put {value} in {id}";
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public string Delete(int id)
        {
            return $"You deleted {id}";
        }
    }
}
