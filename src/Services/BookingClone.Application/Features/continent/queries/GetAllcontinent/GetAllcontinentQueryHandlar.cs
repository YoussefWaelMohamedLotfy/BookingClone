using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD

using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

=======
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetAllCities;
=======

>>>>>>> DeleteComments
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
<<<<<<< HEAD
>>>>>>> add city and country and continent
=======
using BookingClone.Infrastructure.Repositories;

>>>>>>> api(country_continent_city)
using MediatR;

namespace BookingClone.Application.Features.continent.queries.GetAllcontinent;
public class GetAllcontinentQueryHandlar : IRequestHandler<GetAllcontinentQuery, IEnumerable<ContinentMinimalDto>>
{

    private readonly IContinentRepository _continentRepository;

    public GetAllcontinentQueryHandlar(IContinentRepository continentRepository)
    {
        _continentRepository = continentRepository;

    }

    public async Task<IEnumerable<ContinentMinimalDto>> Handle(GetAllcontinentQuery request, CancellationToken cancellationToken)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        // return (await _continentRepository.GetAll()) /*calling */
        //.Select(a => new ContinentMinimalDto { Name = a.Name });  /*Mapping*/

        var Continent = _continentRepository.GetAll().Result;
        var ContinentDto = Continent.Select(a => new ContinentMinimalDto { Name = a.Name });
        return (ContinentDto);
=======
        return (await _continentRepository.GetAll()) /*calling */
       .Select(a => new ContinentMinimalDto { Name = a.Name });  /*Mapping*/
>>>>>>> add city and country and continent
=======
        // return (await _continentRepository.GetAll()) /*calling */
        //.Select(a => new ContinentMinimalDto { Name = a.Name });  /*Mapping*/

<<<<<<< HEAD
        var x = _continentRepository.GetAll().Result;
        var y = x.Select(a => new ContinentMinimalDto { Name = a.Name });
        return (y);
>>>>>>> api(country_continent_city)
=======
        var Continent = _continentRepository.GetAll().Result;
        var ContinentDto = Continent.Select(a => new ContinentMinimalDto { Name = a.Name });
        return (ContinentDto);
>>>>>>> finalcommit
    }
}
