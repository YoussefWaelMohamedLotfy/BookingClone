using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Data;

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
        var hotel = await _mediator.Send(new  (), ct);
        return View(hotel);
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
