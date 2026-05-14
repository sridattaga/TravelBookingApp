using Microsoft.AspNetCore.Mvc;
using TravelBooking.Web.Data;
using TravelBooking.Web.Models;

[ApiController]
[Route("api/bookings")]
public class BookingsController : ControllerBase
{
    private readonly AppDbContext _db;
    public BookingsController(AppDbContext db) => _db = db;

    [HttpPost]
    public IActionResult Create(Booking booking)
    {
        _db.Bookings.Add(booking);
        _db.SaveChanges();
        return Ok(booking);
    }
}
