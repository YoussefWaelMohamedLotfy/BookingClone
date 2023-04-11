using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using BookingClone.Domain.Common;

=======
>>>>>>> add city and country and continent
=======
using BookingClone.Domain.Common;

>>>>>>> salmateest
=======
using BookingClone.Domain.Common;

>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using MediatR;

namespace BookingClone.Application.Features.city.queries.GetAllCities;
public class GetAllCitiesQuery : IRequest<IEnumerable<CityMinimalDto>>
{
    public string? Name { get; set; }
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
   
=======
>>>>>>> add city and country and continent
=======
   
>>>>>>> salmateest
=======
    public int? CountryID { get; set; }
    

>>>>>>> new action getcitybycountryid
=======
    public int? CountryID { get; set; }
    

>>>>>>> f37231b51413aa449c366de214aabaf312833b05
}


