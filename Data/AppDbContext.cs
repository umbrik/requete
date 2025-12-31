using System.ComponentModel.DataAnnotations.Schema;
using System.Reflection;
using Microsoft.EntityFrameworkCore;

using requete.Models;

namespace requete.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        // Get all types in the same namespace as one of your models
        var entityTypes = typeof(Account).Assembly.GetTypes()
            .Where(t => t.IsClass && !t.IsAbstract && t.Namespace == "requete.Models" && t.GetCustomAttribute<TableAttribute>() is not null);

        foreach (var type in entityTypes)
        {
            modelBuilder.Entity(type);
        }
    }
}