using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionsByCityID;
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Domain.Contracts;
using MediatR;

namespace BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionsByCityId;
internal class GetAttractionsByIdQueryHandler
{



public class GetAttractionsByCityIdQueryHandler : IRequestHandler<GetAttractionsByCityIdQuery, List<CityDetailsDto?>>
{
    private readonly ICityRepository _cityRepository;
    private readonly IMapper _mapper;

    public GetAttractionsByCityIdQueryHandler(ICityRepository cityRepository, IMapper mapper)
    {
        _cityRepository = cityRepository;
        _mapper = mapper;
    }




    public async Task<List<CityDetailsDto?>> Handle(GetAttractionsByCityIdQuery request, CancellationToken cancellationToken)
    {
        var result = _cityRepository.GetAll().Result.Where(x => x.CountryID == request.ID).ToList();
        return result is null ? null : _mapper.Map<List<CityDetailsDto>>(result);
    }





}


}
