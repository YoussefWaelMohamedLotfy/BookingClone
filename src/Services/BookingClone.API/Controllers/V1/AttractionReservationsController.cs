using BookingClone.Application.Features.AttractionReservation.Queries.GetAttractionReservationById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookingClone.API.Controllers.V1;

[Route("api/[controller]")]
[ApiController]
public class AttractionReservationsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AttractionReservationsController(IMediator mediator)
    {
        _mediator = mediator;
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id, CancellationToken ct)
    {
        var res = await _mediator.Send(new GetAttractionReservationByIdQuery { ID = id }, ct);
        return res is null ? NotFound() : Ok(res);
    }
}
