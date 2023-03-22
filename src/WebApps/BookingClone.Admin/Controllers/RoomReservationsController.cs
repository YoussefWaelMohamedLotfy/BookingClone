using Microsoft.AspNetCore.Mvc;

namespace BookingClone.Admin.Controllers;

public class RoomReservationsController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
