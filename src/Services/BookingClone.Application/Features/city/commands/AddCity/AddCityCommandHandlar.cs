using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bogus.DataSets;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> api(country_continent_city)
using BookingClone.Infrastructure.Repositories;

using MediatR;

using Microsoft.EntityFrameworkCore.Diagnostics;

<<<<<<< HEAD
=======

using MediatR;

>>>>>>> add city and country and continent
=======
>>>>>>> api(country_continent_city)
namespace BookingClone.Application.Features.city.commands.AddCity;
public class AddCityCommandHandlar : IRequestHandler<AddCityCommand, CityDetailsDto>
{
    private readonly ICityRepository _cityRepository;

    public AddCityCommandHandlar(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }


    public async Task<CityDetailsDto> Handle(AddCityCommand request, CancellationToken cancellationToken)
    {

        var city = new Cities
        {
            Name = request.Name,
<<<<<<< HEAD
<<<<<<< HEAD
            CountryID=request.CountryID
        };


       
        city =  _cityRepository.Add(city);
           _cityRepository.SaveAsync(cancellationToken);
         

        return new CityDetailsDto() { Name = city.Name };


        


    }


=======
            Country = request.Country,
            Attractions = request.Attractions,
            CityHotels = request.CityHotels
=======
            CountryID=request.CountryID
>>>>>>> api(country_continent_city)
        };


       
        city =  _cityRepository.Add(city);
           _cityRepository.SaveAsync(cancellationToken);
         

        return new CityDetailsDto() { Name = city.Name };


        


    }

<<<<<<< HEAD
   
>>>>>>> add city and country and continent
=======

>>>>>>> api(country_continent_city)

}
