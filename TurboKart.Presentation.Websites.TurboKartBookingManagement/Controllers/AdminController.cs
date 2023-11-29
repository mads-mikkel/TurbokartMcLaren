using Microsoft.AspNetCore.Mvc;

namespace TurboKart.Presentation.Websites.TurboKartBookingManagement.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LogIn()
        {
            return View();
        }
    }
}
