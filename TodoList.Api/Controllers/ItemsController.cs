using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TodoList.Api.Controllers;

[Route("[controller]")]
public class ItemsController : ApiController
{
    [HttpGet]
    public async Task<IActionResult> ListItems()
    {
        await Task.CompletedTask;
        return Ok(Array.Empty<string>());
    }
}
