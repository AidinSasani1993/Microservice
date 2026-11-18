using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Customer.API.Controllers
{
    [ApiController]
    [Route("api/[customer]")]
    public class CustomerController : ControllerBase
    {
        
    [HttpGet("GetAll")]
        public IActionResult GetAll()
        {
            var customers = new[]
            {
                new { Id = 1, Name = "Ali" },
                new { Id = 2, Name = "Reza" },
                new { Id = 3, Name = "Sara" }
            };

            return Ok(customers);
        }
    }
}
