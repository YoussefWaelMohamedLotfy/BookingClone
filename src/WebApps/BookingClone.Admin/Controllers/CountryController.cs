<<<<<<< HEAD
﻿using BookingClone.Application.Features.continent.queries.getAllContinentswithoutpagination;
=======
﻿
>>>>>>> salmateest
using BookingClone.Application.Features.country.commands.AddCountry;
using BookingClone.Application.Features.country.commands.DeleteCountry;
using BookingClone.Application.Features.country.commands.UpdateCountry;
using BookingClone.Application.Features.country.DTOs;
using BookingClone.Application.Features.country.queries.GitAllCountries;
using BookingClone.Application.Features.country.queries.GitCountryById;
<<<<<<< HEAD
<<<<<<< HEAD
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BookingClone.Admin.Controllers;

[Authorize]
public sealed class CountryController : Controller
=======
using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Data;
=======
>>>>>>> countryview

using MediatR;

using Microsoft.AspNetCore.Mvc;

namespace BookingClone.Admin.Controllers;
public class CountryController : Controller
>>>>>>> salmateest
{
    private readonly IMediator _mediator;

    public CountryController(IMediator mediator)
        => _mediator = mediator;

    public async Task<IActionResult> Index(int pageNumber = 1, int pageSize = 10, CancellationToken ct = default)
    {
        var reservations = await _mediator.Send(new getallcountryquery2() { Query = new(pageNumber, pageSize) }, ct);
        return View(reservations);
    }

    public async Task<IActionResult> Details(int id, CancellationToken ct)
    {
        var reservation = await _mediator.Send(new GetCountryByIdQuery(id), ct);
        return View(reservation);
    }

    public IActionResult Create()
<<<<<<< HEAD
    {
        this.ViewData["Continents"] = _mediator.Send(new GetAllContinentsQuerywithoutpagination()).Result

       .Select(c => new SelectListItem() { Text = c.Name, Value = c.ID.ToString() })
      .ToList();
        return View();
    }
       
=======
        => View();
>>>>>>> salmateest

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(CountryDetailsDto request, CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return View(request);

        var newReservation = await _mediator.Send(new addcountrycommand2 { Dto = request }, ct);
        return RedirectToAction(nameof(Details), new { id = newReservation.ID });
    }



    public async Task<IActionResult> Edit(int id, CancellationToken ct)
    {
<<<<<<< HEAD
        this.ViewData["Continents"] = _mediator.Send(new GetAllContinentsQuerywithoutpagination()).Result

      .Select(c => new SelectListItem() { Text = c.Name, Value = c.ID.ToString() })
      .ToList();

=======
>>>>>>> salmateest
        var reservations = await _mediator.Send(new GetCountryByIdQuery(id), ct);
        return View(reservations);
    }




    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(CountryDetailsDto request, CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return View(request);

        await _mediator.Send(new updatecountrycommand2 { Dto = request }, ct);
        return RedirectToAction(nameof(Details), new { id = request.ID });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id, CancellationToken ct)
    {
        await _mediator.Send(new DeleteCountryCommmand(id), ct);
        return RedirectToAction(nameof(Index));
    }

<<<<<<< HEAD
<<<<<<< HEAD
   
=======




    //BookingDbContext context = new BookingDbContext();
    ////public IActionResult Index()
    ////{
    ////    return View();
    ////}


    //public IActionResult Get_Country()
    //{

    //    var Country = context.Countries;
    //    ViewBag.countries = Country;
    //    return View();
    //}

    //public IActionResult Create()
    //{

    //    return View();
    //}

    //[HttpPost]
    //public IActionResult Create(Country country)
    //{

    //    context.Add(country);
    //    context.SaveChanges();
    //    return View();
    //}

    //public IActionResult Edit()
    //{
    //    return View();
    //}

    //[HttpPost]
    //public IActionResult Edit(Country country)
    //{
    //    context.Update(country);
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
    //    var Deleted = context.Countries.Find(id);
    //    context.Countries.Remove(Deleted);
    //    context.SaveChanges();
    //    return View();
    //}



>>>>>>> salmateest
=======
   
>>>>>>> countryview

}
