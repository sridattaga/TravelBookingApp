using System;

namespace TravelBooking.Web.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public DateTime BookingDate { get; set; }
        public string UserName { get; set; }
    }
}
