using BookingClone.Application.Features.AttractionReservationFeatures.Commands.AddAttractionReservation;
using BookingClone.Application.Features.AttractionReservationFeatures.Commands.DeleteAttractionReservation;
using BookingClone.Application.Features.AttractionReservationFeatures.Commands.UpdateAttractionReservation;
using BookingClone.Application.Features.AttractionReservationFeatures.DTOs;
using BookingClone.Application.Features.AttractionReservationFeatures.Queries.GetAttractionReservationById;

using MediatR;

using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BookingClone.API.Controllers.V1;


[Route("api/[controller]")]
[ApiController]
public class HotelReviewsController : Controller
{

    private readonly IMediator _mediator;

    public HotelReviewsController(IMediator mediator)
        => _mediator = mediator;

    [HttpGet("{id}", Name = "Get_[controller]")]
    public async Task<IActionResult> GetHotelReviewById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new GetAttractionReservationByIdQuery { ID = id }, ct);
        return result is null ? NotFound() : Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> AddNewHotelReview(AddAttractionReservationDto request, CancellationToken ct)
    {
        var result = await _mediator.Send(new AddAttractionReservationCommand { Dto = request }, ct);
        return CreatedAtRoute("Get_AttractionReservations", new { id = result.ID }, result);
    }


    [HttpPut]
    public async Task<IActionResult> UpdateExistingHotelReview(UpdateAttractionReservationDto request, CancellationToken ct)
    {
        var result = await _mediator.Send(new UpdateAttractionReservationCommand { Dto = request }, ct);
        return result is not null ? Ok(result) : NotFound();
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHotelReviewById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new DeleteAttractionReservationCommand { ID = id }, ct);
        return result <= 0 ? NotFound() : NoContent();
    }

}

