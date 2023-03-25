using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.HotelFeatures.DTOs;

using MediatR;

namespace BookingClone.Application.Features.HotelFeatures.UpdateHotel;
public class UpdateHotelCommand:IRequest<GetHotelsDto>
{
    public UpdateHotelDto Dto { get; set; }


}
