using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace PollyTest.Client.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    { 
        private readonly IHttpClientFactory _factory;

        public ValuesController(IHttpClientFactory factory)
        {
            _factory = factory;
        }

    // GET api/values
    [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            var thisList = new string[] { "value1", "value2" };

            var client = _factory.CreateClient("PollyTest");

            var result = client.GetStringAsync("/api/values").Result;

            var thatList = new List<string>();
            thatList.AddRange(result.Split(","));

            return Ok(thisList.Concat(thatList));
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public ActionResult<string> Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
