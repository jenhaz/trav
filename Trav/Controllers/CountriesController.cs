using System.Linq;
using System.Net;
using System.Web.Mvc;
using Trav.Domain.Countries;
using Trav.Web.Services;

namespace Trav.Web.Controllers
{
    public class CountriesController : Controller
    {
        private readonly ICountriesService _countriesService;

        public CountriesController(ICountriesService countriesService)
        {
            _countriesService = countriesService;
        }

        // GET: Countries
        public ActionResult Index()
        {
            var countries = _countriesService.GetAll();

            return View(countries.OrderBy(x => x.Name));
        }

        // GET: Countries/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var country = _countriesService.For(id.Value);

            if (country == null)
            {
                return HttpNotFound();
            }

            return View(country);
        }

        // GET: Countries/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Countries/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Code,Visited")] Country country)
        {
            if (ModelState.IsValid)
            {
                _countriesService.Insert(country);
                return RedirectToAction("Index");
            }

            return View(country);
        }

        // GET: Countries/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var country = _countriesService.For(id.Value);

            if (country == null)
            {
                return HttpNotFound();
            }

            return View(country);
        }

        // POST: Countries/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Code,Visited")] Country country)
        {
            if (ModelState.IsValid)
            {
                _countriesService.Edit(country);
                return RedirectToAction("Index");
            }
            return View(country);
        }

        // GET: Countries/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var country = _countriesService.For(id.Value);

            if (country == null)
            {
                return HttpNotFound();
            }

            return View(country);
        }

        // POST: Countries/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            var country = _countriesService.For(id);

            if (country != null)
            {
                _countriesService.Delete(country);
            }

            return RedirectToAction("Index");
        }
    }
}
