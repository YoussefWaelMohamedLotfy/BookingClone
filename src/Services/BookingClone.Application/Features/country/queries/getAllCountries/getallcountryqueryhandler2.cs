using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetAllCities;
>>>>>>> countryview
=======
>>>>>>> country,continent,city
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Application.Features.country.queries.GitAllCountries;
using BookingClone.Domain.Common;
using BookingClone.Domain.Contracts;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
using BookingClone.Infrastructure.Repositories;
>>>>>>> countryview
=======
>>>>>>> country,continent,city
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

using MediatR;

namespace BookingClone.Application.Features.country.queries.getAllCountries;
public class getallcountryqueryhandler2 : IRequestHandler<getallcountryquery2, PagedList<CountryDetailsDto>>
{
    private readonly ICountryRepository _countryRepository;
    private readonly IMapper _mapper;


    public getallcountryqueryhandler2(ICountryRepository repository, IMapper mapper)
    {
        _countryRepository = repository;
        _mapper = mapper;
    }

    public async Task<PagedList<CountryDetailsDto>> Handle(getallcountryquery2 request, CancellationToken cancellationToken)
    {
        var reservations = await _countryRepository.GetPaginatedList(request.Query, cancellationToken);
        return _mapper.Map<PagedList<CountryDetailsDto>>(reservations);
    }
}
