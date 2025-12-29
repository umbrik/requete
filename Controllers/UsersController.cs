using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using requete.Data;
using requete.Models;
using requete.Middleware;

namespace requete.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(AppDbContext context) : ControllerBase
{
    private readonly AppDbContext _context = context;

    [HttpGet("me")]
    [RequireSession]
    public async Task<ActionResult<object>> GetCurrentUser()
    {
        if (HttpContext.Items["SessionData"] is not SessionData sessionData)
        {
            return Unauthorized();
        }

        var collaborator = await _context.Collaborators.SingleOrDefaultAsync(e => e.Id == sessionData.UserId);

        if (collaborator is null)
        {
            return NotFound(new { error = Resources.SharedResource.UserNotFound });
        }

        return Ok(new
        {
            sessionId = sessionData.SessionId,
            userId = sessionData.UserId.ToString(),
            userFullname = collaborator.Fullname
        });
    }
}
