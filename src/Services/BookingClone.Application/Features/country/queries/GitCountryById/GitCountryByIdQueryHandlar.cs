using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Azure.Core;

using Bogus.DataSets;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetCityById;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.country.queries.GitCountryById;
public class GitCountryByIdQueryHandlar : IRequestHandler<GitCountryByIdQuery, CountryDetailsDto?>
{
    private readonly ICountryRepository _countryRepository;

    public GitCountryByIdQueryHandlar(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;

    }



    public async Task<CountryDetailsDto?> Handle(GitCountryByIdQuery request, CancellationToken cancellationToken)
    {
        //    var country = await _countryRepository.GetByIdAsync(request.ID); /*calling*/

        //   return new CountryDetailsDto(){
        //      Name= country.Name,

        //   };  

        var country = await _countryRepository.GetByIdAsync(request.ID);

        return new CountryDetailsDto()
        {
            Name = country.Name,

        };

    }
}
