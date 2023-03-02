namespace BookingClone.Application.Features.AttractionReservationFeatures.DTOs;

public sealed class AddAttractionReservationDto
{
    public decimal TotalCost { get; set; }

    public DateTimeOffset TourStart { get; set; }
}
