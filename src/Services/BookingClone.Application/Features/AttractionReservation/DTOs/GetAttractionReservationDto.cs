using BookingClone.Domain.Enums;

namespace BookingClone.Application.Features.AttractionReservation.DTOs;

public sealed class GetAttractionReservationDto
{
    public int ID { get; set; }

    public decimal TotalCost { get; set; }

    public ReservationStatus Status { get; set; }

    public DateTimeOffset TourStart { get; set; }
}
