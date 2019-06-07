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
            return _countriesRepository.Get()
                .Where(x => x.Visited);
        }

        public Country For(int id)
        {
            return _countriesRepository.For(id);
        }

        public void Delete(Country country)
        {
            _countriesRepository.Delete(country);
        }

        public void Insert(Country country)
        {
            _countriesRepository.Insert(country);
        }

        public void Edit(Country country)
        {
            _countriesRepository.Edit(country);
        }
    }
}