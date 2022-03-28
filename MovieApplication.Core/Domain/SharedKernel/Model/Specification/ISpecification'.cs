using System.Linq.Expressions;

namespace MovieApplication.Domain.Specification
{
    public interface ISpecification<TEntity> where TEntity : Entity, IAggregateRoot
    {
        Expression<Func<TEntity, bool>> IsSatisfiedBy();
    }
}