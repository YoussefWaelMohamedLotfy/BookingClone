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
<<<<<<< HEAD

using BookingClone.Domain.Contracts;


=======
using BookingClone.Domain.Contracts;
>>>>>>> add city and country and continent
=======
using BookingClone.Application.Features.RoomFeatures.DTOs;
using BookingClone.Application.Features.RoomFeatures.Queries.GetRoomById;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

>>>>>>> test2
using MediatR;

namespace BookingClone.Application.Features.city.queries.GetCityById;
public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, CityDetailsDto?>
{
    private readonly ICityRepository _cityRepository;
<<<<<<< HEAD
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
   
=======
    private readonly IMapper _mapper;
>>>>>>> test2

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

    


        //private readonly ICityRepository _cityRepository;


        //public GetCityByIdQueryHandler(ICityRepository cityRepository)
        //{
        //    _cityRepository = cityRepository;
        //}

        //public async Task<CityDetailsDto?> Handle(GetCityByIdQuery request, CancellationToken cancellationToken)
        //{
        //    var city = await _cityRepository.GetByIdAsync(request.ID); 

        //    return new CityDetailsDto()    
        //    {
        //        Name = city.Name,

        //    }; 




        //}
    }
<<<<<<< HEAD
}
>>>>>>> add city and country and continent
=======

>>>>>>> test2

