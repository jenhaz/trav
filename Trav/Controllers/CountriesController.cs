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

        public ActionResult Index()
        {
            var countries = _countriesService.GetAll();

            return View(countries.OrderBy(x => x.Name));
        }

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

        public ActionResult Create()
        {
            return View();
        }

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
