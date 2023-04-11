using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Domain.Contracts;

using MediatR;

namespace BookingClone.Application.Features.city.queries.GetAllCities;
public class GetAllCitiesQueryHandlar : IRequestHandler<GetAllCitiesQuery, IEnumerable<CityMinimalDto>>
{

        private readonly ICityRepository _cityRepository;

        public GetAllCitiesQueryHandlar(ICityRepository cityRepository)
        {
           _cityRepository = cityRepository;

        }

    public async Task<IEnumerable<CityMinimalDto>> Handle(GetAllCitiesQuery request, CancellationToken cancellationToken)
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
        var city =  _cityRepository.GetAll().Result;
        var city_Dto = city.Select(a => new CityMinimalDto { 
            Name = a.Name,
            CountryID= a.CountryID,
        }); 
        return (city_Dto);
         
<<<<<<< HEAD
=======
        return (await _cityRepository.GetAll()) /*calling */
         .Select(a => new CityMinimalDto { Name =a.Name} );  /*Mapping*/
>>>>>>> add city and country and continent
=======
        var x =  _cityRepository.GetAll().Result;
        var y = x.Select(a => new CityMinimalDto { Name = a.Name }); 
        return (y);
=======
        var city =  _cityRepository.GetAll().Result;
        var city_Dto = city.Select(a => new CityMinimalDto { Name = a.Name }); 
        return (city_Dto);
>>>>>>> finalcommit
         
>>>>>>> api(country_continent_city)
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
    }



   
}
