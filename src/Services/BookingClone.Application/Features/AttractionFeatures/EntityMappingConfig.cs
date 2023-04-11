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
<<<<<<< HEAD
<<<<<<< HEAD
        CreateMap<PagedList<Attraction>, PagedList<GetAttractionDto>>()
            .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));
=======
>>>>>>> first commit
=======
        CreateMap<AttractionDetailsDto, Attraction>().ReverseMap();




>>>>>>> Add_Action_getAttractionbycityid_inAttraction
=======
        CreateMap<AttractionDetailsDto, Attraction>().ReverseMap();




>>>>>>> f37231b51413aa449c366de214aabaf312833b05
    }
}
