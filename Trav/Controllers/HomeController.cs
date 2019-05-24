using System.Linq;
using System.Web.Mvc;
using Trav.Models;
using Trav.Resolvers;
using Trav.Services;

namespace Trav.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var countriesService = new CountriesService(
                new CountriesRepositoryResolver().Resolve());
            var allCountries = countriesService.GetAll();
            var visitedCountries = countriesService.GetVisited();

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