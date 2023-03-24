using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using Bogus.DataSets;

using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionById;
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Domain.Contracts;
using MediatR;

namespace BookingClone.Application.Features.city.queries.GetCityById;
public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, CityDetailsDto?>
{
    private readonly ICityRepository _cityRepository;
   

    public GetCityByIdQueryHandler(ICityRepository cityRepository)
    {
        _cityRepository = cityRepository;
    }

    public async Task<CityDetailsDto?> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
    {
        var city = await _cityRepository.GetByIdAsync(request.ID); /*calling*/

        return new CityDetailsDto()
        {
            Name = city.Name,
            Country = city.Country,
            Attractions = city.Attractions,
            CityHotels = city.CityHotels
        };  /*mapping*/



        //return new CityDetailsDto(city.Name, city.Country);
    }
}

