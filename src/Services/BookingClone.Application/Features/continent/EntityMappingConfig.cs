using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD

using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Common;
=======
using BookingClone.Application.Features.city.DTOs;
=======

>>>>>>> select
using BookingClone.Application.Features.continent.DTOs;
<<<<<<< HEAD
>>>>>>> salmateest
=======
using BookingClone.Domain.Common;
>>>>>>> continentview
=======

using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Domain.Common;
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.continent;
internal class EntityMappingConfig : Profile
{

    public EntityMappingConfig()
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
        CreateMap<Continent, ContinentDetailsDto>().ReverseMap();
        CreateMap<Continent, ContinentMinimalDto>().ReverseMap();

        CreateMap<PagedList<Continent>, PagedList<ContinentDetailsDto>>()
           .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));




    }


<<<<<<< HEAD
=======
        CreateMap<Continent, ContinentDetailsDto>();
        CreateMap<Continent, ContinentMinimalDto>();
=======
        CreateMap<Continent, ContinentDetailsDto>().ReverseMap();
        CreateMap<Continent, ContinentMinimalDto>().ReverseMap();
>>>>>>> almostdone

        CreateMap<PagedList<Continent>, PagedList<ContinentDetailsDto>>()
           .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));




    }


<<<<<<< HEAD
   
>>>>>>> salmateest
=======
>>>>>>> continentview
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
}
