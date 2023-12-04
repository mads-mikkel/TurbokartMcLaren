using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TurboKart.Presentation.Websites.TurboKartBookingManagement.Models.BookingCRUD;

namespace TurboKart.Presentation.Websites.TurboKartBookingManagement.Controllers
{
    public class BookingCRUDController : Controller
    {
        // Mock Data
        private static Dictionary<int, MockBooking> mockBookings = new()
        {
            { 1, new(1, "Alvira Sallan", "asallan0@state.gov", "160-579-1994", GrandprixType.Enkelt_Grandprix, 6, DateOnly.Parse("01/01/2023"), TimeOnly.Parse("1:02:35")) },
            { 2, new(2, "Julie La Wille", "jla1@slideshare.net", "344-425-7168", GrandprixType.Enkelt_Grandprix, 9, DateOnly.Parse("07/05/2023"), TimeOnly.Parse("21:35:27")) },
            { 3, new(3, "Guss Froom", "gfroom2@nymag.com", "729-201-2836", GrandprixType.Enkelt_Grandprix, 20, DateOnly.Parse("16/09/2023"), TimeOnly.Parse("17:44:11")) },
            { 4, new(4, "Marcia Grisenthwaite", "mgrisenthwaite3@narod.ru", "458-138-1921", GrandprixType.Dobbelt_Grandprix, 8, DateOnly.Parse("20/04/2023"), TimeOnly.Parse("15:32:23")) },
            { 5, new(5, "Joete Leech", "jleech4@un.org", "800-966-4056", GrandprixType.Dobbelt_Grandprix, 4, DateOnly.Parse("26/04/2023"), TimeOnly.Parse("21:51:54")) },
            { 6, new(6, "Lev Gradley", "lgradley5@facebook.com", "522-569-1452", GrandprixType.Dobbelt_Grandprix, 13, DateOnly.Parse("13/03/2023"), TimeOnly.Parse("20:30:42")) },
            { 7, new(7, "Winona Janik", "wjanik6@cmu.edu", "926-650-0355", GrandprixType.Enkelt_Grandprix, 19, DateOnly.Parse("24/10/2023"), TimeOnly.Parse("22:01:06")) },
            { 8, new(8, "Sara Self", "sself7@artisteer.com", "941-644-7497", GrandprixType.Dobbelt_Grandprix, 10, DateOnly.Parse("16/06/2023"), TimeOnly.Parse("18:40:50")) },
            { 9, new(9, "Hughie Tassell", "htassell8@toplist.cz", "762-972-5293", GrandprixType.Enkelt_Grandprix, 11, DateOnly.Parse("02/09/2023"), TimeOnly.Parse("13:00:25")) },
            { 10, new(10, "Cole Juara", "cjuara9@typepad.com", "620-222-5691", GrandprixType.Enkelt_Grandprix, 10, DateOnly.Parse("24/05/2023"), TimeOnly.Parse("4:50:32")) }
        };

        private int nextId = 11;
        private int NextId
        {
            get
            {
                var tmp = nextId;
                nextId++;
                return tmp;
            }
        }
        // GET: BookingCRUDController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BookingCRUDController/Details/5
        public ActionResult Details(int id)
        {
            // TODO: Need to get the booking from api

            var booking = mockBookings[id];
            DetailsViewModel mock = new()
            {
                PrimaryKey = booking.PrimaryKey,
                CustomerName = booking.CustomerName,
                CustomerEmail = booking.CustomerEmail,
                CustomerPhone = booking.CustomerPhone,
                GrandprixType = booking.GrandprixType,
                DriverCount = booking.DriverCount,
                Date = booking.Date,
                Time = booking.Time,
            };
            return View(mock);
        }

        // GET: BookingCRUDController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingCRUDController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(CreateViewModel createViewModel)
        {
            if (!ModelState.IsValid)
                return View(createViewModel);

            // TODO: Upload data to api
            var id = NextId;
            mockBookings.Add(id, new(
                id,
                createViewModel.CustomerName,
                createViewModel.CustomerEmail,
                createViewModel.CustomerPhone,
                createViewModel.GrandprixType,
                createViewModel.DriverCount,
                createViewModel.Date,
                createViewModel.Time
            ));
            return RedirectToAction("Details", new { id });
        }

        // GET: BookingCRUDController/Edit/5
        public ActionResult Edit(int id)
        {
            // TODO: Need to get the booking from api

            var booking = mockBookings[id];
            EditViewModel mock = new()
            {
                PrimaryKey = booking.PrimaryKey,
                CustomerName = booking.CustomerName,
                CustomerEmail = booking.CustomerEmail,
                CustomerPhone = booking.CustomerPhone,
                GrandprixType = booking.GrandprixType,
                DriverCount = booking.DriverCount,
                DateTime = booking.Date.ToDateTime(booking.Time),
            };
            return View(mock);
        }

        // POST: BookingCRUDController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(EditViewModel editViewModel)
        {
            if (!ModelState.IsValid)
                return View(editViewModel);

            // TODO: Save edited data with api
            var id = editViewModel.PrimaryKey;
            var mock = mockBookings[id];
            mock.CustomerName = editViewModel.CustomerName;
            mock.CustomerEmail = editViewModel.CustomerEmail;
            mock.CustomerPhone = editViewModel.CustomerPhone;
            mock.GrandprixType = editViewModel.GrandprixType;
            mock.DriverCount = editViewModel.DriverCount;
            mock.Date = editViewModel.Date;
            mock.Time = editViewModel.Time;
            mockBookings[id] = mock;
            return RedirectToAction("Details", new { id });
        }

        // GET: BookingCRUDController/Delete/5
        public ActionResult Delete(int id)
        {
            var mock = mockBookings[id];
            DeleteViewModel data = new()
            {
                PrimaryKey = id,
                CustomerName = mock.CustomerName,
                CustomerEmail = mock.CustomerEmail,
                CustomerPhone = mock.CustomerPhone,
                DriverCount = mock.DriverCount,
                Date = mock.Date,
                Time = mock.Time,
                GrandprixType = mock.GrandprixType,
            };
            return View(data);
        }

        // POST: BookingCRUDController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            mockBookings.Remove(id);
            return RedirectToAction(nameof(Index));
        }
    }
}
