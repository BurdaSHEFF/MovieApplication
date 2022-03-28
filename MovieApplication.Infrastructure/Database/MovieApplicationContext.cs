using MovieApplication.Core.Domain.Model;
using MovieApplication.Storage;
using Microsoft.EntityFrameworkCore;

namespace MovieApplication.Infrastructure.Database;

public class MovieApplicationContext : DbContext, IUnitOfWork
{
    public MovieApplicationContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
    {
        
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(MovieApplicationContext).Assembly);
        
        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Movie> Movies { get; set; }
}