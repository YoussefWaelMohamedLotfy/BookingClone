using System.Diagnostics;

using BookingClone.Admin.Models;

using Microsoft.AspNetCore.Mvc;

namespace BookingClone.Admin.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
