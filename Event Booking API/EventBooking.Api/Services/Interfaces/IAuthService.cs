using EventBooking.Api.DTOs.Auth;

namespace EventBooking.Api.Services.Interfaces
{
    public interface IAuthService
    {
        Task<string> RegisterAsync(RegisterRequestDto request);
        Task<AuthResponseDto> LoginAsync(LoginRequestDto request);
    }
}
