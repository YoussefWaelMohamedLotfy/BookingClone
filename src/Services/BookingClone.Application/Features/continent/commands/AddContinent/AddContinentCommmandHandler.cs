using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Repositories;

=======
using BookingClone.Application.Features.city.commands.AddCity;
using BookingClone.Application.Features.city.DTOs;
=======
>>>>>>> country,continent,city
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
<<<<<<< HEAD
>>>>>>> add city and country and continent
=======
using BookingClone.Infrastructure.Repositories;

>>>>>>> api(country_continent_city)
using MediatR;

namespace BookingClone.Application.Features.continent.commands.AddContinent;
public class AddContinentCommmandHandler : IRequestHandler<AddContinentCommmand, ContinentDetailsDto>
{
    private readonly IContinentRepository _continentRepository;

    public AddContinentCommmandHandler(IContinentRepository continentRepository)
    {
        _continentRepository = continentRepository;

    }

    public async Task<ContinentDetailsDto> Handle(AddContinentCommmand request, CancellationToken cancellationToken)
    {
        var continent = new Continent()
        {
            Name = request.Name,
<<<<<<< HEAD
<<<<<<< HEAD
            
=======
            Countries = request.Countries,
>>>>>>> add city and country and continent
=======
            
>>>>>>> api(country_continent_city)
           
        };



        continent = _continentRepository.Add(continent);
<<<<<<< HEAD
<<<<<<< HEAD
        _continentRepository.SaveAsync(cancellationToken);
        return new ContinentDetailsDto()
        {   Name = continent.Name,
           
        };


       

    }

=======
=======
        _continentRepository.SaveAsync(cancellationToken);
>>>>>>> api(country_continent_city)
        return new ContinentDetailsDto()
        {   Name = continent.Name,
           
        };


       

    }
<<<<<<< HEAD
    
>>>>>>> add city and country and continent
=======

>>>>>>> api(country_continent_city)

}
