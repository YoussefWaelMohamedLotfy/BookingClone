using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.RoomFeatures.DTOs;

using MediatR;

namespace BookingClone.Application.Features.RoomFeatures.Queries.GetRoomById;
public class GetRoomByIdQuery:IRequest<GetRoomDto>
{
    public  int ID { get; set; }
}
