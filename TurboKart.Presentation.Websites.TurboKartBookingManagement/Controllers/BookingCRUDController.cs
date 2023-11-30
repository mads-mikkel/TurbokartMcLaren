using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TurboKart.Presentation.Websites.TurboKartBookingManagement.Controllers
{
    public class BookingCRUDController : Controller
    {
        // GET: BookingCRUDController
        public ActionResult Index()
        {
            return View();
        }

        // GET: BookingCRUDController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: BookingCRUDController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: BookingCRUDController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingCRUDController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: BookingCRUDController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: BookingCRUDController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: BookingCRUDController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
