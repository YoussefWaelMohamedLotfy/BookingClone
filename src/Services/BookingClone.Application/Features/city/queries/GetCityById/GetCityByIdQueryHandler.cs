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
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

using BookingClone.Domain.Contracts;


<<<<<<< HEAD
=======
using BookingClone.Domain.Contracts;
>>>>>>> add city and country and continent
=======
using BookingClone.Application.Features.RoomFeatures.DTOs;
using BookingClone.Application.Features.RoomFeatures.Queries.GetRoomById;
=======

>>>>>>> DeleteComments
using BookingClone.Domain.Contracts;


>>>>>>> test2
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using MediatR;

namespace BookingClone.Application.Features.city.queries.GetCityById;
public class GetCityByIdQueryHandler : IRequestHandler<GetCityByIdQuery, CityDetailsDto?>
{
    private readonly ICityRepository _cityRepository;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
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

<<<<<<< HEAD
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

    


     
    }
<<<<<<< HEAD
}
>>>>>>> add city and country and continent
=======

>>>>>>> test2
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

