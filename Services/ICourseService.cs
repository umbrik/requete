using Microsoft.EntityFrameworkCore;

using requete.Data;
using requete.Models;

namespace requete.Services;

public interface ICourseService
{
    Task<List<Course>> GetCourses();
}

public class CourseService(AppDbContext context) : ICourseService
{
    private readonly AppDbContext _context = context;

    public async Task<List<Course>> GetCourses()
    {
        return await _context.Set<Course>().ToListAsync();
    }
}