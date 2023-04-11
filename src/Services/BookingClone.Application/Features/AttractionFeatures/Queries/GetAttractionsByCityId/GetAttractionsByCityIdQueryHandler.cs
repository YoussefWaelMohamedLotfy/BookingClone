using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetCityById;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionsByCityId;
internal class GetAttractionsByCityIdQueryHandler : IRequestHandler<GetAttractionsByCityIdQuery, List<AttractionDetailsDto?>>
{
    private readonly IAttractionRepository _attractionRepository;
    private readonly IMapper _mapper;

    public GetAttractionsByCityIdQueryHandler(IAttractionRepository attractionRepository, IMapper mapper)
    {
        _attractionRepository = attractionRepository;
        _mapper = mapper;
    }

    public async Task<List<AttractionDetailsDto?>> Handle(GetAttractionsByCityIdQuery request, CancellationToken cancellationToken)
    {

        var result = _attractionRepository.GetAll().Result.Where(x => x.CityID == request.ID).ToList();
        return result is null ? null : _mapper.Map<List<AttractionDetailsDto>>(result);
    }

}


