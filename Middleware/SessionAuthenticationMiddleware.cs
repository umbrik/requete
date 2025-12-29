using System.Security.Claims;

using requete.Services;

namespace requete.Middleware;

public class SessionAuthenticationMiddleware(RequestDelegate next, ILogger<SessionAuthenticationMiddleware> logger)
{
    private readonly RequestDelegate _next = next;
    private readonly ILogger<SessionAuthenticationMiddleware> _logger = logger;

    public async Task InvokeAsync(HttpContext context, IRedisSessionService redisService)
    {
        if (!context.Request.Cookies.TryGetValue("SessionID", out var sessionId))
        {
            _logger.LogInformation("No SessionID found in cookies");
            context.Response.StatusCode = 401;
            return;
        }

        _logger.LogInformation("Found SessionID in cookies: {SessionId}", sessionId);

        var sessionData = await redisService.GetSessionAsync(sessionId);

        if (sessionData == null)
        {
            _logger.LogWarning("Session not found in Redis for session id: {SessionId}", sessionId);
            context.Response.StatusCode = 401;
            return;
        }

        _logger.LogInformation("Session found in Redis for session id: {SessionId}", sessionId);

        var claims = new List<Claim>
        {
            new("SessionId", sessionId),
            new(ClaimTypes.NameIdentifier, sessionData.UserId.ToString())
        };

        var identity = new ClaimsIdentity(claims, "SessionAuth");
        context.User = new ClaimsPrincipal(identity);
        context.Items["SessionData"] = sessionData;

        _logger.LogInformation("User authenticated with session id: {SessionId}", sessionId);
        await _next(context);
    }
}

public static class SessionAuthenticationMiddlewareExtensions
{
    public static IApplicationBuilder UseSessionAuthentication(this IApplicationBuilder builder)
    {
        return builder.UseMiddleware<SessionAuthenticationMiddleware>();
    }
}