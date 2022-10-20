using evtol_RideShare.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace evtol_RideShare.Controllers
{
    public class PilotController : Controller
    {
        // GET: PilotController
        public ActionResult Index()
        {
            List<Pilot> pilot = new List<Pilot>();
            return View(pilot);
        }

        // GET: PilotController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PilotController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PilotController/Create
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

        // GET: PilotController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PilotController/Edit/5
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

        // GET: PilotController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PilotController/Delete/5
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
