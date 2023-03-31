﻿using BookingClone.Application.Features.RoomFeatures.Commands.AddRoom;
using BookingClone.Application.Features.RoomFeatures.Commands.DeleteRoom;
using BookingClone.Application.Features.RoomFeatures.Commands.UpdateRoom;
using BookingClone.Application.Features.RoomFeatures.DTOs;
using BookingClone.Application.Features.RoomFeatures.Queries.GetRoomById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookingClone.API.Controllers.V1;

[Route("api/[controller]")]
[ApiController]
public class RoomsController : ControllerBase
{
    private readonly IMediator _mediator;

    public RoomsController(IMediator mediator)
        => _mediator = mediator;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetRoomById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new GetRoomByIdQuery { ID = id }, ct);
        return result is null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddNewRoom(AddRoomDto request, CancellationToken ct)
    {
        var result = await _mediator.Send(new AddRoomCommand { Dto = request }, ct);
        return CreatedAtAction(nameof(GetRoomById), new { id = result.ID }, result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateExistingRoom(UpdateRoomDto request, CancellationToken ct)
    {
        var result = await _mediator.Send(new UpdateRoomCommand { Dto = request }, ct);
        return result is not null ? Ok(result) : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteRoomById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new DeleteRoomCommand { ID = id }, ct);
        return result <= 0 ? NotFound() : NoContent();
    }
}