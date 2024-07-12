namespace Application.Abstractions.Repositories
{
    public interface IAddedRepository<TEntity>
    {
        void Add( TEntity reminder );
    }
}
