using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;

=======
using BookingClone.Application.Features.continent.commands.UpdateContinent;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Repositories;
>>>>>>> add city and country and continent

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

<<<<<<< HEAD
<<<<<<< HEAD
        

        var con =new CountryDetailsDto {
            Name = request.Name,
           ContinentID =request.ContinentID
        };

        country.Name = request.Name;

        _countryRepository.Update(country);
        _countryRepository.SaveAsync(cancellationToken);

        return con;

       




=======
        _countryRepository.Update(country);
        return new CountryDetailsDto { Name = country.Name };
>>>>>>> add city and country and continent
=======
        

        var con =new CountryDetailsDto { Name = request.Name };
        country.Name = request.Name;

        _countryRepository.Update(country);
        _countryRepository.SaveAsync(cancellationToken);

        return con;

       




>>>>>>> api(country_continent_city)
    }
}
