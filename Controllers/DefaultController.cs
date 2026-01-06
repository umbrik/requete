using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace requete.Controllers;

[ApiController]
[Route("/")]
public class DefaultController() : ControllerBase
{
    [HttpGet]
    [AllowAnonymous]
    public async Task<ActionResult<object>> Hello()
    {
        return Ok("Hello from Requete API!");
    }

    [HttpGet("/health")]
    [AllowAnonymous]
    public async Task<ActionResult<object>> Health()
    {
        return Ok(new { status = "healthy", timestamp = DateTime.UtcNow });
    }
}
