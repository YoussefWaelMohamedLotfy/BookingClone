using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.AttractionReservationFeatures.DTOs;
using BookingClone.Application.Features.RoomFeatures.DTOs;

using MediatR;

namespace BookingClone.Application.Features.RoomFeatures.Commands.UpdateRoom;
public class UpdateRoomCommand:IRequest<GetRoomDto>
{
    public required UpdateRoomDto Dto { get; set; }
}
