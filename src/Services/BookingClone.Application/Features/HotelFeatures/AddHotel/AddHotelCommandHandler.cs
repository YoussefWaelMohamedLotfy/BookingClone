using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.HotelFeatures.AddHotel;
using BookingClone.Application.Features.HotelFeatures.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.Commands.AddHotel;
public class AddHotelCommandHandler : IRequestHandler<AddHotelCommand, GetHotelsDto>
{
    private readonly IHotelRepository _hotelRepository;
    private readonly IMapper _mapper;

    public AddHotelCommandHandler(IHotelRepository hotelRepository, IMapper mapper)
    {
        _hotelRepository = hotelRepository;
        _mapper = mapper;
    }

    public async Task<GetHotelsDto> Handle(AddHotelCommand request, CancellationToken cancellationToken)
    {
        var newHotel = _mapper.Map<Hotel>(request.Dto);

        _hotelRepository.Add(newHotel);
        await _hotelRepository.SaveAsync(cancellationToken);

        return _mapper.Map<GetHotelsDto>(newHotel);



    }
}
