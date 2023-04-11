﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
using BookingClone.Application.Features.city.commands.UpdateCity;
using BookingClone.Application.Features.city.DTOs;
>>>>>>> continentview
=======
>>>>>>> country,continent,city
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.country.commands.UpdateCountry;
internal class updatecountrycommandhandler2 : IRequestHandler<updatecountrycommand2, CountryDetailsDto?>
{
    private readonly ICountryRepository _countryRepository;
    private readonly IMapper _mapper;

    public updatecountrycommandhandler2(ICountryRepository countryRepository, IMapper mapper)
    {
        _countryRepository = countryRepository;
        _mapper = mapper;
    }

    public async Task<CountryDetailsDto?> Handle(updatecountrycommand2 request, CancellationToken cancellationToken)
    {
        var reservation = await _countryRepository.GetByIdAsync(request.Dto.ID.Value, cancellationToken);

        if (reservation is null)
        {
            return null!;
        }

        _mapper.Map(request.Dto, reservation);
        _countryRepository.Update(reservation);
        await _countryRepository.SaveAsync(cancellationToken);

        return _mapper.Map<CountryDetailsDto>(reservation);
    }


    
}
