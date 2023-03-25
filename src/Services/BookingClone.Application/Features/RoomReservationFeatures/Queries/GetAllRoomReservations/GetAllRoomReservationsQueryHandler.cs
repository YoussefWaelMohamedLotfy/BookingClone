using AutoMapper;
using BookingClone.Application.Features.RoomReservationFeatures.DTOs;
using BookingClone.Domain.Contracts;
using MediatR;

namespace BookingClone.Application.Features.RoomReservationFeatures.Queries.GetAllRoomReservations;

internal sealed class GetAllRoomReservationsQueryHandler : IRequestHandler<GetAllRoomReservationsQuery, IEnumerable<GetRoomReservationDto>>
{
    private readonly IRoomReservationRepository _roomReservationRepository;
    private readonly IMapper _mapper;

    public GetAllRoomReservationsQueryHandler(IRoomReservationRepository repository, IMapper mapper)
    {
        _roomReservationRepository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<GetRoomReservationDto>> Handle(GetAllRoomReservationsQuery request, CancellationToken cancellationToken)
    {
        var reservations = await _roomReservationRepository.GetAll(cancellationToken);
        return _mapper.Map<List<GetRoomReservationDto>>(reservations);
    }
}
