namespace BookingClone.Domain.Contracts;

public interface IGenericRepository<TEntity, TId> where TEntity : class
{
    TEntity Add(TEntity entity);
    void Delete(TEntity entity);
    Task<TEntity?> GetById(TId id, CancellationToken ct = default);
    Task<int> SaveAsync(CancellationToken ct = default);
    TEntity Update(TEntity entity);
}