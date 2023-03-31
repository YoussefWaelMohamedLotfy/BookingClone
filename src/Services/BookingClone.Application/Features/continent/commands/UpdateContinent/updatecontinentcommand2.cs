using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD

=======
using BookingClone.Application.Features.city.DTOs;
>>>>>>> salmateest
=======

>>>>>>> select
using BookingClone.Application.Features.continent.DTOs;

using MediatR;

namespace BookingClone.Application.Features.continent.commands.UpdateContinent;
public class updatecontinentcommand2 : IRequest<ContinentDetailsDto?>
{
    public required ContinentDetailsDto Dto { get; set; }
   
}
