namespace BookingClone.Domain.Entities;

public sealed class Country
{
    public int ID { get; set; }

    public string Name { get; set; }

    public Continent Continent { get; set; }

    public List<City> Cities { get; set; }
}
