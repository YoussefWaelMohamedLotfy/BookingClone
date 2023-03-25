using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class Cities : BaseEntity<int>
{
    

    public string Name { get; set; }
    public int? CountryID { get; set; }
    public Country Country { get; set; }

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
