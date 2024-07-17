namespace Application.Abstractions.Repositories
{
    public interface IRemoveRepository<TEntity>
    {
        void Remove( TEntity cart );
    }
}