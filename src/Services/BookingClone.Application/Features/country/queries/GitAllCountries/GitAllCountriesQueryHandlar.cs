using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetAllCities;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.country.queries.GitAllCountries;
public class GitAllCountriesQueryHandlar : IRequestHandler<GitAllCountriesQuery, IEnumerable<CountryMinimalDto>>
{
    private readonly ICountryRepository _countryRepository;

    public GitAllCountriesQueryHandlar(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;

    }


    
    public async Task<IEnumerable<CountryMinimalDto>> Handle(GitAllCountriesQuery request, CancellationToken cancellationToken)
    {
        //return (await _countryRepository.GetAll()) /*calling */
        //.Select(a => new CountryMinimalDto { Name = a.Name });  /*Mapping*/
        var x = _countryRepository.GetAll().Result;
        var y = x.Select(a => new CountryMinimalDto { Name = a.Name });
        return (y);
    }
}
