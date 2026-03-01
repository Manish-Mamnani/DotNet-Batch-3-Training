using EventBooking.Api.DTOs.Event;

namespace EventBooking.Api.Services.Interfaces
{
    public interface IEventService
    {
        Task<EventResponseDto> CreateEventAsync(CreateEventDto dto);
        Task<IEnumerable<EventResponseDto>> GetAllEventsAsync();
        Task<EventResponseDto> GetEventByIdAsync(int id);
        Task<EventResponseDto> UpdateEventAsync(int id, UpdateEventDto dto);
        Task<bool> DeleteEventAsync(int id);
    }
}