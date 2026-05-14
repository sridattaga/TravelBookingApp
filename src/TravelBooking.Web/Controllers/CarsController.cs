using Microsoft.AspNetCore.Mvc;
using TravelBooking.Web.Data;

[ApiController]
[Route("api/cars")]
public class CarsController : ControllerBase
{
    private readonly AppDbContext _db;
    public CarsController(AppDbContext db) => _db = db;

    [HttpGet]
    public IActionResult Get() => Ok(_db.Cars.ToList());
}
