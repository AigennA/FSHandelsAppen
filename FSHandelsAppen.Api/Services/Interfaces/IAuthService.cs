using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Api.Services.Interfaces;

public interface IAuthService
{
    Task<LoginResponse?> LoginAsync(LoginRequest request);
    Task<bool> RegisterAsync(RegisterRequest request);
}
