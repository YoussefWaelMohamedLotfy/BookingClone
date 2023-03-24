using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
<<<<<<< HEAD
using BookingClone.Domain.Common;

=======
>>>>>>> add city and country and continent
using MediatR;

namespace BookingClone.Application.Features.city.queries.GetAllCities;
public class GetAllCitiesQuery : IRequest<IEnumerable<CityMinimalDto>>
{
    public string? Name { get; set; }
<<<<<<< HEAD
   
=======
>>>>>>> add city and country and continent
}


