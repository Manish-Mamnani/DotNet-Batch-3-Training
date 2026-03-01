namespace EventBooking.Api.Models
{
    public class Booking
    {
        public int Id { get; set; }

        public int UserId { get; set; }
        public int EventId { get; set; }

        public int SeatsBooked { get; set; }

        public DateTime BookingDate { get; set; } = DateTime.Now;

        public string Status { get; set; } = "Active";

        public User User { get; set; } = null!;
        public Event Event { get; set; } = null!;
    }
}
