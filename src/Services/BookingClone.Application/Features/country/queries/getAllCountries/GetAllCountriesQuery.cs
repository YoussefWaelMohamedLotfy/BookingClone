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

>>>>>>> country,continent,city
using BookingClone.Application.Features.country.DTOs;

using MediatR;

namespace BookingClone.Application.Features.country.queries.GitAllCountries;
public class GetAllCountriesQuery : IRequest<IEnumerable<CountryMinimalDto>>
{

    public string? Name { get; set; }
    
}
