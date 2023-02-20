namespace BookingClone.Domain.Entities;

public abstract class Review
{
    public int ID { get; set; }

    public DateTimeOffset ReviewDate { get; set; }
}
