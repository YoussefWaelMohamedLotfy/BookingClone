using AutoMapper;
using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.AttractionFeatures;

internal sealed class EntityMappingConfig : Profile
{
    public EntityMappingConfig()
    {
        CreateMap<Attraction, GetAttractionDto>();
        //CreateMap<AddAttractionReservationDto, Attraction>();
        //CreateMap<UpdateAttractionReservationDto, Attraction>();
    }
}
