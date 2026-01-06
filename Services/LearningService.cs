using Microsoft.EntityFrameworkCore;

using requete.Data;
using requete.DTOs.Responses;
using requete.Models.HCM;

namespace requete.Services;

public interface ILearningService
{
    Task<List<LearningResultDto>> GetUserLearnings(long userId);
    Task<List<LearningResultDto>> GetSubordinatesLearnings(long userId);
}

public class LearningService(AppDbContext context, IUserService userService) : ILearningService
{
    private readonly AppDbContext _context = context;
    private readonly IUserService _userService = userService;

    public async Task<List<LearningResultDto>> GetUserLearnings(long userId)
    {
        return await _context
            .Set<Learning>()
            .Where(x => x.PersonId == userId)
            .Select(x => new LearningResultDto(x))
            .ToListAsync();
    }

    public async Task<List<LearningResultDto>> GetSubordinatesLearnings(long userId)
    {
        var subordinateIds = (await _userService.GetSubordinates(userId)).Select(x => x.ObjectId).Distinct().ToList();
        var learnings = _context
            .Set<Learning>()
            .Where(x => x.PersonId.HasValue && subordinateIds.Contains(x.PersonId.Value))
            .Select(x => new LearningResultDto(x));

        var activeLearnings = _context
            .Set<ActiveLearning>()
            .Where(x => x.PersonId.HasValue && subordinateIds.Contains(x.PersonId.Value))
            .Select(x => new LearningResultDto(x));

        return await learnings.Union(activeLearnings).ToListAsync();
    }
}