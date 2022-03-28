using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieApplication.Startup.Features.Movie;

namespace MovieApplication.Startup.Controllers;

public class MoviesController : Controller
{
    private readonly IMediator _mediator;

    public MoviesController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpGet]
    [Route("~/getMovie")]
    public async Task<IActionResult> GetMovie(GetMovieQuery request, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(request, cancellationToken);
        return Ok(result);
    }

    [HttpPost]
    [Route("~/createNewMovie")]
    public async Task<IActionResult> CreateNewMovie([FromBody]CreateNewMovieCommand movieCommand, CancellationToken cancellationToken)
    {
        var result = await _mediator.Send(movieCommand, cancellationToken);
        return Ok();
    }

}