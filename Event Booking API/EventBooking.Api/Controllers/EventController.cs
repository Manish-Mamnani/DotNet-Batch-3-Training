using EventBooking.Api.DTOs.Event;
using EventBooking.Api.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EventBooking.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class EventController : ControllerBase
    {
        private readonly IEventService _eventService;

        public EventController(IEventService eventService)
        {
            _eventService = eventService;
        }

        [Authorize]
        [HttpGet]
        public async Task<IActionResult> GetAllEvents()
        {
            var events = await _eventService.GetAllEventsAsync();
            return Ok(events);
        }

        [Authorize]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEventById(int id)
        {
            try
            {
                var ev = await _eventService.GetEventByIdAsync(id);
                return Ok(ev);
            }
            catch (Exception ex)
            {
                return NotFound(new { error = ex.Message });
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateEvent([FromBody]CreateEventDto dto)
        {
            try
            {
                var createdEvent = await _eventService.CreateEventAsync(dto);
                return CreatedAtAction(
                    nameof(GetEventById),
                    new { id = createdEvent.Id },
                    createdEvent
                );
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateEvent(int id, UpdateEventDto dto)
        {
            try
            {
                var updatedEvent = await _eventService.UpdateEventAsync(id, dto);
                return Ok(updatedEvent);
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEvent(int id)
        {
            try
            {
                await _eventService.DeleteEventAsync(id);
                return NoContent();
            }
            catch (Exception ex)
            {
                return NotFound(new { error = ex.Message });
            }
        }
    }
}