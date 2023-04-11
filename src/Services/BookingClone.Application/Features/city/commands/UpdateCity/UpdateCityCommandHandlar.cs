using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;

using MediatR;

namespace BookingClone.Application.Features.city.commands.UpdateCity;
public class UpdateCityCommandHandlar : IRequestHandler<UpdateCityCommand, CityDetailsDto>
{

    private readonly ICityRepository _cityRepository;


    public UpdateCityCommandHandlar(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public async Task<CityDetailsDto> Handle(UpdateCityCommand request, CancellationToken cancellationToken)
    {
        var city = await _cityRepository.GetByIdAsync(request.ID);
        var cityy = new CityDetailsDto
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
           Name = request.Name,
           CountryID=request.CountryID
<<<<<<< HEAD
=======
           Name = request.Name,
           CountryID=request.CountryID
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

        };
        city.Name = request.Name;
       
       
          _cityRepository.Update(city);
        _cityRepository.SaveAsync(cancellationToken);
<<<<<<< HEAD
=======
           Name = city.Name,
=======
           Name = request.Name,
>>>>>>> api(country_continent_city)
           
=======
>>>>>>> select

        };
        city.Name = request.Name;
       
       
          _cityRepository.Update(city);
<<<<<<< HEAD
>>>>>>> add city and country and continent
=======
        _cityRepository.SaveAsync(cancellationToken);
>>>>>>> api(country_continent_city)
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

        return cityy;
    }

    
}
