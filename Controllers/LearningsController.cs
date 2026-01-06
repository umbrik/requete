using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using requete.Data;
using requete.Models;

namespace requete.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LearningsController(AppDbContext context) : SessionControllerBase
{
    private readonly AppDbContext _context = context;

    [HttpGet("all")]
    public async Task<ActionResult<object>> GetAllLearnings()
    {
        var learnings = await _context.Set<Learning>().Where(x => x.PersonId == SessionData.UserId).ToListAsync();
        return Ok(learnings);
    }
}
