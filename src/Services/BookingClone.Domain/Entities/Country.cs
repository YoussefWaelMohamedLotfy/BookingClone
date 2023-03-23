using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class Country : BaseEntity<int>
{
    

    public string Name { get; set; }

    public Continent Continent { get; set; }

    public List<City> Cities { get; set; }

    public Country(string name, Continent continent, List<City> cities)
    {
        Name = name;
        Continent = continent;
        Cities = cities;
    }
}
