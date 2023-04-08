using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;


using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Contracts;


using MediatR;

namespace BookingClone.Application.Features.country.queries.GitCountryById;
public class GetCountryByContientIdQueryHandlar : IRequestHandler<GetCountryByContientIdQuery, List<CountryDetailsDto?>>
{

    private readonly ICountryRepository _countryRepository;
    private readonly IMapper _mapper;

    public GetCountryByContientIdQueryHandlar(ICountryRepository countryRepository, IMapper mapper)
    {
        _countryRepository = countryRepository;
        _mapper = mapper;
    }

    public async Task<List<CountryDetailsDto>> Handle(GetCountryByContientIdQuery request, CancellationToken cancellationToken)
    {
        var result =  _countryRepository.GetAll().Result.Where(x=>x.ContinentID==request.ID).ToList();
        return result is null ? null : _mapper.Map<List<CountryDetailsDto>>(result);
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

}
