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
<<<<<<< HEAD
public class CitiesController : ControllerBase
{
    private readonly IMediator _mediator;

    public CitiesController(IMediator mediator)
        => _mediator = mediator;
=======
public class CitysController : ControllerBase
=======
public class CitiesController : ControllerBase
>>>>>>> finalcommit
{
    private readonly IMediator _mediator;

<<<<<<< HEAD
    public CitysController(BookingDbContext bookingDbContext, IMediator mediator)
    {
        _context = bookingDbContext;
        _mediator = mediator;
    }
>>>>>>> add city and country and continent
=======
    public CitiesController(IMediator mediator)
        => _mediator = mediator;
>>>>>>> finalcommit



    [HttpGet]
<<<<<<< HEAD
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
=======
    public async Task<IActionResult> GetAllCities(CancellationToken ct)
>>>>>>> finalcommit
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
<<<<<<< HEAD
        var x = await _mediator.Send(addCityCommand);
        return Ok(x);

>>>>>>> add city and country and continent
    }



<<<<<<< HEAD
    [HttpPut]
    public async Task<IActionResult> UpdateCity([FromBody] UpdateCityCommand updateCityCommand, CancellationToken ct)
    {
        var result = await _mediator.Send(updateCityCommand, ct);
        return result is not null ? Ok(result) : NotFound();
=======
        var result = await _mediator.Send(addCityCommand, ct);
        return CreatedAtRoute("Get_Cities", new { id = result.ID }, result);
>>>>>>> finalcommit
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteCity(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new DeleteCityCommand(id), ct);
        return result <= 0 ? NotFound() : NoContent();
    }


<<<<<<< HEAD
}
=======
    [HttpDelete]
    public async Task<IActionResult> DeleteCity([FromBody] DeleteCityCommand deleteCityCommand)
=======
    [HttpPut]
    public async Task<IActionResult> UpdateCity([FromBody] UpdateCityCommand updateCityCommand, CancellationToken ct)
>>>>>>> finalcommit
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
<<<<<<< HEAD
}
>>>>>>> add city and country and continent
=======


}
>>>>>>> finalcommit
