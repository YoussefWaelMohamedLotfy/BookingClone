using BookingClone.Domain.Entities;

namespace BookingClone.Domain.Contracts;

public interface IAttractionReservationRepository : IGenericRepository<AttractionReservation, int>
{
    Task<List<AttractionReservation>> GetAll(CancellationToken ct = default);
}