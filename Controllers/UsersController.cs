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
    public async Task<ActionResult<object>> GetCurrentUser()
    {
        var collaborator = await _context.Set<Collaborator>().SingleOrDefaultAsync(e => e.Id == SessionData.UserId);

        if (collaborator is null)
        {
            return NotFound(new { error = Resources.SharedResource.UserNotFound });
        }

        return Ok(new
        {
            sessionId = SessionData.SessionId,
            userId = SessionData.UserId.ToString(),
            userFullname = collaborator.Fullname
        });
    }

    [HttpGet("managers")]
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
                Position = x.PersonPosition!.Name
            })
            .ToListAsync();

        return Ok(managers);
    }

    [HttpGet("subordinates")]
    public async Task<ActionResult<object>> GetSubordinates()
    {
        var managers = await _context
            .Set<FuncManager>()
            .Where(x => x.PersonId == SessionData!.UserId)
            .Include(x => x.Object)
            .Select(x => new ManagerDto
            {
                Id = x.ObjectId,
                Fullname = x.ObjectName,
                Position = x.Object!.PositionName
            })
            .ToListAsync();

        return Ok(managers);
    }
}
