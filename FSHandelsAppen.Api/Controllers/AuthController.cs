using Microsoft.AspNetCore.Mvc;

namespace FSHandelsAppen.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class AuthController : ControllerBase
{
    // TODO: Injektera IAuthService via konstruktor

    [HttpPost("login")]
    public async Task<IActionResult> Login()
    {
        throw new NotImplementedException();
    }

    [HttpPost("register")]
    public async Task<IActionResult> Register()
    {
        throw new NotImplementedException();
    }
}
