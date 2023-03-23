using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class Continent : BaseEntity<int>
{
   

    public string Name { get; set; }

    public List<Country> Countries { get; set; }


    public Continent(string name, List<Country> countries)
    {
        Name = name;
        Countries = countries;
    }
}
