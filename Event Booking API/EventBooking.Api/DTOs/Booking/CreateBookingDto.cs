using System.ComponentModel.DataAnnotations;

namespace EventBooking.Api.DTOs.Booking
{
    public class CreateBookingDto
    {
        [Required(ErrorMessage = "Event ID is required.")]
        public int EventId { get; set; }

        [Range(1, 10, ErrorMessage = "You must book at least 1 seat and no more than 10 seats.")]
        public int Seats { get; set; }
    }
}