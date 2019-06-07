using System.Collections.Generic;
using Trav.Web.Models;

namespace Trav.Web.Services
{
    public interface ITripsService
    {
        IEnumerable<TripViewModel> GetTrips(string sortOrder);
        TripViewModel For(int id);
        void Insert(TripViewModel vm);
        void Edit(TripViewModel vm);
        void Delete(TripViewModel vm);
    }
}