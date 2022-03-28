using MovieApplication.Domain;

namespace MovieApplication.Core.Domain.Model;

public class Movie : BaseModel, IAggregateRoot
{
    public string Title { get; set; }
    public string Description { get; set; }
    public string TrailerPath { get; set; }
    public string MoviePath { get; set; }
    public DateTime ReleaseDate { get; set; }
}