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
    public int? CountryID { get; set; }

    public AddCityCommand(string name)
    {
        Name = name;

=======

    public City Country { get; set; }

    public List<Attraction>? Attractions { get; set; }

    public List<CityHotel>? CityHotels { get; set; }

    public AddCityCommand(string name, City country, List<Attraction>? attractions, List<CityHotel>? cityHotels)
    {
        Name = name;
        Country = country;
        Attractions = attractions;
        CityHotels = cityHotels;
>>>>>>> add city and country and continent
    }


}
