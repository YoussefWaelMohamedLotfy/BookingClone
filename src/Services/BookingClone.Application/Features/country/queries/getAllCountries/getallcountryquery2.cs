﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
using BookingClone.Application.Features.continent.DTOs;
>>>>>>> salmateest
=======
>>>>>>> country,continent,city
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Common;
using MediatR;

namespace BookingClone.Application.Features.country.queries.GitAllCountries;
public class getallcountryquery2 : IRequest<PagedList<CountryDetailsDto>>
{
    public required PaginationQuery Query { get; set; }

    
}
