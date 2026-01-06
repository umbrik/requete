using Microsoft.AspNetCore.Mvc;

using requete.DTOs.Responses;
using requete.Services;

namespace requete.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CoursesController(ICourseService courseService) : SessionControllerBase
{
    private readonly ICourseService _courseService = courseService;

    [HttpGet]
    public async Task<ActionResult<object>> GetCourses()
    {
        return Ok((await _courseService.GetCourses()).Select(x => new CourseDto
        {
            Id = x.Id,
            Code = x.Code,
            Name = x.Name,
            Duration = x.Duration
        }));
    }
}
