using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.HotelFeatures.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.HotelFeatures.UpdateHotel;
public class UpdateHotelCommandHandler : IRequestHandler<UpdateHotelCommand, GetHotelsDto>
{
    private readonly IHotelRepository _hoteRepository;
    private readonly IMapper _mapper;

    public UpdateHotelCommandHandler(IHotelRepository hoteRepository, IMapper mapper)
    {
        _hoteRepository = hoteRepository;
        _mapper = mapper;
    }

    public async Task<GetHotelsDto> Handle(UpdateHotelCommand request, CancellationToken cancellationToken)
    {

        var existingAttraction = await _hoteRepository.GetByIdAsync(request.Dto.Id, cancellationToken);

        if (existingAttraction is null)
        {
            return null;
        }

        _mapper.Map(request.Dto, existingAttraction);
        _hoteRepository.Update(existingAttraction);
        await _hoteRepository.SaveAsync(cancellationToken);

        return _mapper.Map<GetHotelsDto>(existingAttraction);

    }
}
