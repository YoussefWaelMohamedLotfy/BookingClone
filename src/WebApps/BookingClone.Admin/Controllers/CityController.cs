<<<<<<< HEAD
<<<<<<< HEAD
﻿using BookingClone.Application.Features.city.commands.AddCity;
=======
﻿using Bogus.DataSets;
using BookingClone.Application.Features.city.commands.AddCity;
>>>>>>> salmateest
using BookingClone.Application.Features.city.commands.DeleteCity;
using BookingClone.Application.Features.city.commands.UpdateCity;
using BookingClone.Application.Features.city.DTOs;
using BookingClone.Application.Features.city.queries.GetAllCities;
using BookingClone.Application.Features.city.queries.GetCityById;
<<<<<<< HEAD
using BookingClone.Application.Features.country.queries.GitAllCountries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookingClone.Admin.Controllers;

[Authorize]
public sealed class CityController : Controller
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
=======
﻿using BookingClone.Domain.Entities;
=======
using BookingClone.Application.Features.RoomReservationFeatures.Queries.GetAllRoomReservations;
using BookingClone.Domain.Entities;
>>>>>>> salmateest
using BookingClone.Infrastructure.Data;

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace BookingClone.Admin.Controllers;
public class CityController : Controller
{
    private readonly IMediator _mediator;

    public CityController(IMediator mediator)
        => _mediator = mediator;

    public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10, CancellationToken ct = default)
    {
<<<<<<< HEAD
<<<<<<< HEAD

        var Cities = context.Cities;
        ViewBag.Citiess = Cities;
        return View();
>>>>>>> city view
=======
        var reservations = await _mediator.Send(new getallcitiesquery2() { Query = new(pageNumber, pageSize) }, ct);
=======
        var reservations =  await _mediator.Send(new GetAllCitiesQuery(), ct);
>>>>>>> city handler
        return View(reservations);
>>>>>>> salmateest
    }

    public async Task<IActionResult> Details(int id, CancellationToken ct)
    {
<<<<<<< HEAD
<<<<<<< HEAD
        this.ViewData["Countries"] =  _mediator.Send(new GetAllCountriesQuerywithoutpagination()).Result
        
        .Select(c => new SelectListItem() { Text = c.Name, Value = c.ID.ToString() })
       .ToList();
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
        this.ViewData["Countries"] = _mediator.Send(new GetAllCountriesQuerywithoutpagination()).Result

       .Select(c => new SelectListItem() { Text = c.Name, Value = c.ID.ToString() })
      .ToList();
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


=======

        return View();
=======
        var reservation = await _mediator.Send(new GetCityByIdQuery(id), ct);
        return View(reservation);
>>>>>>> salmateest
    }

    public IActionResult Create()
        => View();

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
    public async Task<IActionResult> Edit(updatecityDto2 request, CancellationToken ct)
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






<<<<<<< HEAD
>>>>>>> city view
=======

    //    private readonly IMediator _mediator;

    //    public AttractionReservationsController(IMediator mediator)
    //        => _mediator = mediator;

    //    public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10, CancellationToken ct = default)
    //    {
    //        var reservations = await _mediator.Send(new GetAllAttractionReservationsQuery() { Query = new(pageNumber, pageSize) }, ct);
    //        return View(reservations);
    //    }

    //    public async Task<IActionResult> Details(int id, CancellationToken ct)
    //    {
    //        var reservation = await _mediator.Send(new GetAttractionReservationByIdQuery { ID = id }, ct);
    //        return View(reservation);
    //    }

    //    public IActionResult Create()
    //        => View();

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Create(AddAttractionReservationDto request, CancellationToken ct)
    //    {
    //        if (!ModelState.IsValid)
    //            return View(request);

    //        var newReservation = await _mediator.Send(new AddAttractionReservationCommand { Dto = request }, ct);
    //        return RedirectToAction(nameof(Details), new { id = newReservation.ID });
    //    }

    //    public async Task<IActionResult> Edit(int id, CancellationToken ct)
    //    {
    //        var reservations = await _mediator.Send(new GetAttractionReservationByIdQuery { ID = id }, ct);
    //        return View(reservations);
    //    }

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Edit(UpdateAttractionReservationDto request, CancellationToken ct)
    //    {
    //        if (!ModelState.IsValid)
    //            return View(request);

    //        await _mediator.Send(new UpdateAttractionReservationCommand { Dto = request }, ct);
    //        return RedirectToAction(nameof(Details), new { id = request.ID });
    //    }

    //    [HttpPost]
    //    [ValidateAntiForgeryToken]
    //    public async Task<IActionResult> Delete(int id, CancellationToken ct)
    //    {
    //        await _mediator.Send(new DeleteAttractionReservationCommand { ID = id }, ct);
    //        return RedirectToAction(nameof(Index));
    //    }
    //}








    //BookingDbContext context = new BookingDbContext();
    //////public IActionResult Index()
    //////{
    //////    return View();
    //////}

    //public IActionResult Get_Cities()
    //{

    //    var Cities = context.Cities;
    //    ViewBag.Citiess = Cities;
    //    return View();
    //}

    //public IActionResult Create()
    //{

    //    return View();
    //}

    //[HttpPost]
    //public IActionResult Create(Cities cities)
    //{

    //    context.Add(cities);
    //    context.SaveChanges();
    //    return View();
    //}

    //public IActionResult Edit()
    //{
    //    return View();
    //}

    //[HttpPost]
    //public IActionResult Edit(Cities cities)
    //{
    //    context.Update(cities);
    //    context.SaveChanges();
    //    return View();
    //}


    //public IActionResult Delete()
    //{
    //    return View();
    //}

    //[HttpPost]
    //public IActionResult Delete(long id)
    //{
    //    var Deleted = context.Cities.Find(id);
    //    context.Cities.Remove(Deleted);
    //    context.SaveChanges();
    //    return View();
    //}






>>>>>>> salmateest
}
