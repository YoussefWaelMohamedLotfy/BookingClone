using BookingClone.Application.Features.RoomReservationFeatures.DTOs;
using MediatR;

namespace BookingClone.Application.Features.RoomReservationFeatures.Queries.GetAllRoomReservations;

public sealed class GetAllRoomReservationsQuery : IRequest<IEnumerable<GetRoomReservationDto>>
{
}
