﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

=======
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetAllCities;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
>>>>>>> add city and country and continent
using MediatR;

namespace BookingClone.Application.Features.continent.queries.GetAllcontinent;
public class GetAllcontinentQueryHandlar : IRequestHandler<GetAllcontinentQuery, IEnumerable<ContinentMinimalDto>>
{

    private readonly IContinentRepository _continentRepository;

    public GetAllcontinentQueryHandlar(IContinentRepository continentRepository)
    {
        _continentRepository = continentRepository;

    }

    public async Task<IEnumerable<ContinentMinimalDto>> Handle(GetAllcontinentQuery request, CancellationToken cancellationToken)
    {
<<<<<<< HEAD
        // return (await _continentRepository.GetAll()) /*calling */
        //.Select(a => new ContinentMinimalDto { Name = a.Name });  /*Mapping*/

        var Continent = _continentRepository.GetAll().Result;
        var ContinentDto = Continent.Select(a => new ContinentMinimalDto { Name = a.Name });
        return (ContinentDto);
=======
        return (await _continentRepository.GetAll()) /*calling */
       .Select(a => new ContinentMinimalDto { Name = a.Name });  /*Mapping*/
>>>>>>> add city and country and continent
    }
}
