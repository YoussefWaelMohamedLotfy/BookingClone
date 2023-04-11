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
>>>>>>> select
=======

>>>>>>> country,continent,city
=======

>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Application.Features.country.DTOs;

using MediatR;

namespace BookingClone.Application.Features.country.queries.GitAllCountries;
public class GetAllCountriesQuerywithoutpagination : IRequest<IEnumerable<CountryDetailsDto>>
{

    public string? Name { get; set; }
    public int? ID { get; set; }

}
