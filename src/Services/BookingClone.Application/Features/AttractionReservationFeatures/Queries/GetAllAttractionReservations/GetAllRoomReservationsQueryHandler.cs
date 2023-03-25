using AutoMapper;
using BookingClone.Application.Features.AttractionReservationFeatures.DTOs;
using BookingClone.Domain.Contracts;
using MediatR;

namespace BookingClone.Application.Features.RoomReservationFeatures.Queries.GetAllRoomReservations;

internal sealed class GetAllAttractionReservationsQueryHandler : IRequestHandler<GetAllAttractionReservationsQuery, IEnumerable<GetAttractionReservationDto>>
{
    private readonly IRoomReservationRepository _roomReservationRepository;
    private readonly IMapper _mapper;

    public GetAllAttractionReservationsQueryHandler(IRoomReservationRepository repository, IMapper mapper)
    {
        _roomReservationRepository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetAttractionReservationDto>> Handle(GetAllAttractionReservationsQuery request, CancellationToken cancellationToken)
    {
        var reservations = await _roomReservationRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetAttractionReservationDto>>(reservations);
    }
}
