namespace BookingClone.Domain.Entities;

public sealed class City
{
    public int ID { get; set; }

    public string Name { get; set; }

    public Country Country { get; set; }

    public List<Attraction> Attractions { get; set; }

    public List<CityHotel> CityHotels { get; set; }
}
