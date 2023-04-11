using AutoMapper;
using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.HotelFeatures.DTOs;
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.AttractionFeatures;

internal sealed class EntityMappingConfig : Profile
{
    public EntityMappingConfig()
    {
        CreateMap<Attraction, GetAttractionDto>();
        CreateMap<AttractionImage, AttractionImageDto>();
        CreateMap<AddAttractionDto, Attraction>();
        CreateMap<UpdateAttractionDto, Attraction>();
        CreateMap<AttractionDetailsDto, Attraction>().ReverseMap();




    }
}
