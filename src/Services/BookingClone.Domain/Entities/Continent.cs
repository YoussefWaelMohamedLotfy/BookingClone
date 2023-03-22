using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class Continent : BaseEntity<int>
{
<<<<<<< HEAD
   

    public string Name { get; set; }

    public List<Country>? Countries { get; set; }


    
=======
    public string Name { get; set; }

    public List<Country> Countries { get; set; }
>>>>>>> first commit
}
