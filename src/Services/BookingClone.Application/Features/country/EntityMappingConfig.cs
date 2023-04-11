using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05

using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Common;
<<<<<<< HEAD
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
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.country;
internal class EntityMappingConfig : Profile
{
   
        public EntityMappingConfig()
        {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
            CreateMap<Country, CountryDetailsDto>().ReverseMap();
            CreateMap<Country, CountryMinimalDto>().ReverseMap();
          

           CreateMap<PagedList<Country>, PagedList<CountryDetailsDto>>()
          .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));




    }



<<<<<<< HEAD
=======
            CreateMap<Country, CountryDetailsDto>();
            CreateMap<Country, CountryMinimalDto>();
=======
            CreateMap<Country, CountryDetailsDto>().ReverseMap();
            CreateMap<Country, CountryMinimalDto>().ReverseMap();
          
>>>>>>> select

           CreateMap<PagedList<Country>, PagedList<CountryDetailsDto>>()
          .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));




    }



<<<<<<< HEAD
    
>>>>>>> salmateest
=======
>>>>>>> countryview
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
}
