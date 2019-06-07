using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Trav.Domain.Countries;

namespace Trav.DataAccess.Countries
{
    public class CountriesRepository : ICountriesRepository
    {
        private readonly TravContext _db;

        public CountriesRepository(TravContext db)
        {
            _db = db;
        }

        public IEnumerable<Country> Get()
        {
            var countries = _db.Countries.ToList();

            return countries.Select(ToDomain);
        }

        public Country For(int id)
        {
            var country = _db.Countries.Find(id);

            return ToDomain(country);
        }

        public void Delete(Country country)
        {
            var dao = ToDao(country);

            _db.Countries.Remove(dao);
            _db.SaveChanges();
        }

        public void Insert(Country country)
        {
            var dao = ToDao(country);

            _db.Countries.Add(dao);
            _db.SaveChanges();
        }

        public void Edit(Country country)
        {
            var dao = ToDao(country);

            _db.Entry(dao).State = EntityState.Modified;
            _db.SaveChanges();
        }

        private CountryDao ToDao(Country country)
        {
            return new CountryDao
            {
                Id = country.Id,
                Name = country.Name,
                Code = country.Code,
                Visited = country.Visited
            };
        }

        private Country ToDomain(CountryDao dao)
        {
            return new Country
            {
                Id = dao.Id,
                Name = dao.Name,
                Code = dao.Code,
                Visited = dao.Visited
            };
        }
    }
}