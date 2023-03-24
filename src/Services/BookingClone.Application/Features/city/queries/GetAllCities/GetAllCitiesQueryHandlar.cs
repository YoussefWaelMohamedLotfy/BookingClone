﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Domain.Contracts;

using MediatR;

namespace BookingClone.Application.Features.city.queries.GetAllCities;
public class GetAllCitiesQueryHandlar : IRequestHandler<GetAllCitiesQuery, IEnumerable<CityMinimalDto>>
{

        private readonly ICityRepository _cityRepository;

        public GetAllCitiesQueryHandlar(ICityRepository cityRepository)
        {
           _cityRepository = cityRepository;

        }

    public async Task<IEnumerable<CityMinimalDto>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
    {
        return (await _cityRepository.GetAll()) /*calling */
         .Select(a => new CityMinimalDto { Name =a.Name} );  /*Mapping*/
    }



   
}
