using AutoMapper;
using BookingClone.Application.Features.AttractionReservationFeatures.DTOs;
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.AttractionReservationFeatures;

internal sealed class EntityMappingConfig : Profile
{
    public EntityMappingConfig()
    {
        CreateMap<AttractionReservation, GetAttractionReservationDto>();
        CreateMap<AddAttractionReservationDto, AttractionReservation>();
        CreateMap<UpdateAttractionReservationDto, AttractionReservation>();
    }
}
