using Microsoft.AspNetCore.Mvc;

using requete.DTOs.Responses;
using requete.Models.HCM;
using requete.Services;

namespace requete.Controllers;

[ApiController]
[Route("api/[controller]")]
public class UsersController(IUserService userService) : SessionControllerBase
{
    private readonly IUserService _userService = userService;

    [HttpGet("me")]
    public async Task<ActionResult<object>> GetCurrentUser()
    {
        var user = await _userService.GetUserDetails(SessionData.UserId);

        if (user is null)
        {
            return NotFound(new { error = Resources.SharedResource.UserNotFound });
        }

        return Ok(new
        {
            sessionId = SessionData.SessionId,
            userId = SessionData.UserId.ToString(),
            userFullname = user.Fullname
        });
    }

    [HttpGet("managers")]
    public async Task<ActionResult<object>> GetManagers()
    {
        return Ok((await _userService.GetManagers(SessionData.UserId)).Select(x => new UserDto(x)));
    }

    [HttpGet("subordinates")]
    public async Task<ActionResult<object>> GetSubordinates()
    {
        return Ok((await _userService.GetSubordinates(SessionData.UserId)).Select(x => new UserDto(x)));
    }
}
