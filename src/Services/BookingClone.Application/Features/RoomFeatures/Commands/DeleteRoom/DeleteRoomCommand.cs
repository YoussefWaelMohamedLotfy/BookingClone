using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

namespace BookingClone.Application.Features.RoomFeatures.Commands.DeleteRoom;
public class DeleteRoomCommand:IRequest<int>
{
    public required int ID { get; init; }
}
