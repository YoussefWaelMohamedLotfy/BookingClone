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
<<<<<<< HEAD
    public int? ContinentID { get; set; }
    public List<City>? Cities { get; set; }

   
=======
    public List<City> Cities { get; set; }
>>>>>>> first commit
=======
    public List<City>? Cities { get; set; }

   
>>>>>>> add city and country and continent
}
