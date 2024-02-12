using Microsoft.AspNetCore.Mvc;
using SupermarketApi.Models;

namespace SupermarketApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        // GET: api/User
        [HttpGet]
        public IActionResult Get()
        {
            // Your logic to retrieve all users
            return Ok();
        }

        // GET: api/User/5
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            // Your logic to retrieve a specific user by id
            return Ok();
        }

        // POST: api/User
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            // Your logic to create a new user
            return Ok();
        }

        // PUT: api/User/5
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            // Your logic to update an existing user
            return Ok();
        }

        // DELETE: api/User/5
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            // Your logic to delete a user
            return Ok();
        }
    }
}
