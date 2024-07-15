namespace Application.Abstractions.Repositories
{
    public interface IUpdateRepository<TEntity>
    {
        void Update( TEntity cart );
    }
}