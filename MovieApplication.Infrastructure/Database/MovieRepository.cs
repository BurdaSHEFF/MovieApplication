using MovieApplication.Core.Domain.Model;
using MovieApplication.Core.Domain.Repositories;
using MovieApplication.Storage.EntityFramework;

namespace MovieApplication.Infrastructure.Database;

public sealed class MovieRepository : EFRepository<Movie>, IMovieRepository
{
    public MovieRepository(MovieApplicationContext context) : base(context)
    {
    }
}