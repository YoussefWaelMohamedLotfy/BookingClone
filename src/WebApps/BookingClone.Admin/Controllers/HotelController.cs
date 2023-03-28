using BookingClone.Application.Features.HotelFeatures.AddHotel;
using BookingClone.Application.Features.HotelFeatures.DeleteHotel;
using BookingClone.Application.Features.HotelFeatures.DTOs;
using BookingClone.Application.Features.HotelFeatures.Queries.GetAll;
using BookingClone.Application.Features.HotelFeatures.Queries.GetById;
using BookingClone.Application.Features.HotelFeatures.UpdateHotel;


using MediatR;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BookingClone.Admin.Controllers;
public class HotelController : Controller
{
    private readonly IMediator _mediator;


    public HotelController(IMediator mediator)
       => _mediator = mediator;

    public async Task<IActionResult> Index(CancellationToken ct)
    {
        var hotel = await _mediator.Send(new GetAllQuery (), ct);
        return View(hotel);
    }


    public async Task<IActionResult> Details(int id, CancellationToken ct)
    {
        var hotel = await _mediator.Send(new GetByIdQuery { ID = id }, ct);
        return View(hotel);
    }

    public IActionResult Create()
        => View();

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create(AddHotelDto request, CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return View(request);

        var newHotel = await _mediator.Send(new AddHotelCommand { Dto = request }, ct);
        return RedirectToAction(nameof(Details), new { id = newHotel.Id });
    }



    public async Task<IActionResult> Edit(int id, CancellationToken ct)
    {
        var hotel = await _mediator.Send(new GetByIdQuery { ID = id }, ct);
        return View(hotel);
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Edit(UpdateHotelDto request, CancellationToken ct)
    {
        if (!ModelState.IsValid)
            return View(request);

        await _mediator.Send(new UpdateHotelCommand { Dto = request }, ct);
        return RedirectToAction(nameof(Details), new { id = request.Id });
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Delete(int id, CancellationToken ct)
    {
        await _mediator.Send(new DeleteHotelCommand { Id = id }, ct);
        return RedirectToAction(nameof(Index));
    }














    //BookingDbContext _bookingDbContext = new BookingDbContext();
    ////public IActionResult Index()
    ////{
    ////    return View();
    ////}

    //public IActionResult GetHotel()
    //{

    //    var hotel = _bookingDbContext.Hotels.ToList();
    //    return View("GetHotel", hotel);
    //}


    //public IActionResult CreateHotel()
    //{

    //    return View();
    //}
    //[HttpPost]
    //public IActionResult CreateHotel(Hotel hotel)
    //{

    //    _bookingDbContext.Add(hotel);
    //    _bookingDbContext.SaveChanges();

    //    return RedirectToAction("GetHotel");
    //}


    //public IActionResult UpdateHotel()
    //{
    //    return View();
    //}

    //[HttpPost]

    //public IActionResult UpdateHotel(Hotel hotel)
    //{

    //    _bookingDbContext.Update(hotel);
    //    _bookingDbContext.SaveChanges();

    //    return RedirectToAction("GetHotel");
    //}


    //public IActionResult DeleteHotel()
    //{
    //    return View();
    //}

    //[HttpPost]
    //public IActionResult DeleteCategory(int id)
    //{

    //    var DeletedHotel = _bookingDbContext.Hotels.Find(id);
    //    _bookingDbContext.Hotels.Remove(DeletedHotel);
    //    _bookingDbContext.SaveChanges();

    //    return RedirectToAction("GetHotel");
    //}

}
