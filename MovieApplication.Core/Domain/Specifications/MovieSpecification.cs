using MovieApplication.Core.Domain.Model;
using MovieApplication.Domain.Specification;

namespace MovieApplication.Core.Domain.Specifications;

public static class MovieSpecification
{
    public static ISpecification<Movie> GetById(long movieId) => Specification<Movie>.Create(x => x.Id == movieId);
    public static ISpecification<Movie> GetByDate(DateTime date) => Specification<Movie>.Create(x => x.ReleaseDate == date);
}