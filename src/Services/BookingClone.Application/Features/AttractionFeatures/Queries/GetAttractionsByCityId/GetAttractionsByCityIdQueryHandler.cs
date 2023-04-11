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



public class GetAttractionsByCityIdQueryHandler : IRequestHandler<GetAttractionsByCityIdQuery, List<AttractionsDetailsDto?>>
{
    private readonly IAttractionRepository _AttractionRepository;
    private readonly IMapper _mapper;

    public GetAttractionsByCityIdQueryHandler(IAttractionRepository AttractionRepository, IMapper mapper)
    {
        _cityRepository = cityRepository;
        _mapper = mapper;
    }




    public async Task<List<AttractionsDetailsDto?>> Handle(GetAttractionsByCityIdQuery request, CancellationToken cancellationToken)
    {
        var result = _AttractionRepository.GetAll().Result.Where(x => x.CountryID == request.ID).ToList();
        return result is null ? null : _mapper.Map<List<AttractionsyDetailsDto>>(result);
    }





}


}
