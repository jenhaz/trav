using Trav.DataAccess;
using Trav.DataAccess.Countries;
using Trav.Domain.Countries;

namespace Trav.Web.Resolvers
{
    public class CountriesRepositoryResolver
    {
        public ICountriesRepository Resolve()
        {
            return new CountriesRepository(
                new TravContext());
        }
    }
}