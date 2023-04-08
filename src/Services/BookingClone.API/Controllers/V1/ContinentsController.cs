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
using BookingClone.Application.Features.country.commands.UpdateCountry;
<<<<<<< HEAD
using BookingClone.Application.Features.country.commands.UpdateCountry;
=======
>>>>>>> add city and country and continent
using BookingClone.Infrastructure.Data;
using MediatR;

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookingClone.API.Controllers.V1;
[Route("api/[controller]")]
[ApiController]
public class ContinentsController : ControllerBase
{
<<<<<<< HEAD
<<<<<<< HEAD

    private readonly IMediator _mediator;

    public ContinentsController(IMediator mediator)


       => _mediator = mediator;


=======
    private readonly BookingDbContext _context;
    private readonly IMediator _mediator;

    public ContinentsController(BookingDbContext bookingDbContext, IMediator mediator)
    {
        _context = bookingDbContext;
        _mediator = mediator;
    }
>>>>>>> add city and country and continent
=======

    private readonly IMediator _mediator;

    public ContinentsController(IMediator mediator)


       => _mediator = mediator;


>>>>>>> finalcommit



    [HttpGet]
<<<<<<< HEAD
<<<<<<< HEAD
    public async Task<IActionResult> GetAllContinent(CancellationToken ct)
    {
        return Ok(await _mediator.Send(new GetAllcontinentQuery(), ct));
    }



    [HttpGet("{id}")]//, Name = "Get_[controller]")]

    public async Task<IActionResult> GetContinentById(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new GetContinentByIdQuery(id), ct);
        return result is null ? NotFound() : Ok(result);
=======
    public IActionResult GetAllContinent()
=======
    public async Task<IActionResult> GetAllContinent(CancellationToken ct)
>>>>>>> finalcommit
    {
        return Ok(await _mediator.Send(new GetAllcontinentQuery(), ct));
    }



    [HttpGet("{id}", Name = "Get_[controller]")]

    public async Task<IActionResult> GetContinentById(int id, CancellationToken ct)
    {
<<<<<<< HEAD
        return Ok(await _mediator.Send(new GetContinentByIdQuery(id)));
>>>>>>> add city and country and continent
    }





<<<<<<< HEAD


    [HttpPost]
    public async Task<IActionResult> AddContinent([FromBody] AddContinentCommmand addContinentCommmand, CancellationToken ct)
    {
        var result = await _mediator.Send(addContinentCommmand, ct);
        return CreatedAtRoute("Get_Continents", new { id = result.ID }, result);
=======
        var result = await _mediator.Send(new GetContinentByIdQuery(id), ct);
        return result is null ? NotFound() : Ok(result);
>>>>>>> finalcommit
    }

    [HttpPut]
    public async Task<IActionResult> UpdateContinent([FromBody] UpdateContinentCommmand updateContinentCommmand, CancellationToken ct)
    {
        var result = await _mediator.Send(updateContinentCommmand, ct);
        return result is not null ? Ok(result) : NotFound();
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContinent(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new DeleteContinentCommmand(id), ct);
        return result <= 0 ? NotFound() : NoContent();
    }



<<<<<<< HEAD
=======
    [HttpPost]
    public async Task<IActionResult> AddContinent([FromBody] AddContinentCommmand addContinentCommmand)
    {
=======
>>>>>>> finalcommit


    [HttpPost]
    public async Task<IActionResult> AddContinent([FromBody] AddContinentCommmand addContinentCommmand, CancellationToken ct)
    {
        var result = await _mediator.Send(addContinentCommmand, ct);
        return CreatedAtRoute("Get_Continents", new { id = result.ID }, result);
    }

    [HttpPut]
    public async Task<IActionResult> UpdateContinent([FromBody] UpdateContinentCommmand updateContinentCommmand, CancellationToken ct)
    {
        var result = await _mediator.Send(updateContinentCommmand, ct);
        return result is not null ? Ok(result) : NotFound();
    }


    [HttpDelete("{id}")]
    public async Task<IActionResult> DeleteContinent(int id, CancellationToken ct)
    {
        var result = await _mediator.Send(new DeleteContinentCommmand(id), ct);
        return result <= 0 ? NotFound() : NoContent();
    }
<<<<<<< HEAD
>>>>>>> add city and country and continent
=======



>>>>>>> finalcommit
}
