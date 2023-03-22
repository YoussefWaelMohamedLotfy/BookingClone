using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class Country : BaseEntity<int>
{
<<<<<<< HEAD
    

=======
>>>>>>> first commit
    public string Name { get; set; }

    public Continent Continent { get; set; }

<<<<<<< HEAD
    public int? ContinentID { get; set; }
    public List<City>? Cities { get; set; }

   
=======
    public List<City> Cities { get; set; }
>>>>>>> first commit
}
