using BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionById;
using BookingClone.Application.Features.HotelFeatures.AddHotel;
using BookingClone.Application.Features.HotelFeatures.DeleteHotel;
using BookingClone.Application.Features.HotelFeatures.Queries.GetById;
using BookingClone.Application.Features.HotelFeatures.UpdateHotel;

using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingClone.API.Controllers.V1;
[Route("api/[controller]")]
[ApiController]
public class HotelsController : ControllerBase
{
    private readonly IMediator _mediator;

    public HotelsController(IMediator mediator)
        => _mediator = mediator;



    [HttpGet("{id}")]


    public async Task<IActionResult> GetHotelDetails([FromHeader] GetByIdQuery q)
    {
        return Ok(await _mediator.Send(q));
    }
   


    [HttpPost]
    public async Task<IActionResult> AddHotel(AddHotelCommand command)
    {

        return Ok(await _mediator.Send(command));

    }

    [HttpPut]
    public async Task<IActionResult> UpdateHotel(UpdateHotelCommand command)
    {
        return Ok(await _mediator.Send(command));
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHotel(DeleteHotelCommand command)
    {
        return Ok(await _mediator.Send(command));

    }



}
