using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace BookingClone.Infrastructure.Repositories;

public sealed class AttractionReservationRepository : GenericRepository<AttractionReservation, int>, IAttractionReservationRepository
{
    public AttractionReservationRepository(BookingDbContext context) : base(context)
    {
    }

    public async Task<List<AttractionReservation>> GetAll(CancellationToken ct = default)
        => await _db.ToListAsync(ct);
}
