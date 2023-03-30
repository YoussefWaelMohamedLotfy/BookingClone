using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
<<<<<<< HEAD

using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Common;
=======
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.continent.DTOs;
>>>>>>> salmateest
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.continent;
internal class EntityMappingConfig : Profile
{

    public EntityMappingConfig()
    {
<<<<<<< HEAD
        CreateMap<Continent, ContinentDetailsDto>().ReverseMap();
        CreateMap<Continent, ContinentMinimalDto>().ReverseMap();

        CreateMap<PagedList<Continent>, PagedList<ContinentDetailsDto>>()
           .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));




    }


=======
        CreateMap<Continent, ContinentDetailsDto>();
        CreateMap<Continent, ContinentMinimalDto>();
        

    } 

   
>>>>>>> salmateest
}
