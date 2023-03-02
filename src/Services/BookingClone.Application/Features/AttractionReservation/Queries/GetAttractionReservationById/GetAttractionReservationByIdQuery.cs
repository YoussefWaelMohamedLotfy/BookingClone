using BookingClone.Application.Features.AttractionReservation.DTOs;

using MediatR;

namespace BookingClone.Application.Features.AttractionReservation.Queries.GetAttractionReservationById;

public sealed class GetAttractionReservationByIdQuery : IRequest<GetAttractionReservationDto?>
{
    public required int ID { get; set; }
}
