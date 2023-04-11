using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
=======

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetAllCities;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;
>>>>>>> select
=======
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
>>>>>>> country,continent,city
=======
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

using MediatR;

namespace BookingClone.Application.Features.country.queries.GitAllCountries;
public class getAllCountrieswithoutpaginationQueryHandlar : IRequestHandler<GetAllCountriesQuerywithoutpagination, IEnumerable<CountryDetailsDto>>
{
    private readonly ICountryRepository _countryRepository;

    public getAllCountrieswithoutpaginationQueryHandlar(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;

    }


    
    public async Task<IEnumerable<CountryDetailsDto>> Handle(GetAllCountriesQuerywithoutpagination request, CancellationToken cancellationToken)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
        //return (await _countryRepository.GetAll()) /*calling */
        //.Select(a => new CountryMinimalDto { Name = a.Name });  /*Mapping*/
>>>>>>> select
=======
>>>>>>> almostdone
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
        var Country = _countryRepository.GetAll().Result;
        var CountryDto = Country.Select(a => new CountryDetailsDto { Name = a.Name,ID=a.ID });
        return (CountryDto);
    }
}
