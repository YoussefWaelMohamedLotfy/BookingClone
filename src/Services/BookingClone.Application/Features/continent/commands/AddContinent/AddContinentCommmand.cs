using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Entities;

using MediatR;

namespace BookingClone.Application.Features.continent.commands.AddContinent;
public class AddContinentCommmand : IRequest<ContinentDetailsDto>
{
   
    public string Name { get; set; }

<<<<<<< HEAD
<<<<<<< HEAD
   

    public AddContinentCommmand(string name)
    {
        Name = name;
       
=======
    public List<City>? Countries { get; set; }
=======
   
>>>>>>> api(country_continent_city)

    public AddContinentCommmand(string name)
    {
        Name = name;
<<<<<<< HEAD
        Countries = countries;
>>>>>>> add city and country and continent
=======
       
>>>>>>> api(country_continent_city)
    }
}
