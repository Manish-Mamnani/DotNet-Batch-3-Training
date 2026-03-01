namespace EventBooking.Api.DTOs.Event
{
    public class CreateEventDto
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public int TotalSeats { get; set; }
        public decimal Price { get; set; }
    }
}