using BookingClone.Application.Features.AttractionFeatures.Commands.AddAttraction;
using BookingClone.Application.Features.AttractionFeatures.Commands.DeleteAttraction;
using BookingClone.Application.Features.AttractionFeatures.Commands.UpdateAttraction;
using BookingClone.Application.Features.AttractionFeatures.DTOs;
using BookingClone.Application.Features.AttractionFeatures.Queries.GetAttractionById;
using BookingClone.Application.Features.HotelFeatures.AddHotel;
using BookingClone.Application.Features.HotelFeatures.DeleteHotel;
using BookingClone.Application.Features.HotelFeatures.DTOs;
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



    [HttpGet("{id}") ]

    public async Task<IActionResult> GetHotelById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new GetByIdQuery { ID = id }, ct);
        return result is null ? NotFound() : Ok(result);
    }

    //public async Task<IActionResult> GetHotelDetails([FromHeader] GetByIdQuery q)
    //{
    //    return Ok(await _mediator.Send(q));
    //}



    [HttpPost]
    public async Task<IActionResult> AddHotel(AddHotelsDto request , CancellationToken ct)
    {
        var result = await _mediator.Send(new AddHotelCommand { Dto = request }, ct);
        return CreatedAtAction(nameof(GetHotelById), new { ID = result.Id }, result);
       

    }

  

    [HttpPut]

    public async Task<IActionResult> UpdateExistingHotel(UpdateHotelDto request, CancellationToken ct)
    {
        var result = await _mediator.Send(new UpdateHotelCommand { Dto = request }, ct);
        return result is not null ? Ok(result) : NotFound();
    }
    //public async Task<IActionResult> UpdateHotel(UpdateHotelCommand command)
    //{
    //    return Ok(await _mediator.Send(command));
    //}


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteHotelById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new DeleteHotelCommand { Id = id }, ct);
        return result <= 0 ? NotFound() : NoContent();
    }


    //public async Task<IActionResult> DeleteHotel(DeleteHotelCommand command)
    //{
    //    return Ok(await _mediator.Send(command));

    //}



}
