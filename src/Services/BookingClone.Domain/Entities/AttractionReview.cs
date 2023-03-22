namespace BookingClone.Domain.Entities;

public sealed class AttractionReview : Review
{
    public string Comment { get; set; }

<<<<<<< HEAD
    public int AttractionID { get; set; }

=======
>>>>>>> first commit
    public Attraction Attraction { get; set; }
}
