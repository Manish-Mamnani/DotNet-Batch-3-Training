using System.ComponentModel.DataAnnotations;

namespace EventBooking.Api.DTOs.Event
{
    public class CreateEventDto
    {
        [Required(ErrorMessage = "Event title is required.")]
        [StringLength(100, ErrorMessage = "Event title cannot exceed 100 characters.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Event description is required.")]
        [StringLength(500, ErrorMessage = "Description cannot exceed 500 characters.")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Event date is required.")]
        public DateTime EventDate { get; set; }

        [Range(1, 100000, ErrorMessage = "Total seats must be between 1 and 100000.")]
        public int TotalSeats { get; set; }

        [Range(0, 1000000, ErrorMessage = "Price must be between 0 and 1000000.")]
        public decimal Price { get; set; }
    }
}