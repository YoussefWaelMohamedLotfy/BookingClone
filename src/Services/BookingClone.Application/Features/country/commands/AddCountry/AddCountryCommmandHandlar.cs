using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.commands.AddCity;
using BookingClone.Application.Features.city.DTOs;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> api(country_continent_city)
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Repositories;

<<<<<<< HEAD
<<<<<<< HEAD
=======
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
>>>>>>> add city and country and continent
=======
>>>>>>> api(country_continent_city)
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
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
<<<<<<< HEAD
            ContinentID = request.ContinentID,


=======
            Continent = request.Continent,
            Cities = request.Cities,
           
>>>>>>> add city and country and continent
=======
            ContinentID = request.ContinentID,


>>>>>>> api(country_continent_city)
=======
            ContinentID = request.ContinentID,


>>>>>>> f37231b51413aa449c366de214aabaf312833b05
        };



        country =  _countryRepository.Add(country);
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

        _countryRepository.SaveAsync(cancellationToken);

        return new CountryDetailsDto()
        {
            Name = country.Name,
            //ContinentID = country.ContinentID,


        };


       
<<<<<<< HEAD
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
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
    }


  

}
