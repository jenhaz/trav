using System.Linq;
using System.Net;
using System.Web.Mvc;
using Trav.Web.Models;
using Trav.Web.Services;

namespace Trav.Web.Controllers
{
    public class TripsController : Controller
    {
        private readonly ITripsService _tripsService;
        private readonly ICountriesService _countriesService;

        public TripsController(
            ITripsService tripsService, 
            ICountriesService countriesService)
        {
            _tripsService = tripsService;
            _countriesService = countriesService;
        }

        public ActionResult Index(string sortOrder)
        {
            var trips = _tripsService.GetTrips(sortOrder);

            return View(trips);
        }

        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var trip = _tripsService.For(id.Value);

            if (trip == null)
            {
                return HttpNotFound();
            }
            return View(trip);
        }

        public ActionResult Create()
        {
            var countries = _countriesService.GetAll().OrderBy(x => x.Name);
            ViewBag.CountryId = new SelectList(countries, "Id", "Name");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TripId,CountryId,City,StartDate,EndDate")] TripViewModel trip)
        {
            if (ModelState.IsValid)
            {
                _tripsService.Insert(trip);
                CheckIfAlreadyVisited(trip.CountryId);
                return RedirectToAction("Index");
            }

            var countries = _countriesService.GetAll().OrderBy(x => x.Name);
            ViewBag.CountryId = new SelectList(countries, "Id", "Name", trip.CountryId);

            return View(trip);
        }
        
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var trip = _tripsService.For(id.Value);
            if (trip == null)
            {
                return HttpNotFound();
            }

            var countries = _countriesService.GetAll().OrderBy(x => x.Name);
            ViewBag.CountryId = new SelectList(countries, "Id", "Name", trip.Country);

            return View(trip);
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TripId,CountryId,City,StartDate,EndDate")] TripViewModel trip)
        {
            if (ModelState.IsValid)
            {
                _tripsService.Edit(trip);
                return RedirectToAction("Index");
            }

            var countries = _countriesService.GetAll().OrderBy(x => x.Name);
            ViewBag.CountryId = new SelectList(countries, "Id", "Name", trip.CountryId);

            return View(trip);
        }

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var trip = _tripsService.For(id.Value);

            if (trip == null)
            {
                return HttpNotFound();
            }

            return View(trip);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var trip = _tripsService.For(id);
            if (trip != null)
            {
                _tripsService.Delete(trip);
            }

            return RedirectToAction("Index");
        }

        private void CheckIfAlreadyVisited(int countryId)
        {
            var country = _countriesService.For(countryId);

            if (country != null && !country.Visited)
            {
                country.Visited = true;
                _countriesService.Edit(country);
            }
        }
    }
}
