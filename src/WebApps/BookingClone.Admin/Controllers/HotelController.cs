using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Data;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;


namespace BookingClone.Admin.Controllers;
public class HotelController : Controller
{
    BookingDbContext _bookingDbContext = new BookingDbContext();
    //public IActionResult Index()
    //{
    //    return View();
    //}

    public IActionResult GetHotel()
    {

        var hotel = _bookingDbContext.Hotels.ToList();
        return View("GetHotel", hotel);
    }


    public IActionResult CreateHotel()
    {

        return View();
    }
    [HttpPost]
    public IActionResult CreateHotel(Hotel hotel)
    {

        _bookingDbContext.Add(hotel);
        _bookingDbContext.SaveChanges();

        return RedirectToAction("GetHotel");
    }


    public IActionResult UpdateHotel()
    {
        return View();
    }

    [HttpPost]

    public IActionResult UpdateHotel(Hotel hotel)
    {

        _bookingDbContext.Update(hotel);
        _bookingDbContext.SaveChanges();

        return RedirectToAction("GetHotel");
    }


    public IActionResult DeleteHotel()
    {
        return View();
    }

    [HttpPost]
    public IActionResult DeleteCategory(int id)
    {
        
        var DeletedHotel = _bookingDbContext.Hotels.Find(id);
        _bookingDbContext.Hotels.Remove(DeletedHotel);
        _bookingDbContext.SaveChanges();

        return RedirectToAction("GetHotel");
    }

}
