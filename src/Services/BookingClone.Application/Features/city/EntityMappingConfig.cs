using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.city;
internal class EntityMappingConfig : Profile
{
    public EntityMappingConfig()
    {
        CreateMap<Cities, AddcityDto2>();
        CreateMap<Cities, CityDetailsDto>();
        CreateMap<CityMinimalDto, Cities>();
        CreateMap<updatecityDto2, Cities>();



    }
   


}
