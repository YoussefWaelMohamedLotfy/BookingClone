using BookingClone.Application.Features.city.commands.AddCity;
using BookingClone.Application.Features.city.commands.DeleteCity;
using BookingClone.Application.Features.city.commands.UpdateCity;
using BookingClone.Application.Features.city.queries.GetAllCities;
using BookingClone.Application.Features.city.queries.GetCityById;
using BookingClone.Infrastructure.Data;

using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using Polly;

namespace BookingClone.API.Controllers.V1;
[Route("api/[controller]")]
[ApiController]
public class CitysController : ControllerBase
{
    private readonly  BookingDbContext _context;
    private readonly IMediator _mediator;

    public CitysController(BookingDbContext bookingDbContext, IMediator mediator)
    {
        _context = bookingDbContext;
        _mediator = mediator;
    }



    [HttpGet]
    public async Task<IActionResult> GetAllCities()
    {
        var x = await _mediator.Send(new GetAllCitiesQuery());
        return Ok(x);
    }


    [HttpGet("{id}")]

    public async Task<IActionResult> GetCityById([FromRoute] int id)
    {
        return Ok(await _mediator.Send(new GetCityByIdQuery(id)));
    }





    [HttpPost]
    public async Task<IActionResult> AddCity([FromBody] AddCityCommand addCityCommand)
    {
        var x = await _mediator.Send(addCityCommand);
        return Ok(x);

    }



    [HttpDelete]
    public async Task<IActionResult> DeleteCity([FromBody] DeleteCityCommand deleteCityCommand)
    {
        return Ok(await _mediator.Send(deleteCityCommand));

    }

    [HttpPut]
    public async Task<IActionResult> UpdateCity([FromBody] UpdateCityCommand updateCityCommand)
    {
        return Ok(await _mediator.Send(updateCityCommand));
    }
}
