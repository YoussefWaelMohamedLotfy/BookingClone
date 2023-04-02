<<<<<<< HEAD
﻿using BookingClone.Application.Features.continent.commands.AddContinent;
=======
﻿


using BookingClone.Application.Features.continent.commands.AddContinent;
>>>>>>> salmateest
using BookingClone.Application.Features.continent.commands.DeleteContinent;
using BookingClone.Application.Features.continent.commands.UpdateContinent;
using BookingClone.Application.Features.continent.DTOs;
using BookingClone.Application.Features.continent.queries.GetAllcontinent;
using BookingClone.Application.Features.continent.queries.GetContinentById;
<<<<<<< HEAD
<<<<<<< HEAD
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookingClone.Admin.Controllers;

[Authorize]
public sealed class ContinentController : Controller
=======
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Data;
=======

>>>>>>> almostdone

using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookingClone.Admin.Controllers;
public class ContinentController : Controller
>>>>>>> salmateest
{

    private readonly IMediator _mediator;

    public ContinentController(IMediator mediator)
        => _mediator = mediator;

    public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10, CancellationToken ct = default)
    {
        var reservations = await _mediator.Send(new getallcontinentquery2() { Query = new(pageNumber, pageSize) }, ct);
        return View(reservations);
    }

    public async Task<IActionResult> Details(int id, CancellationToken ct)
    {
        var reservation = await _mediator.Send(new GetContinentByIdQuery(id), ct);
        return View(reservation);
    }

    public IActionResult Create()
        => View();
<<<<<<< HEAD

=======
    
>>>>>>> salmateest
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(ContinentDetailsDto request, CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return View(request);

        var newReservation = await _mediator.Send(new addcontinentcommand2 { Dto = request }, ct);
        return RedirectToAction(nameof(Details), new { id = newReservation.ID });
    }





    public async Task<IActionResult> Edit(int id, CancellationToken ct)
    {
        var reservations = await _mediator.Send(new GetContinentByIdQuery(id), ct);
        return View(reservations);
    }




    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(ContinentDetailsDto request, CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return View(request);

        await _mediator.Send(new updatecontinentcommand2 { Dto = request }, ct);
        return RedirectToAction(nameof(Details), new { id = request.ID });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id, CancellationToken ct)
    {
        await _mediator.Send(new DeleteContinentCommmand(id), ct);
        return RedirectToAction(nameof(Index));
    }




<<<<<<< HEAD
<<<<<<< HEAD
=======



<<<<<<< HEAD
>>>>>>> salmateest
}
=======



    //public class CityController : Controller
    //{
    //    private readonly IMediator _mediator;


    //    public CityController(IMediator mediator)
    //        => _mediator = mediator;

    //    public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10, CancellationToken ct = default)
    //    {
    //        var reservations = await _mediator.Send(new getallcitiesquery2() { Query = new(pageNumber, pageSize) }, ct);
    //        return View(reservations);
    //    }


    //    public async Task<IActionResult> Details(int id, CancellationToken ct)
    //    {
    //        var reservation = await _mediator.Send(new GetCityByIdQuery(id), ct);
    //        return View(reservation);
    //    }

    //    public IActionResult Create()
    //    {
    //        this.ViewData["Countries"] = _mediator.Send(new GetAllCountriesQuerywithoutpagination()).Result

    //        .Select(c => new SelectListItem() { Text = c.Name, Value = c.ID.ToString() })
    //       .ToList();
    //        return View();
    //    }


    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create(CityDetailsDto request, CancellationToken ct)
    //    {
    //        if (!ModelState.IsValid)
    //            return View(request);

    //        var newReservation = await _mediator.Send(new addcitycommand2 { Dto = request }, ct);
    //        return RedirectToAction(nameof(Details), new { id = newReservation.ID });
    //    }





    //    public async Task<IActionResult> Edit(int id, CancellationToken ct)
    //    {
    //        this.ViewData["Countries"] = _mediator.Send(new GetAllCountriesQuerywithoutpagination()).Result

    //       .Select(c => new SelectListItem() { Text = c.Name, Value = c.ID.ToString() })
    //      .ToList();
    //        var reservations = await _mediator.Send(new GetCityByIdQuery(id), ct);
    //        return View(reservations);
    //    }




    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(CityDetailsDto request, CancellationToken ct)
    //    {
    //        if (!ModelState.IsValid)
    //            return View(request);

    //        await _mediator.Send(new updatecitycommand2 { Dto = request }, ct);
    //        return RedirectToAction(nameof(Details), new { id = request.ID });
    //    }



    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Delete(int id, CancellationToken ct)
    //    {
    //        await _mediator.Send(new DeleteCityCommand(id), ct);
    //        return RedirectToAction(nameof(Index));
    //    }

    }
>>>>>>> almostdone
=======
}
>>>>>>> DeleteComments
