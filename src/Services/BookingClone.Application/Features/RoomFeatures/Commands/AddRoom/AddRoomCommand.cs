using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.RoomFeatures.DTOs;

using MediatR;

namespace BookingClone.Application.Features.RoomFeatures.Commands.AddRoom;
public class AddRoomCommand:IRequest<GetRoomDto>
{
    public required AddRoomDto Dto { get; set; }
}
