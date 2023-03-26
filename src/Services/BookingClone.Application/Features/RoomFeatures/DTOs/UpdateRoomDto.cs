using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingClone.Application.Features.RoomFeatures.DTOs;
public class UpdateRoomDto:AddRoomDto
{
    public int ID { get; set; }
}
