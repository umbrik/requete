using System.Xml.Linq;

using StackExchange.Redis;

using requete.Models;

namespace requete.Services;

public interface IRedisSessionService
{
    Task<SessionData?> GetSessionAsync(string sessionId);
}

public class RedisSessionService(IConnectionMultiplexer redis, ILogger<RedisSessionService> logger) : IRedisSessionService
{
    private readonly IDatabase _database = redis.GetDatabase();
    private readonly ILogger<RedisSessionService> _logger = logger;

    public async Task<SessionData?> GetSessionAsync(string sessionId)
    {
        try
        {
            var sessionData = await _database.StringGetAsync($"session_{sessionId}");

            if (!sessionData.HasValue)
            {
                return null;
            }

            string xmlString = sessionData.ToString();

            xmlString = xmlString.Replace("\0", "");

            long? userId = null;
            string? userFullname = null;

            try
            {
                var doc = XDocument.Parse(xmlString);

                userId = Convert.ToInt64(doc.Descendants("curUserID").FirstOrDefault()?.Value, 16);
                userFullname = doc.Descendants("cur_user_fullname").FirstOrDefault()?.Value;
            }
            catch (Exception xmlEx)
            {
                _logger.LogWarning(xmlEx, "Failed to parse XML for session {SessionId}, returning raw data", sessionId);
            }

            if (userId is null)
            {
                _logger.LogInformation("UserId not found in session {SessionId}", sessionId);
                return null;
            }

            return new SessionData
            {
                SessionId = Int128.Parse(sessionId),
                UserId = userId!.Value,
                UserFullname = userFullname
            };
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting session {SessionId} from Redis", sessionId);
            return null;
        }
    }
}