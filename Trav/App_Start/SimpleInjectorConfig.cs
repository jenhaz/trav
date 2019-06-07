using System.Web.Mvc;
using SimpleInjector;
using SimpleInjector.Integration.Web;
using SimpleInjector.Integration.Web.Mvc;
using Trav.DataAccess;
using Trav.DataAccess.Countries;
using Trav.DataAccess.Trips;
using Trav.Domain.Countries;
using Trav.Domain.Trips;
using Trav.Web.Services;

namespace Trav.Web
{
    public class SimpleInjectorConfig
    {
        public static void RegisterComponents()
        {
            var container = new Container();

            container.Options.DefaultScopedLifestyle = new WebRequestLifestyle();
            container.Register<TravContext>(Lifestyle.Scoped);

            container.Register<ICountriesRepository, CountriesRepository>();
            container.Register<ICountriesService, CountriesService>();

            container.Register<ITripsRepository, TripsRepository>();
            container.Register<ITripsService, TripsService>();

            container.Verify();
            DependencyResolver.SetResolver(new SimpleInjectorDependencyResolver(container));
        }
    }
}