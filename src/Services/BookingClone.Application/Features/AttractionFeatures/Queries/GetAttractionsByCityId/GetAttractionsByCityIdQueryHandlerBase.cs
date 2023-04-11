using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionsByCityId;
using BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionsByCityId;
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetCityById;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionsByCityId;

public class GetAttractionsByCityIdQueryHandlerBase
{





    public List<AttractionsDetailsDto?> Handle(GetAttractionsByCityIdQuery request, CancellationToken cancellationToken)
    {
        var result = _AttractionRepository.GetAll().Result.Where(x => x.CityID == request.ID).ToList();
        return result is null ? null : _mapper.Map<List<AttractionsDetailsDto>>(result);
    }
}