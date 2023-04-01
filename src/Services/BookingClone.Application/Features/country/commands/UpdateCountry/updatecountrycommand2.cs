using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD

=======
using BookingClone.Application.Features.continent.DTOs;
>>>>>>> salmateest
=======

>>>>>>> country,continent,city
using BookingClone.Application.Features.country.DTOs;

using MediatR;

namespace BookingClone.Application.Features.country.commands.UpdateCountry;
public class updatecountrycommand2 : IRequest<CountryDetailsDto?>
{

    public required CountryDetailsDto Dto { get; set; }
    

}
