using FSHandelsAppen.Api.Services.Interfaces;
using FSHandelsAppen.Shared.DTOs;

namespace FSHandelsAppen.Api.Services;

public class AuthService : IAuthService
{
    // TODO: Injektera IConfiguration för JWT-tokengenerering

    public Task<LoginResponse?> LoginAsync(LoginRequest request) => throw new NotImplementedException();
    public Task<bool> RegisterAsync(RegisterRequest request) => throw new NotImplementedException();
}
