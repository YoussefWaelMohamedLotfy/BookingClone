using BookingClone.Domain.Common;

namespace BookingClone.Domain.Entities;

public sealed class Country : BaseEntity<int>
{
<<<<<<< HEAD
<<<<<<< HEAD
    

=======
>>>>>>> first commit
=======
    

>>>>>>> f37231b51413aa449c366de214aabaf312833b05
    public string Name { get; set; }

    public Continent Continent { get; set; }

<<<<<<< HEAD
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
=======
    public int? ContinentID { get; set; }
    public List<Cities>? Cities { get; set; }

   
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
}
