using Microsoft.EntityFrameworkCore;

using requete.Models;

namespace requete.Data;

public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
{

    public DbSet<Collaborator> Collaborators { get; set; }
    public DbSet<Learning> Learnings { get; set; }
}