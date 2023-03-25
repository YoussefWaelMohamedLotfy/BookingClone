using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.HotelFeatures.DTOs;

using MediatR;

namespace BookingClone.Application.Features.HotelFeatures.AddHotel;
public class AddHotelCommand : IRequest<GetHotelsDto>
{
  

    public AddHotelsDto Dto { get; set; }

    //public string Name { get; set; }

    //public string Description { get; set; }

    //public decimal StarRating { get; set; }

    
}
