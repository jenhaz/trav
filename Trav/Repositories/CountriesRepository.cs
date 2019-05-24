using System.Collections.Generic;
using Trav.DAL;
using Trav.Models;

namespace Trav.Repositories
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
            return _db.Countries;
        }
    }
}