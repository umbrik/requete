using Microsoft.AspNetCore.Mvc;

using requete.Models.HCM;
using requete.Services;

namespace requete.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SessionController(IRedisSessionService redisService) : ControllerBase
{
    private readonly IRedisSessionService _redisService = redisService;

    /// <summary>
    /// Get session data based on SessionID cookie.
    /// </summary>
    [HttpGet]
    [ProducesResponseType(typeof(SessionData), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(StatusCodes.Status404NotFound)]
    public async Task<ActionResult<SessionData>> GetSession()
    {
        if (!Request.Cookies.TryGetValue("SessionID", out var sessionId))
        {
            return Unauthorized(new { error = Resources.SharedResource.SessionNotFoundInCookies });
        }

        var sessionData = await _redisService.GetSessionAsync(sessionId);

        if (sessionData == null)
        {
            return NotFound(new { error = Resources.SharedResource.SessionNotFoundOrExpired });
        }

        return Ok(sessionData);
    }
}