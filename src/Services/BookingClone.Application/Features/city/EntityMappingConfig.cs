using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.city.DTOs;
<<<<<<< HEAD
using BookingClone.Application.Features.RoomReservationFeatures.DTOs;
using BookingClone.Domain.Common;
=======
>>>>>>> salmateest
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.city;
internal class EntityMappingConfig : Profile
{
    public EntityMappingConfig()
    {
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



    }
   


}
