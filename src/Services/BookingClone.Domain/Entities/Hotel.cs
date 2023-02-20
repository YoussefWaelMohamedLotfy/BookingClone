namespace BookingClone.Domain.Entities;

public sealed class Hotel
{
    public int ID { get; set; }

    public string Name { get; set; }

    public string Description { get; set; }

    public decimal StarRating { get; set; }

    public List<CityHotel> CityHotels { get; set; }

    public List<HotelReview> Reviews { get; set; }

    public List<Room> Rooms { get; set; }
}
