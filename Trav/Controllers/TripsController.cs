using System.Linq;
using System.Net;
using System.Web.Mvc;
using Trav.DataAccess;
using Trav.Domain.Trips;
using Trav.Web.Resolvers;
using Trav.Web.Services;

namespace Trav.Web.Controllers
{
    public class TripsController : Controller
    {
        private readonly TravContext _db = new TravContext();

        // GET: Trips
        public ActionResult Index(string sortOrder)
        {
            var trips = new TripsService(
                new TripsRepositoryResolver().Resolve())
                .GetTrips(sortOrder);

            return View(trips);
        }

        // GET: Trips/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //var trip = _db.Trips.Find(id);
            //if (trip == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(trip);
            return View();
        }

        // GET: Trips/Create
        public ActionResult Create()
        {
            ViewBag.CountryId = new SelectList(_db.Countries.OrderBy(x => x.Name), "Id", "Name");
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
                //_db.Trips.Add(trip);
                //_db.SaveChanges();

                CheckIfAlreadyVisited(trip.CountryId);

                return RedirectToAction("Index");
            }

            //ViewBag.CountryId = new SelectList(_db.Countries.OrderBy(x => x.Name), "Id", "Name", trip.CountryId);
            //return View(trip);
            return View();
        }

        private void CheckIfAlreadyVisited(int countryId)
        {
            //var country = _db.Countries.Find(countryId);

            //if (country != null && !country.Visited)
            //{
            //    country.Visited = true;
            //    _db.Entry(country).State = EntityState.Modified;
            //    _db.SaveChanges();
            //}
        }

        // GET: Trips/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //var trip = _db.Trips.Find(id);
            //if (trip == null)
            //{
            //    return HttpNotFound();
            //}
            //ViewBag.CountryId = new SelectList(_db.Countries.OrderBy(x => x.Name), "Id", "Name", trip.CountryId);
            //return View(trip);
            return View();
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
                //_db.Entry(trip).State = EntityState.Modified;
                //_db.SaveChanges();
                //return RedirectToAction("Index");
            }
            ViewBag.CountryId = new SelectList(_db.Countries.OrderBy(x => x.Name), "Id", "Name", trip.CountryId);
            //return View(trip);
            return View();
        }

        // GET: Trips/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            //var trip = _db.Trips.Find(id);
            //if (trip == null)
            //{
            //    return HttpNotFound();
            //}
            //return View(trip);
            return View();
        }

        // POST: Trips/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            //var trip = _db.Trips.Find(id);
            //if (trip != null)
            //{
            //    _db.Trips.Remove(trip);
            //    _db.SaveChanges();
            //}
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                //_db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
