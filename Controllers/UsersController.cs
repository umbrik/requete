using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using requete.Data;
using requete.Models;
using requete.Middleware;
using requete.DTOs.Responses;

namespace requete.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(AppDbContext context) : SessionControllerBase
{
    private readonly AppDbContext _context = context;

    [HttpGet("me")]
    [RequireSession]
    public async Task<ActionResult<object>> GetCurrentUser(SessionData sessionData)
    {
        var collaborator = await _context.Set<Collaborator>().SingleOrDefaultAsync(e => e.Id == sessionData.UserId);

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

    [HttpGet("managers")]
    [RequireSession]
    public async Task<ActionResult<object>> GetManagers()
    {
        var managers = await _context
            .Set<FuncManager>()
            .Where(x => x.ObjectId == SessionData!.UserId)
            .Include(x => x.PersonPosition)
            .Select(x => new ManagerDto
            {
                Id = x.PersonId,
                Fullname = x.PersonFullname,
                Position = x.PersonPosition.Name
            })
            .ToListAsync();

        return Ok(managers);
    }
}
