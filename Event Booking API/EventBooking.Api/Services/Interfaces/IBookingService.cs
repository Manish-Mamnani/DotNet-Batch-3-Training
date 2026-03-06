using EventBooking.Api.DTOs.Booking;

namespace EventBooking.Api.Services.Interfaces
{
    public interface IBookingService
    {
        Task<BookingResponseDto> CreateBookingAsync(int userId, CreateBookingDto dto);
        Task<IEnumerable<BookingResponseDto>> GetUserBookingsAsync(int userId);
        Task<bool> CancelBookingAsync(int userId, int bookingId);
    }
}