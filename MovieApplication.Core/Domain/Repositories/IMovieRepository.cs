using MovieApplication.Core.Domain.Model;
using MovieApplication.Storage;

namespace MovieApplication.Core.Domain.Repositories;

public interface IMovieRepository : IRepository<Movie>
{
    
}