using EventBooking.Api.Data;
using EventBooking.Api.DTOs.Event;
using EventBooking.Api.Models;
using EventBooking.Api.Services.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace EventBooking.Api.Services.Implementations
{
    public class EventService : IEventService
    {
        private readonly AppDbContext _context;

        public EventService(AppDbContext appDbContext)
        {
            _context = appDbContext;
        }

        public async Task<EventResponseDto> CreateEventAsync(CreateEventDto dto)
        {
            if(dto.EventDate <= DateTime.Now)
            {
                throw new Exception("Event date must be in future");
            }

            var newEvent = new Event()
            {
                Title = dto.Title,
                Description = dto.Description,
                EventDate = dto.EventDate,
                TotalSeats = dto.TotalSeats,
                AvailableSeats = dto.TotalSeats,
                Price = dto.Price
            };

            _context.Events.Add(newEvent);
            await _context.SaveChangesAsync();

            return new EventResponseDto()
            {
                Id = newEvent.Id,
                Title = newEvent.Title,
                Description = newEvent.Description,
                EventDate = newEvent.EventDate,
                TotalSeats = newEvent.TotalSeats,
                AvailableSeats = newEvent.TotalSeats,
                Price = newEvent.Price
            };
        }

        public async Task<bool> DeleteEventAsync(int id)
        {
            var existingEvent = await _context.Events.FirstOrDefaultAsync(x => x.Id == id);

            if (existingEvent == null)
            {
                throw new Exception("Event does not exist with this id.");
            }

            _context.Events.Remove(existingEvent);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<EventResponseDto>> GetAllEventsAsync()
        {
            var eventList = await _context.Events.ToListAsync();
            return eventList.Select(e => MapToDto(e));
        }

        public async Task<EventResponseDto> GetEventByIdAsync(int id)
        {
            var existingEvent = await _context.Events.FirstOrDefaultAsync(x => x.Id == id);

            if(existingEvent == null)
            {
                throw new Exception("Event not found.");
            }

            return MapToDto(existingEvent);
        }

        public async Task<EventResponseDto> UpdateEventAsync(int id, UpdateEventDto dto)
        {
            var existingEvent = await _context.Events.FirstOrDefaultAsync(e => e.Id == id);

            if (existingEvent == null)
            {
                throw new Exception("Event not found.");
            }

            existingEvent.Title = dto.Title;
            existingEvent.Price = dto.Price;
            existingEvent.EventDate = dto.EventDate;   
            existingEvent.Description = dto.Description;

            int seatsAlreadyBooked = existingEvent.TotalSeats - existingEvent.AvailableSeats;

            if (dto.TotalSeats < seatsAlreadyBooked)
                throw new Exception("Cannot reduce seats below booked count.");

            existingEvent.TotalSeats = dto.TotalSeats;
            existingEvent.AvailableSeats = dto.TotalSeats - seatsAlreadyBooked;
            

            await _context.SaveChangesAsync();

            return MapToDto(existingEvent);
        }

        private EventResponseDto MapToDto(Event ev)
        {
            return new EventResponseDto
            {
                Id = ev.Id,
                Title = ev.Title,
                Description = ev.Description,
                EventDate = ev.EventDate,
                TotalSeats = ev.TotalSeats,
                AvailableSeats = ev.AvailableSeats,
                Price = ev.Price
            };
        }
    }
}
