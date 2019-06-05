using Trav.DataAccess;
using Trav.DataAccess.Trips;
using Trav.Domain.Trips;

namespace Trav.Web.Resolvers
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