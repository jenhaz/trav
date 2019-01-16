using System.Linq;
using System.Web.Mvc;
using Trav.DAL;
using Trav.Models;

namespace Trav.Controllers
{
    public class HomeController : Controller
    {
        private readonly TravContext _db;

        public HomeController(TravContext db)
        {
            _db = db;
        }

        public ActionResult Index()
        {
            var allCountries = _db.Countries.ToList();
            var visitedCountries = allCountries.Where(x => x.Visited).ToList();

            var codes = visitedCountries.Select(c => c.Code).ToArray();

            var visited = "\'" + string.Join("\', \'", codes) + "\'";

            var vm = new HomeViewModel
            {
                CountriesVisited = visited,
                CountriesTotal = allCountries.Count,
                CountriesVisitedTotal = visitedCountries.Count,
                CountriesToVisitTotal = allCountries.Count - visitedCountries.Count
            };

            return View(vm);
        }
    }
}