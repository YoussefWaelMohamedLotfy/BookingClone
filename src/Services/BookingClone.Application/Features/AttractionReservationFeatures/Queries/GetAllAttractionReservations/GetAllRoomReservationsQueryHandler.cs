using AutoMapper;
using BookingClone.Application.Features.AttractionReservationFeatures.DTOs;
using BookingClone.Domain.Contracts;
using MediatR;

namespace BookingClone.Application.Features.RoomReservationFeatures.Queries.GetAllRoomReservations;

internal sealed class GetAllAttractionReservationsQueryHandler : IRequestHandler<GetAllAttractionReservationsQuery, IEnumerable<GetAttractionReservationDto>>
{
    private readonly IAttractionReservationRepository _attractionReservationRepository;
    private readonly IMapper _mapper;

    public GetAllAttractionReservationsQueryHandler(IAttractionReservationRepository repository, IMapper mapper)
    {
        _attractionReservationRepository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetAttractionReservationDto>> Handle(GetAllAttractionReservationsQuery request, CancellationToken cancellationToken)
    {
        var reservations = await _attractionReservationRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAttractionReservationDto>>(reservations);
    }
}
