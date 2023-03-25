using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetCityById;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.continent.queries.GetContinentById;
public class GetContinentByIdQueryHandlar : IRequestHandler<GetContinentByIdQuery, ContinentDetailsDto?>
{
    private readonly IContinentRepository _continentRepository;

    public GetContinentByIdQueryHandlar(IContinentRepository continentRepository)
    {
        _continentRepository = continentRepository;

    }

    public async Task<ContinentDetailsDto?> Handle(GetContinentByIdQuery request, CancellationToken cancellationToken)
    {
        //var continent = await _continentRepository.GetByIdAsync(request.ID); /*calling*/
        //return new ContinentDetailsDto() { Name =continent.Name };  /*mapping*/

        var Continent = await _continentRepository.GetByIdAsync(request.ID);

        return new ContinentDetailsDto()
        {
            Name = Continent.Name,

        };



    }


}
