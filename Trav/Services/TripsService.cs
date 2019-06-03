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
            var startDate = GetDate(trip.StartDate);
            var endDate = GetDate(trip.EndDate);
            var year = endDate != new DateTime() ? endDate.Year : 1901;

            return new TripViewModel
            {
                TripId = trip.TripId,
                Year = year,
                City = trip.City,
                Country = trip.Country.Name,
                StartDate = startDate,
                EndDate = endDate
            };
        }

        private DateTime GetDate(string date)
        {
            return DateTime.TryParseExact(
                date, 
                "dd/MM/yyyy", 
                CultureInfo.InvariantCulture, 
                DateTimeStyles.None,
                out var startDate)
                ? startDate
                : new DateTime();
        }
    }
}