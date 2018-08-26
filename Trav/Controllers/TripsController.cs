using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Globalization;
using System.Linq;
using System.Net;
using System.Web.Mvc;
using Trav.DAL;
using Trav.Models;

namespace Trav.Controllers
{
    public class TripsController : Controller
    {
        private TravContext db = new TravContext();

        // GET: Trips
        public ActionResult Index(string sortOrder)
        {
            List<Trip> tripsList = db.Trips.Include(t => t.Country).ToList();
            IEnumerable<TripViewModel> tripsVm = tripsList.Select(x => GetTripVm(x));
            IEnumerable<TripViewModel> trips = tripsVm;

            sortOrder = !string.IsNullOrEmpty(sortOrder) ? sortOrder : "year";

            switch (sortOrder)
            {
                case "country":
                    trips = tripsVm.OrderBy(y => y.Country);
                    break;
                case "city":
                    trips = tripsVm.OrderBy(y => y.City);
                    break;
                case "year":
                    trips = tripsVm.OrderBy(y => y.EndDate);
                    break;
                case "startdate":
                    trips = tripsVm.OrderBy(y => y.StartDate);
                    break;
                case "enddate":
                    trips = tripsVm.OrderBy(y => y.EndDate);
                    break;
                default:
                    trips = tripsVm.OrderBy(y => y.EndDate);
                    break;
            }

            return View(trips);
        }

        public TripViewModel GetTripVm(Trip trip)
        {
            DateTime startDate;
            DateTime endDate;

            return new TripViewModel
            {
                TripId = trip.TripId,
                Year = DateTime.TryParseExact(trip.EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate)
                    ? endDate.Year
                    : 1901,
                City = trip.City,
                Country = trip.Country.Name,
                StartDate = DateTime.TryParseExact(trip.StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out startDate)
                    ? startDate
                    : new DateTime(),
                EndDate = DateTime.TryParseExact(trip.EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate)
                    ? endDate
                    : new DateTime()
            };
        }

        // GET: Trips/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip trip = db.Trips.Find(id);
            if (trip == null)
            {
                return HttpNotFound();
            }
            return View(trip);
        }

        // GET: Trips/Create
        public ActionResult Create()
        {
            ViewBag.CountryId = new SelectList(db.Countries.OrderBy(x => x.Name), "Id", "Name");
            return View();
        }

        // POST: Trips/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "TripId,CountryId,City,StartDate,EndDate")] Trip trip)
        {
            if (ModelState.IsValid)
            {
                db.Trips.Add(trip);
                db.SaveChanges();

                CheckIfAlreadyVisited(trip.CountryId);

                return RedirectToAction("Index");
            }

            ViewBag.CountryId = new SelectList(db.Countries.OrderBy(x => x.Name), "Id", "Name", trip.CountryId);
            return View(trip);
        }

        private void CheckIfAlreadyVisited(int countryId)
        {
            Country country = db.Countries.Find(countryId);

            if (!country.Visited)
            {
                country.Visited = true;
                db.Entry(country).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        // GET: Trips/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip trip = db.Trips.Find(id);
            if (trip == null)
            {
                return HttpNotFound();
            }
            ViewBag.CountryId = new SelectList(db.Countries.OrderBy(x => x.Name), "Id", "Name", trip.CountryId);
            return View(trip);
        }

        // POST: Trips/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "TripId,CountryId,City,StartDate,EndDate")] Trip trip)
        {
            if (ModelState.IsValid)
            {
                db.Entry(trip).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.CountryId = new SelectList(db.Countries.OrderBy(x => x.Name), "Id", "Name", trip.CountryId);
            return View(trip);
        }

        // GET: Trips/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Trip trip = db.Trips.Find(id);
            if (trip == null)
            {
                return HttpNotFound();
            }
            return View(trip);
        }

        // POST: Trips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Trip trip = db.Trips.Find(id);
            db.Trips.Remove(trip);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
