using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

=======
using BookingClone.Application.Features.continent.DTOs;
>>>>>>> add city and country and continent
using BookingClone.Application.Features.country.DTOs;

using MediatR;

namespace BookingClone.Application.Features.country.commands.UpdateCountry;
public class UpdateCountryCommmand : IRequest<CountryDetailsDto>
{
    
        public int ID { get; set; }
        public string? Name { get; set; }
<<<<<<< HEAD
        public int? ContinentID { get; set; }

=======
>>>>>>> add city and country and continent




<<<<<<< HEAD
=======
    
>>>>>>> add city and country and continent

}
