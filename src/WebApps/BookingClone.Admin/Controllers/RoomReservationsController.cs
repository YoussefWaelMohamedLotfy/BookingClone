using BookingClone.Application.Features.RoomReservationFeatures.Queries.GetAllRoomReservations;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace BookingClone.Admin.Controllers;

public sealed class RoomReservationsController : Controller
{
    private readonly IMediator _mediator;

    public RoomReservationsController(IMediator mediator)
        => _mediator = mediator;

    public async Task<IActionResult> Index(CancellationToken ct)
    {
        var reservations = await _mediator.Send(new GetAllRoomReservationsQuery(), ct);
        return View(reservations);
    }
}
