using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using AutoMapper;

<<<<<<< HEAD
=======
using AutoMapper;

>>>>>>> f37231b51413aa449c366de214aabaf312833b05

using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;

<<<<<<< HEAD
=======
=======
using AutoMapper;

>>>>>>> countryview
using Azure.Core;

using Bogus.DataSets;

using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Repositories;
>>>>>>> salmateest
=======

using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;

>>>>>>> DeleteComments
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

using MediatR;

namespace BookingClone.Application.Features.country.queries.GitCountryById;
public class GetCountryByIdQueryHandlar : IRequestHandler<GetCountryByIdQuery, CountryDetailsDto?>
{
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

    private readonly ICountryRepository _countryRepository;
    private readonly IMapper _mapper;

    public GetCountryByIdQueryHandlar(ICountryRepository countryRepository, IMapper mapper)
    {
        _countryRepository = countryRepository;
        _mapper = mapper;
    }

    public async Task<CountryDetailsDto?> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _countryRepository.GetByIdAsync(request.ID, cancellationToken);
        return result is null ? null : _mapper.Map<CountryDetailsDto>(result);
    }

  

        //private readonly ICountryRepository _countryRepository;

        //public GetCountryByIdQueryHandlar(ICountryRepository countryRepository)
        //{
        //    _countryRepository = countryRepository;

        //}



        //public async Task<CountryDetailsDto?> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
        //{

        //    var country = await _countryRepository.GetByIdAsync(request.ID);

        //    return new CountryDetailsDto()
        //    {
        //        Name = country.Name,

        //    };

        //}
    
<<<<<<< HEAD
=======
=======

>>>>>>> countryview
    private readonly ICountryRepository _countryRepository;
    private readonly IMapper _mapper;

    public GetCountryByIdQueryHandlar(ICountryRepository countryRepository, IMapper mapper)
    {
        _countryRepository = countryRepository;
        _mapper = mapper;
    }

    public async Task<CountryDetailsDto?> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
    {
        var result = await _countryRepository.GetByIdAsync(request.ID, cancellationToken);
        return result is null ? null : _mapper.Map<CountryDetailsDto>(result);
    }

  

        //private readonly ICountryRepository _countryRepository;

        //public GetCountryByIdQueryHandlar(ICountryRepository countryRepository)
        //{
        //    _countryRepository = countryRepository;

        //}



        //public async Task<CountryDetailsDto?> Handle(GetCountryByIdQuery request, CancellationToken cancellationToken)
        //{

        //    var country = await _countryRepository.GetByIdAsync(request.ID);

<<<<<<< HEAD
    }
>>>>>>> salmateest
=======
        //    return new CountryDetailsDto()
        //    {
        //        Name = country.Name,

        //    };

        //}
    
>>>>>>> countryview
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
}
