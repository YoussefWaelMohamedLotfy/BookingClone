﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.commands.UpdateCity;
using BookingClone.Application.Features.city.DTOs;
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
       
          _continentRepository.Update(Continent);

        return new ContinentDetailsDto { Name = Continent.Name };
    }
}
