using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

using requete.Data;
using requete.Models;
using requete.Services;

namespace requete.Controllers;

[ApiController]
[Route("api/[controller]")]
public class LearningsController(ILearningService learningService) : SessionControllerBase
{
    private readonly ILearningService _learningService = learningService;

    [HttpGet]
    public async Task<ActionResult<object>> GetLearnings()
    {
        return Ok(await _learningService.GetUserLearnings(SessionData.UserId));
    }

    [HttpGet("subordinates")]
    public async Task<ActionResult<object>> GetSubordinatesLearnings()
    {
        return Ok(await _learningService.GetUserSubordinatesLearnings(SessionData.UserId));
    }
}
