using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD
using AutoMapper;

=======
>>>>>>> add city and country and continent
=======
using AutoMapper;

>>>>>>> continentview
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetCityById;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
<<<<<<< HEAD
<<<<<<< HEAD
using BookingClone.Infrastructure.Repositories;

=======
>>>>>>> add city and country and continent
=======
using BookingClone.Infrastructure.Repositories;

>>>>>>> api(country_continent_city)
using MediatR;

namespace BookingClone.Application.Features.continent.queries.GetContinentById;
public class GetContinentByIdQueryHandlar : IRequestHandler<GetContinentByIdQuery, ContinentDetailsDto?>
{
<<<<<<< HEAD
<<<<<<< HEAD

    private readonly IContinentRepository _continentRepository;
    private readonly IMapper _mapper;
    public GetContinentByIdQueryHandlar(IContinentRepository continentRepository, IMapper mapper)
    {
        _continentRepository = continentRepository;
        _mapper = mapper;
=======
    private readonly IContinentRepository _continentRepository;
=======
>>>>>>> continentview

    private readonly IContinentRepository _continentRepository;
    private readonly IMapper _mapper;
    public GetContinentByIdQueryHandlar(IContinentRepository continentRepository, IMapper mapper)
    {
        _continentRepository = continentRepository;
<<<<<<< HEAD

>>>>>>> add city and country and continent
=======
        _mapper = mapper;
>>>>>>> continentview
    }

    public async Task<ContinentDetailsDto?> Handle(GetContinentByIdQuery request, CancellationToken cancellationToken)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
        var result = await _continentRepository.GetByIdAsync(request.ID, cancellationToken);
        return result is null ? null : _mapper.Map<ContinentDetailsDto>(result);
    }


=======
        var continent = await _continentRepository.GetByIdAsync(request.ID); /*calling*/
        return new ContinentDetailsDto() { Name =continent.Name, Countries =continent.Countries };  /*mapping*/
    }

    
>>>>>>> add city and country and continent
=======
        //var continent = await _continentRepository.GetByIdAsync(request.ID); /*calling*/
        //return new ContinentDetailsDto() { Name =continent.Name };  /*mapping*/

        var Continent = await _continentRepository.GetByIdAsync(request.ID);

        return new ContinentDetailsDto()
        {
            Name = Continent.Name,

        };



=======
        var result = await _continentRepository.GetByIdAsync(request.ID, cancellationToken);
        return result is null ? null : _mapper.Map<ContinentDetailsDto>(result);
>>>>>>> continentview
    }


>>>>>>> api(country_continent_city)
}
