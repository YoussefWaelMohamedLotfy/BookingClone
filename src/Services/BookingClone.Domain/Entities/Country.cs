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
<<<<<<< HEAD
    public int? ContinentID { get; set; }
    public List<City>? Cities { get; set; }
=======
    public int? ContinentID { get; set; }
    public List<Cities>? Cities { get; set; }
>>>>>>> api(country_continent_city)

   
=======
    public List<City> Cities { get; set; }
>>>>>>> first commit
=======
    public List<City>? Cities { get; set; }

   
>>>>>>> add city and country and continent
}
