using Microsoft.AspNetCore.Mvc;

namespace TurboKart.Presentation.Websites.TurboKartBookingManagement.Controllers
{
    public class AdminController : Controller
    {
        // TurboKart Booking Mangement 5, 6 and 7
        public IActionResult Index()
        {
            return View();
        }

        // TurboKart Booking Mangement 8
        public IActionResult LogIn()
        {
            return View();
        }

        // TurboKart Booking Mangement 2, 3, and 4
        public IActionResult Booking()
        {
            return View();
        }

        // TurboKart Booking Mangement  1
        public IActionResult NewBooking()
        {
            return View();
        }


    }
}
