using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.commands.AddCity;
using BookingClone.Application.Features.city.DTOs;
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> api(country_continent_city)
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Repositories;

<<<<<<< HEAD
=======
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
>>>>>>> add city and country and continent
=======
>>>>>>> api(country_continent_city)
using MediatR;

namespace BookingClone.Application.Features.country.commands.AddCountry;
public class AddCountryCommmandHandlar : IRequestHandler<AddCountryCommmand, CountryDetailsDto>
{
    private readonly ICountryRepository _countryRepository;

    public AddCountryCommmandHandlar(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;

    }

    public async Task<CountryDetailsDto> Handle(AddCountryCommmand request, CancellationToken cancellationToken)
    {
        var country = new Country
        {
            Name = request.Name,
<<<<<<< HEAD
<<<<<<< HEAD
            ContinentID = request.ContinentID,


=======
            Continent = request.Continent,
            Cities = request.Cities,
           
>>>>>>> add city and country and continent
=======
            ContinentID = request.ContinentID,


>>>>>>> api(country_continent_city)
        };



        country =  _countryRepository.Add(country);
<<<<<<< HEAD
<<<<<<< HEAD

        _countryRepository.SaveAsync(cancellationToken);

        return new CountryDetailsDto()
        {
            Name = country.Name,
            //ContinentID = country.ContinentID,


        };


       
=======
=======

        _countryRepository.SaveAsync(cancellationToken);

>>>>>>> api(country_continent_city)
        return new CountryDetailsDto()
        {
            Name = country.Name,
            //ContinentID = country.ContinentID,


        };


<<<<<<< HEAD
            };
>>>>>>> add city and country and continent
=======
       
>>>>>>> api(country_continent_city)
    }


  

}
