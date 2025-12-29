using Microsoft.AspNetCore.Mvc;

using requete.Services;
using requete.Models;

namespace requete.Controllers;

[ApiController]
[Route("api/[controller]")]
public class SessionController(IRedisSessionService redisService, ILogger<SessionController> logger) : ControllerBase
{
    private readonly IRedisSessionService _redisService = redisService;
    private readonly ILogger<SessionController> _logger = logger;

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
            _logger.LogWarning("No SessionID cookie found");
            return Unauthorized(new { error = "No session found" });
        }

        var sessionData = await _redisService.GetSessionAsync(sessionId);

        if (sessionData == null)
        {
            _logger.LogWarning("Session not found in Redis: {SessionId}", sessionId);
            return NotFound(new { error = "Session not found or expired" });
        }

        _logger.LogInformation("Session retrieved: {SessionId}", sessionId);
        return Ok(sessionData);
    }
}