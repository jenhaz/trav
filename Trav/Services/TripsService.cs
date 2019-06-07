using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Trav.Domain.Trips;
using Trav.Web.Models;

namespace Trav.Web.Services
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
            var trips = tripsList.Select(ToViewModel);

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

        public TripViewModel For(int id)
        {
            var trip = _repository.For(id);

            return ToViewModel(trip);
        }

        public void Insert(TripViewModel vm)
        {
            var trip = ToDomain(vm);
            _repository.Insert(trip);
        }

        public void Edit(TripViewModel vm)
        {
            var trip = ToDomain(vm);
            _repository.Edit(trip);
        }

        public void Delete(TripViewModel vm)
        {
            var trip = ToDomain(vm);
            _repository.Delete(trip);
        }

        private TripViewModel ToViewModel(Trip trip)
        {
            var startDate = GetDate(trip.StartDate);
            var endDate = GetDate(trip.EndDate);
            var year = endDate != new DateTime()
                ? endDate.Year
                : 1901;

            return new TripViewModel
            {
                TripId = trip.Id,
                Year = year,
                City = trip.City,
                Country = trip.Country,
                StartDate = startDate,
                EndDate = endDate,
                CountryId = trip.CountryId
            };
        }

        private Trip ToDomain(TripViewModel trip)
        {
            return new Trip(
                trip.TripId, 
                trip.CountryId, 
                trip.City, 
                trip.StartDate.ToString("dd/MM/yyyy"), 
                trip.EndDate.ToString("dd/MM/yyyy"), 
                trip.Country);
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