using System.Collections.Generic;

namespace Trav.Domain.Trips
{
    public interface ITripsRepository
    {
        IEnumerable<Trip> Get();
        Trip For(int id);
        void Insert(Trip trip);
    }
}