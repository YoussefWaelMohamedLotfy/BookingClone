using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingClone.Application.Features.HotelFeatures.DTOs;
public class UpdateHotelDto:GetHotelsDto
{
    public int Id { get; set; }
}
