using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.city.DTOs;
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using BookingClone.Application.Features.RoomReservationFeatures.DTOs;
using BookingClone.Domain.Common;
=======
>>>>>>> salmateest
=======
using BookingClone.Application.Features.RoomReservationFeatures.DTOs;
using BookingClone.Domain.Common;
>>>>>>> test2
=======
using BookingClone.Application.Features.RoomReservationFeatures.DTOs;
using BookingClone.Domain.Common;
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.city;
internal class EntityMappingConfig : Profile
{
    public EntityMappingConfig()
    {
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
       
        CreateMap<City, CityDetailsDto>().ReverseMap();
        CreateMap<CityMinimalDto, City>().ReverseMap();


        CreateMap<PagedList<City>, PagedList<CityDetailsDto>>()
            .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));


        
=======
        CreateMap<Cities, AddcityDto2>();
        CreateMap<Cities, CityDetailsDto>();
        CreateMap<CityMinimalDto, Cities>();
        CreateMap<updatecityDto2, Cities>();
>>>>>>> salmateest
=======
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05
       
        CreateMap<Cities, CityDetailsDto>().ReverseMap();
        CreateMap<CityMinimalDto, Cities>().ReverseMap();


        CreateMap<PagedList<Cities>, PagedList<CityDetailsDto>>()
            .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));


        
<<<<<<< HEAD
>>>>>>> test2
=======
>>>>>>> f37231b51413aa449c366de214aabaf312833b05



    }
   


}
