using BookingClone.Application.Features.AttractionReservationFeatures.Commands.AddAttractionReservation;
using BookingClone.Application.Features.AttractionReservationFeatures.DTOs;
using BookingClone.Application.Features.AttractionReservationFeatures.Queries.GetAttractionReservationById;
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

    [HttpGet("{id}", Name = "Get_[controller]")]
    public async Task<IActionResult> GetById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new GetAttractionReservationByIdQuery { ID = id }, ct);
        return result is null ? NotFound() : Ok(result);
    }

    [HttpPost]
    public async Task<IActionResult> AddNewReservation(AddAttractionReservationDto request, CancellationToken ct)
    {
        var result = await _mediator.Send(new AddAttractionReservationCommand { Dto = request }, ct);
        return CreatedAtRoute("Get_AttractionReservations", new { id = result.ID }, result);
    }
}
