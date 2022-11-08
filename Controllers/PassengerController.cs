using evtol_RideShare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace evtol_RideShare.Controllers
{
    public class PassengerController : Controller
    {
        // GET: PassengerController
        public ActionResult Index()
        {
            List<Passenger> passenger = new List<Passenger>();
            return View(passenger);

        }

        // GET: PassengerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PassengerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PassengerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection, Passenger passenger)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View(passenger);
            }
        }

        // GET: PassengerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PassengerController/Edit/5
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

        // GET: PassengerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PassengerController/Delete/5
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
