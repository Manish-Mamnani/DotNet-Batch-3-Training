namespace EventBooking.Api.DTOs.Booking
{
    public class CreateBookingDto
    {
        public int EventId { get; set; }
        public int Seats { get; set; }
    }
}