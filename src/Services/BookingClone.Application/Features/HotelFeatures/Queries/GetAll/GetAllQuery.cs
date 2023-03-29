using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.HotelFeatures.DTOs;

using BookingClone.Domain.Common;

using MediatR;

namespace BookingClone.Application.Features.HotelFeatures.Queries.GetAll;
public class GetAllQuery: IRequest<PagedList<GetHotelsDto>>
{
    public required PaginationQuery Query { get; set; }

}
