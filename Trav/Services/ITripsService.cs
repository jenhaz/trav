using System.Collections;
using System.Collections.Generic;
using Trav.Models;

namespace Trav.Services
{
    public interface ITripsService
    {
        IEnumerable<TripViewModel> GetTrips(string sortOrder);
    }
}