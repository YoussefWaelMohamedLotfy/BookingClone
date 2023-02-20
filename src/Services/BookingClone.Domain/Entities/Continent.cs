namespace BookingClone.Domain.Entities;

public sealed class Continent
{
    public int ID { get; set; }

    public string Name { get; set; }

    public List<Country> Countries { get; set; }
}
