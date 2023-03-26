using BookingClone.Application.Features.AttractionReservationFeatures.DTOs;
using MediatR;

namespace BookingClone.Application.Features.RoomReservationFeatures.Queries.GetAllRoomReservations;

public sealed class GetAllAttractionReservationsQuery : IRequest<IEnumerable<GetAttractionReservationDto>>
{
}
