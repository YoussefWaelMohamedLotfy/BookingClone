using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.HotelFeatures.DTOs;

using BookingClone.Domain.Common;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.HotelFeatures.Queries.GetAll;
public class GetAllQueryHandler : IRequestHandler<GetAllQuery, PagedList<GetHotelsDto>>
{

    private readonly IHotelRepository _hotelRepository;
    private readonly IMapper _mapper;

    public GetAllQueryHandler(IHotelRepository hotelRepository, IMapper mapper)
    {
        _hotelRepository = hotelRepository;
        _mapper = mapper;
    }

    public async Task<PagedList<GetHotelsDto>> Handle(GetAllQuery request, CancellationToken cancellationToken)
    {
        var hotel = await _hotelRepository.GetPaginatedList(request.Query, cancellationToken);
        return _mapper.Map<PagedList<GetHotelsDto>>(hotel);
    }
}
