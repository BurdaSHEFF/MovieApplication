namespace MovieApplication.Domain
{
    public interface IKey<TEntity>
    {
        TEntity New();
    }
}