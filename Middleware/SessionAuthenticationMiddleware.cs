using System.Security.Claims;
using requete.Services;

namespace requete.Middleware;

public class SessionAuthenticationMiddleware(RequestDelegate next)
{
    private readonly RequestDelegate _next = next;
    private readonly string[] whiteList =
    [
        "favicon.ico",
        "/scalar/v1",
        "/openapi/v1.json",
    ];

    public async Task InvokeAsync(HttpContext context, IRedisSessionService redisService)
    {
        if (whiteList.Any(path => context.Request.Path.Value?.Contains(path) == true))
        {
            await _next(context);
            return;
        }

        if (HttpMethods.IsOptions(context.Request.Method))
        {
            await _next(context);
            return;
        }

        var endpoint = context.GetEndpoint();

        if (endpoint is null)
        {
            context.Response.StatusCode = 404;
            await context.Response.WriteAsync(Resources.SharedResource.EndpointNotFound);
            return;
        }

        if (endpoint?.Metadata.GetMetadata<Microsoft.AspNetCore.Authorization.AllowAnonymousAttribute>() != null)
        {
            await _next(context);
            return;
        }

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