using System.Collections.Generic;
using Trav.Web.Models;

namespace Trav.Web.Services
{
    public interface ITripsService
    {
        IEnumerable<TripViewModel> GetTrips(string sortOrder);
    }
}