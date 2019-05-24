using Trav.DAL;
using Trav.Repositories;

namespace Trav.Resolvers
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