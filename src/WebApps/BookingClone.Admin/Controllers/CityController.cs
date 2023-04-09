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
<<<<<<< HEAD
<<<<<<< HEAD
<<<<<<< HEAD
using BookingClone.Application.Features.country.queries.GitAllCountries;
<<<<<<< HEAD
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
=======
using BookingClone.Application.Features.continent.queries.GetAllcontinent;
<<<<<<< HEAD
>>>>>>> test1
=======
using BookingClone.Application.Features.RoomReservationFeatures.Commands.AddRoomReservation;
using BookingClone.Application.Features.RoomReservationFeatures.Commands.DeleteRoomReservation;
using BookingClone.Application.Features.RoomReservationFeatures.Commands.UpdateRoomReservation;
using BookingClone.Application.Features.RoomReservationFeatures.DTOs;
>>>>>>> test2
using BookingClone.Application.Features.RoomReservationFeatures.Queries.GetAllRoomReservations;
using BookingClone.Application.Features.RoomReservationFeatures.Queries.GetRoomReservationById;
=======
>>>>>>> countryview
=======
using BookingClone.Application.Features.country.queries.GitAllCountries;
>>>>>>> continent2
using BookingClone.Domain.Entities;
>>>>>>> salmateest
using BookingClone.Infrastructure.Data;
=======
>>>>>>> country,continent,city

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
<<<<<<< HEAD
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
=======
        var reservations = await _mediator.Send(new getallcitiesquery2() { Query = new(pageNumber, pageSize) }, ct);
>>>>>>> test1
        return View(reservations);
>>>>>>> salmateest
    }


    public async Task<IActionResult> Details(int id, CancellationToken ct)
    {
<<<<<<< HEAD
<<<<<<< HEAD
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
=======
        var reservation = await _mediator.Send(new GetCityBYCountryIdquery(id), ct);
>>>>>>> new action getcitybycountryid
=======
        var reservation = await _mediator.Send(new GetCityByIdQuery(id), ct);
>>>>>>> solve_error_in_create_city
        return View(reservation);
>>>>>>> salmateest
    }

    public IActionResult Create()
    {
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
        var reservations = await _mediator.Send(new GetCityBYCountryIdquery (id ), ct);
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


<<<<<<< HEAD




<<<<<<< HEAD
>>>>>>> city view
=======

    //private readonly IMediator _mediator;

    //public RoomReservationsController(IMediator mediator)
    //    => _mediator = mediator;

    //public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10, CancellationToken ct = default)
    //{
    //    var reservations = await _mediator.Send(new GetAllRoomReservationsQuery() { Query = new(pageNumber, pageSize) }, ct);
    //    return View(reservations);
    //}

    //public async Task<IActionResult> Details(int id, CancellationToken ct)
    //{
    //    var reservation = await _mediator.Send(new GetRoomReservationByIdQuery { ID = id }, ct);
    //    return View(reservation);
    //}

    //public IActionResult Create()
    //    => View();

    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Create(AddRoomReservationDto request, CancellationToken ct)
    //{
    //    if (!ModelState.IsValid)
    //        return View(request);

    //    var newReservation = await _mediator.Send(new AddRoomReservationCommand { Dto = request }, ct);
    //    return RedirectToAction(nameof(Details), new { id = newReservation.ID });
    //}

    //public async Task<IActionResult> Edit(int id, CancellationToken ct)
    //{
    //    var reservations = await _mediator.Send(new GetRoomReservationByIdQuery { ID = id }, ct);
    //    return View(reservations);
    //}

    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Edit(UpdateRoomReservationDto request, CancellationToken ct)
    //{
    //    if (!ModelState.IsValid)
    //        return View(request);

    //    await _mediator.Send(new UpdateRoomReservationCommand { Dto = request }, ct);
    //    return RedirectToAction(nameof(Details), new { id = request.ID });
    //}

    //[HttpPost]
    //[ValidateAntiForgeryToken]
    //public async Task<IActionResult> Delete(int id, CancellationToken ct)
    //{
    //    await _mediator.Send(new DeleteRoomReservationCommand { ID = id }, ct);
    //    return RedirectToAction(nameof(Index));
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
=======
>>>>>>> countryview
}
