using Microsoft.AspNetCore.Components.Authorization;
using System.Security.Claims;

namespace FSHandelsAppen.Client.Auth;

public class CustomAuthStateProvider : AuthenticationStateProvider
{
    // TODO: Parsa JWT-token och returnera användarinformation

    public override Task<AuthenticationState> GetAuthenticationStateAsync()
    {
        var anonymous = new ClaimsPrincipal(new ClaimsIdentity());
        return Task.FromResult(new AuthenticationState(anonymous));
    }

    public void NotifyUserLoggedIn(string token)
    {
        // TODO: Spara token och uppdatera autentiseringstillståndet
        throw new NotImplementedException();
    }

    public void NotifyUserLoggedOut()
    {
        // TODO: Ta bort token och uppdatera autentiseringstillståndet
        throw new NotImplementedException();
    }
}
