using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Entities;

using MediatR;

namespace BookingClone.Application.Features.country.commands.AddCountry;
public class AddCountryCommmand : IRequest<CountryDetailsDto>
{
   

    public string Name { get; set; }

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
    public int? ContinentID { get; set; }

    

    public AddCountryCommmand(string name, int? continentID)
    {
        Name = name;
        ContinentID = continentID;
<<<<<<< HEAD
=======
    public Continent Continent { get; set; }
=======
    public int? ContinentID { get; set; }
>>>>>>> api(country_continent_city)

    

    public AddCountryCommmand(string name, int? continentID)
    {
        Name = name;
<<<<<<< HEAD
        Continent = continent;
        Cities = cities;
>>>>>>> add city and country and continent
=======
        ContinentID = continentID;
>>>>>>> api(country_continent_city)
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
    }
}
