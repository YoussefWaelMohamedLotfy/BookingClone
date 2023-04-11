using System.Diagnostics;

using BookingClone.Admin.Models;

using Microsoft.AspNetCore.Mvc;

namespace BookingClone.Admin.Controllers;
<<<<<<< HEAD
public sealed class HomeController : Controller
{
    public IActionResult Index() => View();
=======
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
>>>>>>> first commit

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
