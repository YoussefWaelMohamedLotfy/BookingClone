﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.city.DTOs;
<<<<<<< HEAD
<<<<<<< HEAD
=======
using BookingClone.Application.Features.RoomFeatures.Commands.AddRoom;
using BookingClone.Application.Features.RoomFeatures.DTOs;
>>>>>>> test2
=======
>>>>>>> country,continent,city
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.city.commands.AddCity;
public class addcitycommandhandler2 : IRequestHandler<addcitycommand2, CityDetailsDto>
{
    private readonly ICityRepository _cityRepository;
    private readonly IMapper _mapper;

    public addcitycommandhandler2(ICityRepository cityRepository, IMapper mapper)
    {
        _cityRepository = cityRepository;
        _mapper = mapper;
    }

    public async Task<CityDetailsDto> Handle(addcitycommand2 request, CancellationToken cancellationToken)
    {
<<<<<<< HEAD
        var newCity = _mapper.Map<City>(request.Dto);
=======
        var newCity = _mapper.Map<Cities>(request.Dto);
>>>>>>> test2
        _cityRepository.Add(newCity);
        await _cityRepository.SaveAsync(cancellationToken);

        return _mapper.Map<CityDetailsDto>(newCity);
    }

}
