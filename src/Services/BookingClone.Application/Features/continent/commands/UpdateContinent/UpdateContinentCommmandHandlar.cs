﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

=======
using BookingClone.Application.Features.city.commands.UpdateCity;
using BookingClone.Application.Features.city.DTOs;
>>>>>>> add city and country and continent
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.continent.commands.UpdateContinent;
public class UpdateContinentCommmandHandlar : IRequestHandler<UpdateContinentCommmand, ContinentDetailsDto>
{
    private readonly IContinentRepository _continentRepository;

    public UpdateContinentCommmandHandlar(IContinentRepository continentRepository)
    {
        _continentRepository = continentRepository;

    }
   
    public async Task<ContinentDetailsDto> Handle(UpdateContinentCommmand request, CancellationToken cancellationToken)
    {
        var Continent = await _continentRepository.GetByIdAsync(request.ID);
       
<<<<<<< HEAD
         

        var cont = new ContinentDetailsDto { Name = request.Name };
        Continent.Name = request.Name;

        _continentRepository.Update(Continent);

        _continentRepository.SaveAsync(cancellationToken);
        return cont;

       
        
        

    }
}

=======
          _continentRepository.Update(Continent);

        return new ContinentDetailsDto { Name = Continent.Name };
    }
}
>>>>>>> add city and country and continent
