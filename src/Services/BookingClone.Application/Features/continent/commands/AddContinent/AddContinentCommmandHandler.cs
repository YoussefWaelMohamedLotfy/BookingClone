using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Repositories;

=======
using BookingClone.Application.Features.city.commands.AddCity;
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
>>>>>>> add city and country and continent
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
            
=======
            Countries = request.Countries,
>>>>>>> add city and country and continent
           
        };



        continent = _continentRepository.Add(continent);
<<<<<<< HEAD
        _continentRepository.SaveAsync(cancellationToken);
        return new ContinentDetailsDto()
        {   Name = continent.Name,
           
        };


       

    }

=======
        return new ContinentDetailsDto()
        {   Name = continent.Name,
            Countries = continent.Countries,
        };
    }
    
>>>>>>> add city and country and continent

}
