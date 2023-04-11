using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetAllCities;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.AttractionFeatures.Queries.GetAllAttractions;
internal class GetAllAttractionQueryHandlar : IRequestHandler<GetAllAttractionQuery, IEnumerable<AttractionDetailsDto>>
{
    private readonly IAttractionRepository _attractionRepository;
    private readonly IMapper _mapper;

    public GetAllAttractionQueryHandlar(IAttractionRepository attractionRepository, IMapper mapper)
    {
        _attractionRepository = attractionRepository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<AttractionDetailsDto>> Handle(GetAllAttractionQuery request, CancellationToken cancellationToken)
    {
        var Attraction = _attractionRepository.GetAll().Result;
        var Attraction_Dto = Attraction.Select(a => new AttractionDetailsDto
        {
            ID=a.ID,
            CityID=a.CityID,
            Description=a.Description,
            Name=a.Name,
            AvailableTickets=a.AvailableTickets,
            TicketPrice=a.TicketPrice,
            Duration=a.Duration,

        });
        return (Attraction_Dto);
    }
  
}
