using System.Linq;
using System.Web.Mvc;
using Trav.Web.Models;
using Trav.Web.Resolvers;
using Trav.Web.Services;

namespace Trav.Web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var countriesService = new CountriesService(
                new CountriesRepositoryResolver().Resolve());
            var allCountries = countriesService.GetAll();
            var visitedCountries = countriesService.GetAll(true);

            var countryCodes = visitedCountries.Select(c => c.Code).ToArray();

            var visited = "\'" + string.Join("\', \'", countryCodes) + "\'";

            var vm = new HomeViewModel
            {
                CountriesVisited = visited,
                CountriesTotal = allCountries.Count(),
                CountriesVisitedTotal = visitedCountries.Count(),
                CountriesToVisitTotal = allCountries.Count() - visitedCountries.Count()
            };

            return View(vm);
        }
    }
}