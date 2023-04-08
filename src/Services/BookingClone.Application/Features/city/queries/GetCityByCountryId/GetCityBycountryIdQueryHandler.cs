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
public class GetCityBycountryIdQueryHandler : IRequestHandler<GetCityBYCountryIdquery, List<CityDetailsDto?>>
{
    private readonly ICityRepository _cityRepository;
    private readonly IMapper _mapper;

    public GetCityBycountryIdQueryHandler(ICityRepository cityRepository, IMapper mapper)
    {
        _cityRepository = cityRepository;
        _mapper = mapper;
    }
   



    public async Task<List<CityDetailsDto?>> Handle(GetCityBYCountryIdquery request, CancellationToken cancellationToken)
    {
        var result = _cityRepository.GetAll().Result.Where(x => x.CountryID == request.ID).ToList();
        return result is null ? null : _mapper.Map<List<CityDetailsDto>>(result);
    }

    


     
    }


