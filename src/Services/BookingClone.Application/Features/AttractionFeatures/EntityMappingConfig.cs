using AutoMapper;
using BookingClone.Application.Features.AttractionFeatures.DTOs;
<<<<<<< HEAD
using BookingClone.Domain.Common;
=======
>>>>>>> first commit
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
<<<<<<< HEAD
        CreateMap<PagedList<Attraction>, PagedList<GetAttractionDto>>()
            .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));
=======
>>>>>>> first commit
    }
}
