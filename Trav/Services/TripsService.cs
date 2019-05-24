using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Trav.Models;
using Trav.Repositories;

namespace Trav.Services
{
    public class TripsService : ITripsService
    {
        private readonly ITripsRepository _repository;

        public TripsService(ITripsRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<TripViewModel> GetTrips(string sortOrder = null)
        {
            var tripsList = _repository.Get();
            var trips = tripsList.Select(GetTripVm);

            switch (sortOrder)
            {
                case "country":
                    trips = trips.OrderBy(y => y.Country);
                    break;
                case "city":
                    trips = trips.OrderBy(y => y.City);
                    break;
                case "year":
                    trips = trips.OrderBy(y => y.EndDate);
                    break;
                case "startdate":
                    trips = trips.OrderBy(y => y.StartDate);
                    break;
                case "enddate":
                    trips = trips.OrderBy(y => y.EndDate);
                    break;
                default:
                    trips = trips.OrderBy(y => y.EndDate);
                    break;
            }

            return trips;
        }

        private TripViewModel GetTripVm(Trip trip)
        {
            return new TripViewModel
            {
                TripId = trip.TripId,
                Year = DateTime.TryParseExact(trip.EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime endDate)
                    ? endDate.Year
                    : 1901,
                City = trip.City,
                Country = trip.Country.Name,
                StartDate = DateTime.TryParseExact(trip.StartDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime startDate)
                    ? startDate
                    : new DateTime(),
                EndDate = DateTime.TryParseExact(trip.EndDate, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out endDate)
                    ? endDate
                    : new DateTime()
            };
        }
    }
}