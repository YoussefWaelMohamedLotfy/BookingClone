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
public class getAllCountrieswithoutpaginationQueryHandlar : IRequestHandler<GetAllCountriesQuerywithoutpagination, IEnumerable<CountryDetailsDto>>
{
    private readonly ICountryRepository _countryRepository;

    public getAllCountrieswithoutpaginationQueryHandlar(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;

    }


    
    public async Task<IEnumerable<CountryDetailsDto>> Handle(GetAllCountriesQuerywithoutpagination request, CancellationToken cancellationToken)
    {
        var Country = _countryRepository.GetAll().Result;
        var CountryDto = Country.Select(a => new CountryDetailsDto { Name = a.Name,ID=a.ID });
        return (CountryDto);
    }
}
