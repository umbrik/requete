using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using requete.Data;
using requete.Models;
using requete.Middleware;

namespace requete.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LearningsController(AppDbContext context, ILogger<LearningsController> logger) : ControllerBase
{
    private readonly AppDbContext _context = context;
    private readonly ILogger<LearningsController> _logger = logger;

    [HttpGet("all")]
    [RequireSession]
    public async Task<ActionResult<object>> GetAllLearnings()
    {
        if (HttpContext.Items["SessionData"] is not SessionData sessionData)
        {
            return Unauthorized();
        }

        var learnings = await _context.Learnings.ToListAsync();

        return Ok(learnings);
    }
}
