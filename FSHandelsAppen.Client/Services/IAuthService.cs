using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Client.Services;

public interface IAuthService
{
    Task<bool> LoginAsync(LoginRequest request);
    Task<bool> RegisterAsync(RegisterRequest request);
    Task LogoutAsync();
    bool IsLoggedIn();
}
