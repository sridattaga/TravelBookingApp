namespace TravelBooking.Web.Models;

public class Booking
{
    public int Id { get; set; }
    public string Type { get; set; }
    public int ItemId { get; set; }
    public DateTime Date { get; set; }
}
