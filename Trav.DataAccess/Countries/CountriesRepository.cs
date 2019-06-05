using System.Collections.Generic;
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

        public IEnumerable<Domain.Countries.Country> Get()
        {
            return _db.Countries.Select(x => ToDomain(x));
        }

        private Domain.Countries.Country ToDomain(Country dao)
        {
            return new Domain.Countries.Country
            {
                Id = dao.Id,
                Name = dao.Name,
                Code = dao.Code,
                Visited = dao.Visited
            };
        }
    }
}