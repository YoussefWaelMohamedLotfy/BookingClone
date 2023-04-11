using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
using BookingClone.Application.Features.city.DTOs;
>>>>>>> add city and country and continent
=======

>>>>>>> DeleteComments
=======

>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Application.Features.continent.DTOs;

using MediatR;

namespace BookingClone.Application.Features.continent.queries.GetAllcontinent;
public class GetAllcontinentQuery : IRequest<IEnumerable<ContinentMinimalDto>>
{
    public string? Name { get; set; }
    public int? ID { get; set; }


}
