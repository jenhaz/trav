using System.Collections.Generic;
using System.Linq;
using Trav.Domain.Countries;

namespace Trav.Web.Services
{
    public class CountriesService : ICountriesService
    {
        private readonly ICountriesRepository _countriesRepository;

        public CountriesService(ICountriesRepository countriesRepository)
        {
            _countriesRepository = countriesRepository;
        }

        public IEnumerable<Country> GetAll()
        {
            return _countriesRepository.Get();
        }

        public IEnumerable<Country> GetVisited()
        {
            return _countriesRepository.Get().Where(x => x.Visited);
        }
    }
}