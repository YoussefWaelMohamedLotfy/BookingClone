using AutoMapper;
using BookingClone.Application.Features.AttractionReservationFeatures.DTOs;
using BookingClone.Domain.Contracts;
using MediatR;

namespace BookingClone.Application.Features.AttractionReservationFeatures.Queries.GetReservedAttractionDetails;

internal sealed class GetAttractionReservationDetailsQueryHandler : IRequestHandler<GetAttractionReservationDetailsQuery, List<GetReservedAttractionDto>>
{
    private readonly IAttractionReservationRepository _attractionRepository;
    private readonly IMapper _mapper;

    public GetAttractionReservationDetailsQueryHandler(IAttractionReservationRepository attractionRepository, IMapper mapper)
    {
        _attractionRepository = attractionRepository;
        _mapper = mapper;
    }

    public async Task<List<GetReservedAttractionDto>> Handle(GetAttractionReservationDetailsQuery request, CancellationToken cancellationToken)
    {
        var details = await _attractionRepository.GetAllReservedAttractionsDetails(request.ReservationId, cancellationToken);
        return _mapper.Map<List<GetReservedAttractionDto>>(details);
    }
}
