using System.Collections.Generic;
using Trav.Models;

namespace Trav.Repositories
{
    public interface ITripsRepository
    {
        IEnumerable<Trip> Get();
    }
}