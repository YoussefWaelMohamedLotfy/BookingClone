using BookingClone.Domain.Enums;

namespace BookingClone.Domain.Entities;

public abstract class Reservation
{
    public int ID { get; set; }

    public decimal TotalCost { get; set; }

    public ReservationStatus Status { get; set; }
}
