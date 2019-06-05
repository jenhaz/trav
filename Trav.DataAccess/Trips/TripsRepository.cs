using System.Collections.Generic;
using System.Linq;
using Trav.Domain.Trips;

namespace Trav.DataAccess.Trips
{
    public class TripsRepository : ITripsRepository
    {
        private readonly TravContext _db;

        public TripsRepository(TravContext db)
        {
            _db = db;
        }

        public IEnumerable<Domain.Trips.Trip> Get()
        {
            return _db.Trips.Select(x => ToDomain(x));
        }

        private Domain.Trips.Trip ToDomain(Trip dao)
        {
            return new Domain.Trips.Trip(
                dao.TripId,
                dao.CountryId,
                dao.City, 
                dao.StartDate, 
                dao.EndDate,
                dao.Country.Name);
        }
    }
}