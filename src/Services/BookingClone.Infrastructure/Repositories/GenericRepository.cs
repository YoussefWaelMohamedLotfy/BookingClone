using BookingClone.Domain.Common;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookingClone.Infrastructure.Repositories;

public abstract class GenericRepository<TEntity, TId> : IGenericRepository<TEntity, TId> where TEntity : BaseEntity<TId>
{
    private readonly BookingDbContext _context;
    protected readonly DbSet<TEntity> _db;

    public GenericRepository(BookingDbContext context)
    {
        _context = context;
        _db = context.Set<TEntity>();
    }

    public async Task<TEntity?> GetByIdAsync(TId id, CancellationToken ct = default)
        => await _db.FindAsync(new object[] { id! }, ct);

    public TEntity Add(TEntity entity)
    {
        _db.Add(entity);
        return entity;
    }

    public TEntity Update(TEntity entity)
    {
        _db.Update(entity);
        return entity;
    }

    public async Task<int> DeleteAsync(TId id, CancellationToken ct = default)
        => await _db.Where(x => x.ID!.Equals(id)).ExecuteDeleteAsync(ct);

    public async Task<int> SaveAsync(CancellationToken ct = default)
        => await _context.SaveChangesAsync(ct);
}
