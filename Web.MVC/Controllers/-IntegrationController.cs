using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Web.MVC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IntegrationController : ControllerBase
    {
        // GET: api/<IntegrationController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<IntegrationController>/5
        [HttpGet("{id}")]
        [Microsoft.AspNetCore.Authorization.Authorize]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<IntegrationController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<IntegrationController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<IntegrationController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}