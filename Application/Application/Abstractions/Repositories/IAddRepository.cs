namespace Application.Abstractions.Repositories
{
    public interface IAddRepository<TEntity>
    {
        void Add( TEntity cart );
    }
}