using Bogus.DataSets;
using BookingClone.Application.Features.city.commands.AddCity;
using BookingClone.Application.Features.city.commands.DeleteCity;
using BookingClone.Application.Features.city.commands.UpdateCity;
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetAllCities;
using BookingClone.Application.Features.city.queries.GetCityById;
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Data;

using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookingClone.Admin.Controllers;
public class CityController : Controller
{
    private readonly IMediator _mediator;

    
    public CityController(IMediator mediator)
        => _mediator = mediator;

    public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10, CancellationToken ct = default)
    {
        var reservations = await _mediator.Send(new getallcitiesquery2() { Query = new(pageNumber, pageSize) }, ct);
        return View(reservations);
    }


    public async Task<IActionResult> Details(int id, CancellationToken ct)
    {
        var reservation = await _mediator.Send(new GetCityByIdQuery(id), ct);
        return View(reservation);
    }

    public IActionResult Create()
    {
        //this.ViewData["items"] = commodities
        //.GetAll()
        //.Select(c => new SelectListItem() { Text = c.Code, Value = c.Oid.ToString() })
        //.ToList();
         return View(); 
    }
        

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CityDetailsDto request, CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return View(request);

        var newReservation = await _mediator.Send(new addcitycommand2 { Dto = request }, ct);
        return RedirectToAction(nameof(Details), new { id = newReservation.ID });
    }





    public async Task<IActionResult> Edit(int id, CancellationToken ct)
    {
        var reservations = await _mediator.Send(new GetCityByIdQuery (id ), ct);
        return View(reservations);
    }




    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(CityDetailsDto request, CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return View(request);

        await _mediator.Send(new updatecitycommand2 { Dto = request }, ct);
        return RedirectToAction(nameof(Details), new { id = request.ID });
    }

    

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id, CancellationToken ct)
    {
        await _mediator.Send(new DeleteCityCommand ( id ), ct);
        return RedirectToAction(nameof(Index));
    }


}
