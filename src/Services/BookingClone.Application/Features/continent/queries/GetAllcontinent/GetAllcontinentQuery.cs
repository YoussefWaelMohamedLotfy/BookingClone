using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD

=======
using BookingClone.Application.Features.city.DTOs;
>>>>>>> add city and country and continent
=======

>>>>>>> DeleteComments
using BookingClone.Application.Features.continent.DTOs;

using MediatR;

namespace BookingClone.Application.Features.continent.queries.GetAllcontinent;
public class GetAllcontinentQuery : IRequest<IEnumerable<ContinentMinimalDto>>
{
    public string? Name { get; set; }


   
}
