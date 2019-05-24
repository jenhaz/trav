using Trav.DAL;
using Trav.Repositories;

namespace Trav.Resolvers
{
    public class TripsRepositoryResolver
    {
        public ITripsRepository Resolve()
        {
            return new TripsRepository(
                new TravContext());
        }
    }
}