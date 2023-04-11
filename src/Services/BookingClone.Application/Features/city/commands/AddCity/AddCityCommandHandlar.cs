using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Bogus.DataSets;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> api(country_continent_city)
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Infrastructure.Repositories;

using MediatR;

using Microsoft.EntityFrameworkCore.Diagnostics;

<<<<<<< HEAD
<<<<<<< HEAD
=======

using MediatR;

>>>>>>> add city and country and continent
=======
>>>>>>> api(country_continent_city)
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
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
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
            CountryID=request.CountryID
        };


       
        city =  _cityRepository.Add(city);
           _cityRepository.SaveAsync(cancellationToken);
         

        return new CityDetailsDto() { Name = city.Name };


        


    }


<<<<<<< HEAD
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
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

}
