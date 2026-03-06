using EventBooking.Api.Data;
using EventBooking.Api.DTOs.Booking;
using EventBooking.Api.Models;
using EventBooking.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBooking.Api.Services.Implementations
{
    public class BookingService : IBookingService
    {
        private readonly AppDbContext _context;

        public BookingService(AppDbContext context)
        {
            _context = context;
        }

        public async Task<BookingResponseDto> CreateBookingAsync(int userId, CreateBookingDto dto)
        {
            var ev = await _context.Events.FirstOrDefaultAsync(e => e.Id == dto.EventId);

            if (ev == null) 
            {
                throw new Exception("Event not found.");
            }
            if (ev.EventDate <= DateTime.Now)
            {
                throw new Exception("Cannot book past events.");
            }

            if (dto.Seats <= 0)
            {
                throw new Exception("Seats must be greater than zero.");
            }

            if (dto.Seats > ev.AvailableSeats)
            {
                throw new Exception("Not enough seats available.");
            }

            ev.AvailableSeats -= dto.Seats;

            var booking = new Booking
            {
                EventId = dto.EventId,
                UserId = userId,
                SeatsBooked = dto.Seats
            };

            _context.Bookings.Add(booking);

            await _context.SaveChangesAsync();

            return new BookingResponseDto
            {
                Id = booking.Id,
                EventId = ev.Id,
                SeatsBooked = booking.SeatsBooked,
                EventDate = ev.EventDate,
                EventTitle = ev.Title
            };
        }

        public async Task<IEnumerable<BookingResponseDto>> GetUserBookingsAsync(int userId)
        {
            var bookings = await _context.Bookings.Include(b => b.Event).Where(b => b.UserId == userId).ToListAsync();

            return bookings.Select(b => new BookingResponseDto
            {
                Id = b.Id,
                EventId = b.EventId,
                SeatsBooked = b.SeatsBooked,
                EventDate = b.Event.EventDate,
                EventTitle = b.Event.Title
            });
        }

        public async Task<bool> CancelBookingAsync(int userId, int bookingId)
        {
            var booking = await _context.Bookings.Include(b => b.Event).FirstOrDefaultAsync(b => b.Id == bookingId);

            if (booking == null)
                throw new Exception("Booking not found.");

            if (booking.UserId != userId)
                throw new Exception("You can only cancel your own bookings.");

            if (booking.Event.EventDate <= DateTime.Now)
                throw new Exception("Cannot cancel past event bookings.");

            booking.Event.AvailableSeats += booking.SeatsBooked;

            _context.Bookings.Remove(booking);

            await _context.SaveChangesAsync();

            return true;
        }
    }
}