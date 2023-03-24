using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.country.DTOs;

using MediatR;

namespace BookingClone.Application.Features.country.queries.GitAllCountries;
public class GitAllCountriesQuery : IRequest<IEnumerable<CountryMinimalDto>>
{

    public string? Name { get; set; }
    
}
