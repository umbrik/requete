using Microsoft.EntityFrameworkCore;

using requete.Data;
using requete.Models;

namespace requete.Services;

public interface IUserService
{
    Task<List<FuncManager>> GetManagers(long userId);
    Task<List<FuncManager>> GetSubordinates(long userId);
    Task<Collaborator?> GetUserDetails(long userId);
}

public class UserService(AppDbContext context, ILogger<UserService> logger) : IUserService
{
    private readonly AppDbContext _context = context;
    private readonly ILogger<UserService> _logger = logger;

    public async Task<List<FuncManager>> GetManagers(long userId)
    {
        return await _context
            .Set<FuncManager>()
            .Where(x => x.ObjectId == userId)
            .Include(x => x.PersonPosition)
            .ToListAsync();
    }

    public async Task<List<FuncManager>> GetSubordinates(long userId)
    {
        return await _context
            .Set<FuncManager>()
            .Where(x => x.PersonId == userId && x.Catalog == "collaborator")
            .Include(x => x.Object)
            .ToListAsync();
    }

    public async Task<Collaborator?> GetUserDetails(long userId)
    {
        return await _context.Set<Collaborator>().SingleOrDefaultAsync(e => e.Id == userId);
    }
}