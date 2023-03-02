using AutoMapper;
using BookingClone.Application.Features.AttractionReservation.DTOs;

namespace BookingClone.Application.Features.AttractionReservation;

internal sealed class EntityMappingConfig : Profile
{
    public EntityMappingConfig()
    {
        CreateMap<Domain.Entities.AttractionReservation, GetAttractionReservationDto>();
    }
}
