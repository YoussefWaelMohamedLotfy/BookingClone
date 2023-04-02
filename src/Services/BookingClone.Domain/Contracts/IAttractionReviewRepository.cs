using System;
using BookingClone.Domain.Entities; 

namespace BookingClone.Domain.Contracts;
 
public interface IAttractionReviewRepository : IGenericRepository<AttractionReview, int>
{
    Task<List<AttractionReview>> GetAll(CancellationToken ct = default);
}

