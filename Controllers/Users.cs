using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Contoso.SCIM.Web.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly ILogger<UsersController> _logger;

        public UsersController(ILogger<UsersController> logger)
        {
            _logger = logger;
        }

        // GET: api/<UsersController>
        [HttpGet]
        public string Get()
        {
            _logger.LogWarning("GET was called!!!!");

            return "{\"schemas\": [\"urn:ietf:params:scim:api:messages:2.0:Error\"]," +
            "\"status\": \"404\"," +
            "\"detail\": \"Resource 222222@7cca31655d49f3640a494224 not found\"}";;
        }

        // GET api/<UsersController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            _logger.LogWarning("GET /Id was called!!!!");

            return "\"schemas\": [\"urn:ietf:params:scim:api:messages:2.0:Error\"]," +
            "\"status\": \"404\"," +
            "\"detail\": \"Resource 222222@7cca31655d49f3640a494224 not found\"";;
        }

        // POST api/<UsersController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
            _logger.LogWarning("POST is called!!!!");
        }

        // PUT api/<UsersController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
            _logger.LogWarning("PUT was called!!!!");
        }

        // DELETE api/<UsersController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _logger.LogWarning("DELETE was called!!!!");
        }
    }
}
