using Microsoft.EntityFrameworkCore;

using requete.Data;
using requete.Models;

namespace requete.Services;

public interface ILearningService
{
    Task<List<Learning>> GetUserLearnings(long userId);
    Task<List<Learning>> GetSubordinatesLearnings(long userId);
}

public class LearningService(AppDbContext context, IUserService userService) : ILearningService
{
    private readonly AppDbContext _context = context;
    private readonly IUserService _userService = userService;

    public async Task<List<Learning>> GetUserLearnings(long userId)
    {
        return await _context.Set<Learning>().Where(x => x.PersonId == userId).ToListAsync();
    }

    public async Task<List<Learning>> GetSubordinatesLearnings(long userId)
    {
        var subordinateIds = (await _userService.GetSubordinates(userId)).Select(x => x.PersonId).Distinct().ToList();
        subordinateIds.ForEach(x => Console.WriteLine(x));

        return await _context
            .Set<Learning>()
            .Where(x => x.PersonId.HasValue && subordinateIds.Contains(x.PersonId.Value))
            .ToListAsync();
    }
}