﻿using BookingClone.Domain.Entities;

namespace BookingClone.Domain.Contracts;

public interface IRoomRepository : IGenericRepository<Room, int>
{
    Task<List<Room>> GetAll(CancellationToken ct = default);
    Task<Room?> GetRoomDetails(int id, CancellationToken ct = default);
}
