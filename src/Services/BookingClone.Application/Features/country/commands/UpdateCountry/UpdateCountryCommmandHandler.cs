using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.continent.commands.UpdateContinent;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.country.commands.UpdateCountry;
public class UpdateCountryCommmandHandler : IRequestHandler<UpdateCountryCommmand, CountryDetailsDto>
{
    private readonly ICountryRepository _countryRepository;

    public UpdateCountryCommmandHandler(ICountryRepository countryRepository)
    {
        _countryRepository = countryRepository;

    }

   

    public async Task<CountryDetailsDto> Handle(UpdateCountryCommmand request, CancellationToken cancellationToken)
    {
        var country = await _countryRepository.GetByIdAsync(request.ID);

        _countryRepository.Update(country);
        return new CountryDetailsDto { Name = country.Name };
    }
}
