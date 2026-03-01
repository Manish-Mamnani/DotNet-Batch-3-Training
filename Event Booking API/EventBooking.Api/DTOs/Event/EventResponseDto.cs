namespace EventBooking.Api.DTOs.Event
{
    public class EventResponseDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime EventDate { get; set; }
        public int TotalSeats { get; set; }
        public int AvailableSeats { get; set; }
        public decimal Price { get; set; }
    }
}