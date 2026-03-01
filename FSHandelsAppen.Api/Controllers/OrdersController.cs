using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FSHandelsAppen.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
[Authorize]
public class OrdersController : ControllerBase
{
    // TODO: Injektera IOrderService via konstruktor

    [HttpGet]
    [Authorize(Roles = "Admin")]
    public async Task<IActionResult> GetAll()
    {
        throw new NotImplementedException();
    }

    [HttpGet("my")]
    public async Task<IActionResult> GetMyOrders()
    {
        throw new NotImplementedException();
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        throw new NotImplementedException();
    }

    [HttpPost]
    public async Task<IActionResult> Create()
    {
        throw new NotImplementedException();
    }
}
