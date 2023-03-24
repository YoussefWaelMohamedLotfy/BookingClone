using BookingClone.Application.Features.city.commands.AddCity;
using BookingClone.Application.Features.city.commands.DeleteCity;
using BookingClone.Application.Features.city.commands.UpdateCity;
using BookingClone.Application.Features.city.queries.GetAllCities;
using BookingClone.Application.Features.city.queries.GetCityById;
using BookingClone.Application.Features.continent.commands.AddContinent;
using BookingClone.Application.Features.continent.commands.DeleteContinent;
using BookingClone.Application.Features.continent.commands.UpdateContinent;
using BookingClone.Application.Features.continent.queries.GetAllcontinent;
using BookingClone.Application.Features.continent.queries.GetContinentById;
using BookingClone.Infrastructure.Data;
using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingClone.API.Controllers.V1;
[Route("api/[controller]")]
[ApiController]
public class ContinentsController : ControllerBase
{
    private readonly BookingDbContext _context;
    private readonly IMediator _mediator;

    public ContinentsController(BookingDbContext bookingDbContext, IMediator mediator)
    {
        _context = bookingDbContext;
        _mediator = mediator;
    }



    [HttpGet]
    public IActionResult GetAllContinent()
    {
        return Ok(_mediator.Send(new GetAllcontinentQuery()));
    }


    [HttpGet("{id}")]
     
    public async Task<IActionResult> GetContinentById([FromRoute] int id)
    {
        return Ok(await _mediator.Send(new GetContinentByIdQuery(id)));
    }





    [HttpPost]
    public async Task<IActionResult> AddContinent([FromBody] AddContinentCommmand addContinentCommmand)
    {

        return Ok(await _mediator.Send(addContinentCommmand));

    }



    [HttpDelete]
    public async Task<IActionResult> DeleteContinent([FromBody] DeleteContinentCommmand deleteContinentCommmand)
    {
        return Ok(await _mediator.Send(deleteContinentCommmand));

    }

    [HttpPut]
    public async Task<IActionResult> UpdateContinent([FromBody] UpdateContinentCommmand updateContinentCommmand)
    {
        return Ok(await _mediator.Send(updateContinentCommmand));
    }
}
