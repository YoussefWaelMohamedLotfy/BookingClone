using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Domain.Entities;

using MediatR;

namespace BookingClone.Application.Features.city.commands.AddCity;
public class AddCityCommand : IRequest<CityDetailsDto>
{
    

    public string Name { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
    public int? CountryID { get; set; }

    public AddCityCommand(string name)
    {
        Name = name;

<<<<<<< HEAD
=======
=======
    public int? CountryID { get; set; }
>>>>>>> api(country_continent_city)

    public AddCityCommand(string name)
    {
        Name = name;
<<<<<<< HEAD
        Country = country;
        Attractions = attractions;
        CityHotels = cityHotels;
>>>>>>> add city and country and continent
=======

>>>>>>> api(country_continent_city)
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
    }

    public AddCityCommand(string name, int? countryID)
    {
        Name = name;
        CountryID = countryID;
    }
}
