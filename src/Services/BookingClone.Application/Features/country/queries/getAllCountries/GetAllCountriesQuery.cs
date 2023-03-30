using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD

=======
using BookingClone.Application.Features.city.DTOs;
>>>>>>> salmateest
using BookingClone.Application.Features.country.DTOs;

using MediatR;

namespace BookingClone.Application.Features.country.queries.GitAllCountries;
public class GetAllCountriesQuery : IRequest<IEnumerable<CountryMinimalDto>>
{

    public string? Name { get; set; }
    
}
