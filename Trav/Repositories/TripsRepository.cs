using System.Collections.Generic;
using System.Linq;
using Trav.DAL;
using Trav.Models;

namespace Trav.Repositories
{
    public class TripsRepository : ITripsRepository
    {
        private readonly TravContext _db;

        public TripsRepository(TravContext db)
        {
            _db = db;
        }

        public IEnumerable<Trip> Get()
        {
            return _db.Trips.ToList();
        }
    }
}