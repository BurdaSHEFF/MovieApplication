using MovieApplication.Infrastructure.Database;
using MediatR;

namespace MovieApplication.Startup.Features.Movie;

public class CreateNewMovieCommand : IRequest<bool>
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string TrailerPath { get; set; }
    public string MoviePath { get; set; }
    public DateTime ReleaseDate { get; set; }
}

public class CreateNewMovieCommandHandler : IRequestHandler<CreateNewMovieCommand, bool>
{
    private readonly MovieApplicationContext _movieApplicationContext;

    public CreateNewMovieCommandHandler(MovieApplicationContext _movieApplicationContext)
    {
        this._movieApplicationContext = _movieApplicationContext;
    }
    
    public async Task<bool> Handle(CreateNewMovieCommand request, CancellationToken cancellationToken)
    {
        var movie = new Core.Domain.Model.Movie()
        {
            Title = request.Title,
            Description = request.Description,
            TrailerPath = request.TrailerPath,
            MoviePath = request.MoviePath,
            ReleaseDate = request.ReleaseDate
        };

        await _movieApplicationContext.Movies.AddAsync(movie, cancellationToken);
        var result = await _movieApplicationContext.SaveChangesAsync(cancellationToken);

        return result > 0;
    }
}