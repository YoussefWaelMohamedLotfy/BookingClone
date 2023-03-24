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
<<<<<<< HEAD

using BookingClone.Domain.Contracts;


=======
using BookingClone.Domain.Contracts;
>>>>>>> add city and country and continent
using MediatR;

namespace BookingClone.Application.Features.city.queries.GetCityById;
public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, CityDetailsDto?>
{
    private readonly ICityRepository _cityRepository;
<<<<<<< HEAD
    private readonly IMapper _mapper;

    public GetCityByIdQueryHandler(ICityRepository cityRepository, IMapper mapper)
    {
        _cityRepository = cityRepository;
        _mapper = mapper;
    }
   



    public async Task<CityDetailsDto?> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _cityRepository.GetByIdAsync(request.ID, cancellationToken);
        return result is null ? null : _mapper.Map<CityDetailsDto>(result);
    }

    


     
    }

=======
   

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
>>>>>>> add city and country and continent

