using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

using AutoMapper;

using Azure.Core;

using BookingClone.Application.Features.RoomFeatures.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.RoomFeatures.Queries.GetRoomById;
public class GetRoomByIdQueryHandler : IRequestHandler<GetRoomByIdQuery, GetRoomDto>
{
    private readonly IRoomRepository _roomRepository;
    private readonly IMapper _mapper;

    public GetRoomByIdQueryHandler(IRoomRepository roomRepository, IMapper mapper)
    {
        _roomRepository = roomRepository;
        _mapper = mapper;
    }



    public async Task<GetRoomDto> Handle(GetRoomByIdQuery request, CancellationToken cancellationToken)
    {
        var room = await _roomRepository.GetByIdAsync(request.ID);
        if (room != null)
        {
            return new GetRoomDto { RoomNumber = room.RoomNumber , Description = room.Description, BedCount = room.BedCount ,
                ViewType=room.ViewType , IsAvailable=room.IsAvailable, Price = room.Price , Hotel = room.Hotel
            };


        }
        else
        {
            throw new Exception("Not Found A Hotel");
        }

    }


    //var result = await _roomRepository.GetRoomDetails(request.ID, cancellationToken);
    //    return result is null ? null : _mapper.Map<GetRoomDto>(result);

}
