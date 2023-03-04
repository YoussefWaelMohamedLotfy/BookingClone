using BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionById;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace BookingClone.API.Controllers.V1;

[Route("api/[controller]")]
[ApiController]
public class AttractionsController : ControllerBase
{
    private readonly IMediator _mediator;

    public AttractionsController(IMediator mediator)
        => _mediator = mediator;

    [HttpGet("{id}")]
    public async Task<IActionResult> GetAttractionById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new GetAttractionByIdQuery { ID = id }, ct);
        return result is null ? NotFound() : Ok(result);
    }
}
