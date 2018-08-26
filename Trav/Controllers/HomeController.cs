using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using Trav.DAL;
using Trav.Models;

namespace Trav.Controllers
{
    public class HomeController : Controller
    {
        private TravContext db = new TravContext();

        public ActionResult Index()
        {
            IEnumerable<Country> countries = db.Countries.ToList();
            IEnumerable<Country> done = countries.Where(x => x.Visited);

            string[] codes = done.Select(c => c.Code).ToArray();

            string visited = "\'" + string.Join("\', \'", codes) + "\'";

            HomeViewModel vm = new HomeViewModel
            {
                CountriesVisited = visited,
                CountriesTotal = countries.Count(),
                CountriesVisitedTotal = done.Count(),
                CountriesToVisitTotal = (countries.Count() - done.Count())
            };

            return View(vm);
        }
    }
}