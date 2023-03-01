using BookingClone.Domain.Common;

namespace BookingClone.Domain.Contracts;

public interface IGenericRepository<TEntity, TId> where TEntity : BaseEntity<TId>
{
    TEntity Add(TEntity entity);
    Task<int> Delete(TId id);
    Task<TEntity?> GetById(TId id, CancellationToken ct = default);
    Task<int> SaveAsync(CancellationToken ct = default);
    TEntity Update(TEntity entity);
}