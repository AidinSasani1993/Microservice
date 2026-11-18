using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Ticket.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TicketController : ControllerBase
    {
        [HttpGet("GetAll1")]
        public IActionResult GetAll()
        {
            var tickets = new[]
            {
                new { Id = 1, Title = "Aidin Sasani" },
                new { Id = 2, Title = "1993 1372" }
            };

            return Ok(tickets);
        }

        [HttpGet("GetAll2")]
        public IActionResult GetAll2()
        {
            var tickets = new[]
            {
                new { Id = 101, Title = "Ticket Number 101" },
                new { Id = 102, Title = "Ticket Number 102" },
                new { Id = 102, Title = "Ticket Number 103" },
            };

            return Ok(tickets);
        }
    }
}
