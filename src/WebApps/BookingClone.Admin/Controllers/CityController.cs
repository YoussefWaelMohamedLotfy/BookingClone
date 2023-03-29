using BookingClone.Domain.Entities;
using BookingClone.Infrastructure.Data;

using Microsoft.AspNetCore.Mvc;

namespace BookingClone.Admin.Controllers;
public class CityController : Controller
{
    public IActionResult Index()
    {
        return View();
    }


    BookingDbContext context = new BookingDbContext();
    ////public IActionResult Index()
    ////{
    ////    return View();
    ////}

    public IActionResult Get_Cities()
    {

        var Cities = context.Cities;
        ViewBag.Citiess = Cities;
        return View();
    }

    public IActionResult Create()
    {

        return View();
    }

    [HttpPost]
    public IActionResult Create(Cities cities)
    {

        context.Add(cities);
        context.SaveChanges();
        return View();
    }

    public IActionResult Edit()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Edit(Cities cities)
    {
        context.Update(cities);
        context.SaveChanges();
        return View();
    }


    public IActionResult Delete()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Delete(long id)
    {
        var Deleted = context.Cities.Find(id);
        context.Cities.Remove(Deleted);
        context.SaveChanges();
        return View();
    }






}
