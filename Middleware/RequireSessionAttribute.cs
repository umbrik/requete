using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;

namespace requete.Middleware;

public class RequireSessionAttribute : ActionFilterAttribute
{
    public override void OnActionExecuting(ActionExecutingContext context)
    {
        var sessionData = context.HttpContext.Items["SessionData"];

        if (sessionData == null)
        {
            context.Result = new UnauthorizedObjectResult(new { error = Resources.SharedResource.SessionNotFoundOrExpired });
            return;
        }

        base.OnActionExecuting(context);
    }
}