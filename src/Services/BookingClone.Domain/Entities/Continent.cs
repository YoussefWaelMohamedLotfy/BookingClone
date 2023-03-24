using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class Continent : BaseEntity<int>
{
   

    public string Name { get; set; }

    public List<City>? Countries { get; set; }


    
}
