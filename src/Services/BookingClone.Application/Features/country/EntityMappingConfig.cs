using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using AutoMapper;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.country;
internal class EntityMappingConfig : Profile
{
   
        public EntityMappingConfig()
        {
            CreateMap<Country, CountryDetailsDto>();
            CreateMap<Country, CountryMinimalDto>();


        }


    
}
