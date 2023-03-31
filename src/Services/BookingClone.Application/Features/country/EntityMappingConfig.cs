using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
<<<<<<< HEAD
<<<<<<< HEAD

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Common;
=======
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
>>>>>>> salmateest
=======

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Common;
>>>>>>> countryview
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.country;
internal class EntityMappingConfig : Profile
{
   
        public EntityMappingConfig()
        {
<<<<<<< HEAD
            CreateMap<Country, CountryDetailsDto>().ReverseMap();
            CreateMap<Country, CountryMinimalDto>().ReverseMap();
          

           CreateMap<PagedList<Country>, PagedList<CountryDetailsDto>>()
          .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));




    }



=======
            CreateMap<Country, CountryDetailsDto>();
            CreateMap<Country, CountryMinimalDto>();

           CreateMap<PagedList<Country>, PagedList<CountryDetailsDto>>()
          .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));




    }



<<<<<<< HEAD
    
>>>>>>> salmateest
=======
>>>>>>> countryview
}
