using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.HotelFeatures.DTOs;

using MediatR;

namespace BookingClone.Application.Features.HotelFeatures.Queries.GetById;
public class GetByIdQuery:IRequest<GetHotelsDto>
{
    public int ID { get; set; }

}
