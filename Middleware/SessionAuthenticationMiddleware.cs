using System.Security.Claims;
using requete.Services;

namespace requete.Middleware;

public class SessionAuthenticationMiddleware(
    RequestDelegate next,
    ILogger<SessionAuthenticationMiddleware> logger)
{
    private readonly RequestDelegate _next = next;
    private readonly ILogger<SessionAuthenticationMiddleware> _logger = logger;

    public async Task InvokeAsync(HttpContext context, IRedisSessionService redisService)
    {
        if (!context.Request.Cookies.TryGetValue("SessionID", out var sessionId))
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync(Resources.SharedResource.SessionNotFoundInCookies);
            return;
        }

        var sessionData = await redisService.GetSessionAsync(sessionId);

        if (sessionData == null)
        {
            context.Response.StatusCode = 401;
            await context.Response.WriteAsync(Resources.SharedResource.SessionNotFoundOrExpired);
            return;
        }

        var claims = new List<Claim>
        {
            new("SessionId", sessionId),
            new(ClaimTypes.NameIdentifier, sessionData.UserId.ToString())
        };

        var identity = new ClaimsIdentity(claims, "SessionAuth");
        context.User = new ClaimsPrincipal(identity);
        context.Items["SessionData"] = sessionData;

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