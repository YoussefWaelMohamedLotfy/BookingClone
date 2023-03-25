using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using MediatR;

namespace BookingClone.Application.Features.HotelFeatures.DeleteHotel;
public class DeleteHotelCommand:IRequest<int>
{
    public int Id { get; set; }
}
