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
<<<<<<< HEAD
public class CitiesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CitiesController(IMediator mediator)
        => _mediator = mediator;
=======
public class CitysController : ControllerBase
{
    private readonly  BookingDbContext _context;
    private readonly IMediator _mediator;

    public CitysController(BookingDbContext bookingDbContext, IMediator mediator)
    {
        _context = bookingDbContext;
        _mediator = mediator;
    }
>>>>>>> add city and country and continent



    [HttpGet]
<<<<<<< HEAD
    public async Task<IActionResult> GetAllCities(CancellationToken ct)
    {
        return Ok(await _mediator.Send(new GetAllCitiesQuery(), ct));
    }



    [HttpGet("{id}", Name = "Get_[controller]")]

    public async Task<IActionResult> GetCityById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new GetCityByIdQuery(id), ct);
        return result is null ? NotFound() : Ok(result);
    }


    [HttpPost]
    public async Task<IActionResult> AddCity([FromBody] AddCityCommand addCityCommand, CancellationToken ct)
    {
        var result = await _mediator.Send(addCityCommand, ct);
        return CreatedAtRoute("Get_Cities", new { id = result.ID }, result);
=======
    public async Task<IActionResult> GetAllCities()
    {
        return Ok(await _mediator.Send(new GetAllCitiesQuery()));
    }


    [HttpGet("{id}")]

    public async Task<IActionResult> GetCityById([FromRoute] int id)
    {
        return Ok(await _mediator.Send(new GetCityByIdQuery(id)));
    }





    [HttpPost]
    public async Task<IActionResult> AddCity([FromBody] AddCityCommand addCityCommand)
    {

        return Ok(await _mediator.Send(addCityCommand));

>>>>>>> add city and country and continent
    }



<<<<<<< HEAD
    [HttpPut]
    public async Task<IActionResult> UpdateCity([FromBody] UpdateCityCommand updateCityCommand, CancellationToken ct)
    {
        var result = await _mediator.Send(updateCityCommand, ct);
        return result is not null ? Ok(result) : NotFound();
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCity(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new DeleteCityCommand(id), ct);
        return result <= 0 ? NotFound() : NoContent();
    }


}
=======
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
>>>>>>> add city and country and continent
