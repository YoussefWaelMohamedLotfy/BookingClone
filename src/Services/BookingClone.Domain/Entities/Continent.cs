using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class Continent : BaseEntity<int>
{
<<<<<<< HEAD
   

    public string Name { get; set; }

<<<<<<< HEAD
<<<<<<< HEAD
    public List<Country>? Countries { get; set; }

=======
    public List<City>? Countries { get; set; }
>>>>>>> add city and country and continent
=======
    public List<Country>? Countries { get; set; }
>>>>>>> api(country_continent_city)

    
=======
    public string Name { get; set; }

<<<<<<< HEAD
    public List<Country> Countries { get; set; }
>>>>>>> first commit
=======
    
>>>>>>> add city and country and continent
}
