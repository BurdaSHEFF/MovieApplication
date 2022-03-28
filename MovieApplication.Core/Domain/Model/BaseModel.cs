using MovieApplication.Domain;

namespace MovieApplication.Core.Domain.Model;

public class BaseModel : Entity
{
    public long Id { get; set; }
}