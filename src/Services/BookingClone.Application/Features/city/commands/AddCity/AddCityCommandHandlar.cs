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
using BookingClone.Infrastructure.Repositories;

using MediatR;

using Microsoft.EntityFrameworkCore.Diagnostics;

=======

using MediatR;

>>>>>>> add city and country and continent
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

        var city = new City
        {
            Name = request.Name,
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
        };



         city =  _cityRepository.Add(city);
        return new CityDetailsDto() { Name = city.Name, Attractions = city.Attractions, CityHotels = city.CityHotels, Country = city.Country };



        
    }

   
>>>>>>> add city and country and continent

}
