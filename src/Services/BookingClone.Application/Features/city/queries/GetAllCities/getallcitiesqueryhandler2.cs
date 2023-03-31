﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.city.DTOs;
<<<<<<< HEAD
using BookingClone.Domain.Common;
using BookingClone.Domain.Contracts;
=======
using BookingClone.Application.Features.RoomReservationFeatures.DTOs;
using BookingClone.Application.Features.RoomReservationFeatures.Queries.GetAllRoomReservations;
using BookingClone.Domain.Common;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;
>>>>>>> city handler

using MediatR;

namespace BookingClone.Application.Features.city.queries.GetAllCities;
public class getallcitiesqueryhandler2 : IRequestHandler<getallcitiesquery2, PagedList<CityDetailsDto>>
{
    private readonly ICityRepository _cityRepository;
    private readonly IMapper _mapper;


    public getallcitiesqueryhandler2(ICityRepository repository, IMapper mapper)
    {
        _cityRepository = repository;
        _mapper = mapper;
    }

  
    public async Task<PagedList<CityDetailsDto>> Handle(getallcitiesquery2 request, CancellationToken cancellationToken)
    {
        var reservations = await _cityRepository.GetPaginatedList(request.Query, cancellationToken);
<<<<<<< HEAD
<<<<<<< HEAD
       return _mapper.Map<PagedList<CityDetailsDto>>(reservations);
=======
        return _mapper.Map<PagedList<CityDetailsDto>>(reservations);
>>>>>>> city handler
=======
       return _mapper.Map<PagedList<CityDetailsDto>>(reservations);
>>>>>>> test 4
    }
}
