using AutoMapper;
using BookingClone.Application.Features.HotelFeatures.DTOs;
using BookingClone.Domain.Contracts;
using MediatR;

namespace BookingClone.Application.Features.HotelFeatures.Queries.GetById;

public sealed class GetByIdQueryHandler : IRequestHandler<GetByIdQuery, GetHotelsDto>
{
    private readonly IHotelRepository _hotelRepository;
    private readonly IMapper _mapper;

    public GetByIdQueryHandler(IHotelRepository hotelRepository, IMapper mapper)
    {
        _hotelRepository = hotelRepository;
        _mapper = mapper;
    }

    public async Task<GetHotelsDto> Handle(GetByIdQuery request, CancellationToken cancellationToken)
    {
        //var result = await _hotelRepository.GetByIdAsync(request.ID, cancellationToken);
        //return result is null ? null : _mapper.Map<GetHotelsDto>(result);
        var hotel = await _hotelRepository.GetByIdAsync(request.ID);
        if (hotel != null)
        {
            return new GetHotelsDto { Name = hotel.Name, Description = hotel.Description, Reviews = hotel.Reviews };
        }
        else
        {
            throw new Exception("Not Found A Hotel");
        }
    }
}
