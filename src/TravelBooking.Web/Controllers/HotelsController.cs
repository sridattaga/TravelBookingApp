using Microsoft.AspNetCore.Mvc;
using TravelBooking.Web.Data;

[ApiController]
[Route("api/hotels")]
public class HotelsController : ControllerBase
{
    private readonly AppDbContext _db;
    public HotelsController(AppDbContext db) => _db = db;

    [HttpGet]
    public IActionResult Get() => Ok(_db.Hotels.ToList());
}
