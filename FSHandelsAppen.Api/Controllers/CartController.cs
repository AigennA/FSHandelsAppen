using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FSHandelsAppen.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class CartController : ControllerBase
{
    // TODO: Injektera ICartService via konstruktor

    [HttpGet]
    public async Task<IActionResult> GetCart()
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> AddToCart()
    {
        throw new NotImplementedException();
    }

    [HttpDelete("{productId}")]
    public async Task<IActionResult> RemoveFromCart(int productId)
    {
        throw new NotImplementedException();
    }
}
