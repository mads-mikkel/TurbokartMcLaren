using Microsoft.AspNetCore.Mvc;
using TurboKart.Application.Interfaces;
using TurboKart.Domain.Entities;
using TurboKart.Presentation.Websites.TurboKartBookingManagement.Models;

namespace TurboKart.Presentation.Websites.TurboKartBookingManagement.Controllers
{
	public class AdminController : Controller
	{

		private readonly IBookingUseCase bookingUseCase;

		public AdminController(IBookingUseCase bookingUseCase)
		{
			this.bookingUseCase = bookingUseCase;
		}

		// TurboKart Booking Mangement 5, 6 and 7
		public IActionResult Index()
		{
			return View();
		}

		// TurboKart Booking Mangement 8
		public IActionResult Login()
		{
			return View();
		}

		[HttpPost]
		[ActionName("Login")]
		public IActionResult LoginVerify(LoginViewModel loginViewModel)
		{
			if (ModelState.IsValid)
			{
				if (loginViewModel.Username.ToLower() == "test" && loginViewModel.Password == "test")
				{
					return RedirectToAction("Index", "Admin");
				}
			}

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

		[HttpPost]
		[ActionName("NewBooking")]
		public IActionResult NewBooking(NewBookingViewModel newBookingViewModel)
		{
			if (ModelState.IsValid)
			{
				// Create new customer Object to add to Database
				Customer customer = new Customer
				{
					Name = newBookingViewModel.Name,
					CustomerId = 0,
					Bookings = null
				};

				// Create new Booking Object to add to Database
				Booking booking = new Booking
				{
					// Convert DateOnly and TimeOnly to DateTime
					Start = newBookingViewModel.Date.ToDateTime(newBookingViewModel.Time),
					Customer = customer,
					CustomerId = 0,
				};

				bookingUseCase.BookNew(booking);

				// Redirect after Creating new booking
				return RedirectToAction("Index", "Admin");
			}

			return View();
		}

	}
}
