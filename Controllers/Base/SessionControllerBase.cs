using Microsoft.AspNetCore.Mvc;

using requete.Models;

namespace requete.Controllers;

[ApiController]
public abstract class SessionControllerBase : ControllerBase
{
    protected SessionData SessionData => (HttpContext.Items["SessionData"] as SessionData)!;
}
