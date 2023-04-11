using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class Continent : BaseEntity<int>
{
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
   

    public string Name { get; set; }

<<<<<<< HEAD
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
=======
    public List<Country>? Countries { get; set; }


    
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
}
