﻿using AutoMapper;
using BookingClone.Application.Features.RoomFeatures.DTOs;
using BookingClone.Domain.Entities;

namespace BookingClone.Application.Features.RoomFeatures;

public class EntityMappingConfig : Profile
{
    public EntityMappingConfig()
    {
        CreateMap<Room, GetRoomDto>();
        CreateMap<AddRoomDto, Room>();
        CreateMap<UpdateRoomDto, Room>();
    }
}
