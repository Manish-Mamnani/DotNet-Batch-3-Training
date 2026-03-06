namespace EventBooking.Api.DTOs.Booking
{
    public class BookingResponseDto
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public int SeatsBooked { get; set; }
        public DateTime EventDate { get; set; }
        public string EventTitle { get; set; }
    }
}