using System.Reflection;

namespace requete.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddProjectServices(this IServiceCollection services)
    {
        var types = Assembly.GetExecutingAssembly()
            .GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.Name.EndsWith("Service"));

        foreach (var type in types)
        {
            var interfaceType = type.GetInterface($"I{type.Name}");

            if (interfaceType != null)
            {
                services.AddScoped(interfaceType, type);
            }
        }
    }
}