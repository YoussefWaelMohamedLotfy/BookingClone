using AutoMapper;
using BookingClone.Application.Features.RoomReservationFeatures.DTOs;
<<<<<<< HEAD
using BookingClone.Domain.Common;
=======
>>>>>>> first commit
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.RoomReservationFeatures;

internal sealed class EntityMappingConfig : Profile
{
    public EntityMappingConfig()
    {
        CreateMap<RoomReservation, GetRoomReservationDto>();
        CreateMap<AddRoomReservationDto, RoomReservation>();
        CreateMap<UpdateRoomReservationDto, RoomReservation>();
<<<<<<< HEAD
        CreateMap<PagedList<RoomReservation>, PagedList<GetRoomReservationDto>>()
            .ForMember(x => x.Data, f => f.MapFrom(x => x.Data));
=======
>>>>>>> first commit
    }
}
