using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.country.DTOs;

using MediatR;

namespace BookingClone.Application.Features.country.queries.GitCountryById;
public class GitCountryByIdQuery   :IRequest<CountryDetailsDto>
{

   

        public  int ID { get; set; }

        public GitCountryByIdQuery(int iD)
        {
            ID = iD;
        }

    



}
