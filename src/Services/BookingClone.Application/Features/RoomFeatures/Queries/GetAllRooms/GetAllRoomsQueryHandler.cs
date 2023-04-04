using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;

using BookingClone.Application.Features.RoomFeatures.DTOs;

using BookingClone.Domain.Common;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.RoomFeatures.Queries.GetAllRooms;
public class GetAllRoomsQueryHandler : IRequestHandler<GetAllRoomsQuery, PagedList<GetRoomDto>>
{
    private readonly IRoomRepository _roomRepository;
    private readonly IMapper _mapper;

    public GetAllRoomsQueryHandler(IRoomRepository roomRepository, IMapper mapper)
    {
        _roomRepository = roomRepository;
        _mapper = mapper;
    }

    public async Task<PagedList<GetRoomDto>> Handle(GetAllRoomsQuery request, CancellationToken cancellationToken)
    {
        var room = await _roomRepository.GetPaginatedList(request.Query, cancellationToken);
        return _mapper.Map<PagedList<GetRoomDto>>(room);
    }
}
