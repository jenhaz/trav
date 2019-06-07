using System.Collections.Generic;
using System.Data.Entity;
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

        public IEnumerable<Trip> Get()
        {
            var trips = _db.Trips.ToList();

            return trips.Select(ToDomain);
        }

        public Trip For(int id)
        {
            var trip = _db.Trips.Find(id);

            return ToDomain(trip);
        }

        public void Insert(Trip trip)
        {
            var dao = ToDao(trip);

            _db.Trips.Add(dao);
            _db.SaveChanges();
        }

        public void Edit(Trip trip)
        {
            var dao = ToDao(trip);

            _db.Entry(dao).State = EntityState.Modified;
            _db.SaveChanges();
        }

        public void Delete(Trip trip)
        {
            var dao = ToDao(trip);

            _db.Trips.Remove(dao);
            _db.SaveChanges();
        }

        private TripDao ToDao(Trip trip)
        {
            return new TripDao
            {
                TripId = trip.Id,
                City = trip.City,
                CountryId = trip.CountryId,
                StartDate = trip.StartDate,
                EndDate = trip.EndDate
            };
        }

        private Trip ToDomain(TripDao dao)
        {
            return new Trip(
                dao.TripId,
                dao.CountryId,
                dao.City,
                dao.StartDate,
                dao.EndDate,
                dao.Country.Name);
        }
    }
}