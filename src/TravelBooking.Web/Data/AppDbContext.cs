using Microsoft.EntityFrameworkCore;
using TravelBooking.Web.Models;

namespace TravelBooking.Web.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) {}

    public DbSet<Hotel> Hotels => Set<Hotel>();
    public DbSet<Car> Cars => Set<Car>();
    public DbSet<Booking> Bookings => Set<Booking>();
}
