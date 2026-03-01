using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Client.Services;

public class AuthService : IAuthService
{
    // TODO: Injektera HttpClient och CustomAuthStateProvider

    public Task<bool> LoginAsync(LoginRequest request) => throw new NotImplementedException();
    public Task<bool> RegisterAsync(RegisterRequest request) => throw new NotImplementedException();
    public Task LogoutAsync() => throw new NotImplementedException();
    public bool IsLoggedIn() => throw new NotImplementedException();
}
