﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

=======
using BookingClone.Application.Features.city.DTOs;
>>>>>>> salmateest
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Common;
using MediatR;

namespace BookingClone.Application.Features.continent.queries.GetAllcontinent;
public class getallcontinentquery2 : IRequest<PagedList<ContinentDetailsDto>>
{
    public required PaginationQuery Query { get; set; }
   
}