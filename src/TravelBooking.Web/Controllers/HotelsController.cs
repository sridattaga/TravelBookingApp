using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TravelBooking.Web.Data;

namespace TravelBooking.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class HotelsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public HotelsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetHotels()
        {
            return Ok(_context.Hotels.ToList());
        }
    }
}
