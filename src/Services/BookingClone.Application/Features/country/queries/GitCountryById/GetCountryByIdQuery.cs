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

namespace BookingClone.Application.Features.country.queries.GitCountryById;
public class GetCountryByIdQuery   :IRequest<CountryDetailsDto>
{

   

        public  int ID { get; set; }

        public GetCountryByIdQuery(int iD)
        {
            ID = iD;
        }

    



}
