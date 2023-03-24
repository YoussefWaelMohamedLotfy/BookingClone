using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class City : BaseEntity<int>
{
    

    public string Name { get; set; }

    public City Country { get; set; }

    public List<Attraction>? Attractions { get; set; }

    public List<CityHotel>? CityHotels { get; set; }

    //public City(string name, City country, List<Attraction>? attractions, List<CityHotel>? cityHotels)
    //{
    //    Name = name;
    //    Country = country;
    //    Attractions = attractions;
    //    CityHotels = cityHotels;
    //}
}
