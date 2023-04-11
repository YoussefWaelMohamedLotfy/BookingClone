using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

=======
using BookingClone.Application.Features.city.commands.UpdateCity;
using BookingClone.Application.Features.city.DTOs;
>>>>>>> add city and country and continent
=======

>>>>>>> select
=======

>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Contracts;
using BookingClone.Infrastructure.Repositories;

using MediatR;

namespace BookingClone.Application.Features.continent.commands.UpdateContinent;
public class UpdateContinentCommmandHandlar : IRequestHandler<UpdateContinentCommmand, ContinentDetailsDto>
{
    private readonly IContinentRepository _continentRepository;

    public UpdateContinentCommmandHandlar(IContinentRepository continentRepository)
    {
        _continentRepository = continentRepository;

    }
   
    public async Task<ContinentDetailsDto> Handle(UpdateContinentCommmand request, CancellationToken cancellationToken)
    {
        var Continent = await _continentRepository.GetByIdAsync(request.ID);
       
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> api(country_continent_city)
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
         

        var cont = new ContinentDetailsDto { Name = request.Name };
        Continent.Name = request.Name;

        _continentRepository.Update(Continent);

        _continentRepository.SaveAsync(cancellationToken);
        return cont;

       
        
        
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

    }
}

<<<<<<< HEAD
=======
          _continentRepository.Update(Continent);
=======
>>>>>>> api(country_continent_city)

    }
}
<<<<<<< HEAD
>>>>>>> add city and country and continent
=======

>>>>>>> api(country_continent_city)
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
