using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionsByCityId;
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetCityById;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionsByCityId;



<<<<<<< HEAD

    public class GetAttractionsByCityIdQueryHandler : IRequestHandler<GetAttractionsByCityIdQuery, List<AttractionsDetailsDto?>>
    {
      
    private IAttractionRepository _AttractionRepository;
    private readonly IMapper _mapper;

        public GetAttractionsByCityIdQueryHandler(IAttractionRepository AttractionRepository, IMapper mapper)
        {
        _AttractionRepository = AttractionRepository;
            _mapper = mapper;
        }





    public List<AttractionsDetailsDto?> Handle(GetAttractionsByCityIdQuery request, CancellationToken cancellationToken)
    {
        var result = _AttractionRepository.GetAll().Result.Where(x => x.CityID == request.ID).ToList();
        return result is null ? null : _mapper.Map<List<AttractionsDetailsDto>>(result);
=======
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
>>>>>>> 882ae8b988069fa05aba303cab58c983978bfa51
    }





}


