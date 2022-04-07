using MovieApplication.Core.Domain.Model;
using MovieApplication.Core.Domain.Repositories;
using MovieApplication.Core.Domain.Specifications;
using Microsoft.AspNetCore.Mvc;
using MovieApplication.Storage;

public class GetMovieQuery : MediatR.IRequest<Movie>
{
    [FromQuery]
    public long MovieId { get; set; }
}

public class GetMovieQueryHandler : MediatR.IRequestHandler<GetMovieQuery, Movie>
{
    private readonly IReadOnlyRepository<Movie> _movieRepository;

    public GetMovieQueryHandler(IReadOnlyRepository<Movie> movieRepository)
    {
        _movieRepository = movieRepository;
    }
    
    public async Task<Movie> Handle(GetMovieQuery request, CancellationToken cancellationToken)
    {

        var specification = MovieSpecification.GetById(request.MovieId);
        var movie = await _movieRepository.SingleOrDefaultAsync(specification, cancellationToken);

        return movie;
    }
}