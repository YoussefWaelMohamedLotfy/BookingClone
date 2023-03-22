using AutoMapper;
using BookingClone.Application.Features.RoomReservationFeatures.DTOs;
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.RoomReservationFeatures;

internal sealed class EntityMappingConfig : Profile
{
    public EntityMappingConfig()
    {
        CreateMap<RoomReservation, GetRoomReservationDto>();
        CreateMap<AddRoomReservationDto, RoomReservation>();
        CreateMap<UpdateRoomReservationDto, RoomReservation>();
    }
}
