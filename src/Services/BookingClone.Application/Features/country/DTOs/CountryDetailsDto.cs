using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.country.DTOs;
public class CountryDetailsDto
{
<<<<<<< HEAD
<<<<<<< HEAD

    public int? ID { get; set; }
    public int? ContinentID { get; set; }
    public string? Name { get; set; }

    
=======
    
=======
>>>>>>> finalcommit

    public int ID { get; set; }
    public string Name { get; set; }

<<<<<<< HEAD
    public Continent? Continent { get; set; }

    public List<City>? Cities { get; set; }
>>>>>>> add city and country and continent
=======
    
>>>>>>> api(country_continent_city)

  
}
