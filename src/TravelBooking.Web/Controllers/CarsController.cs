using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TravelBooking.Web.Data;

namespace TravelBooking.Web.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public CarsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetCars()
        {
            return Ok(_context.Cars.ToList());
        }
    }
}
