using System.Collections.Generic;

namespace Trav.Domain.Countries
{
    public interface ICountriesRepository
    {
        IEnumerable<Country> Get();
        Country For(int id);
        void Delete(Country country);
        void Insert(Country country);
        void Edit(Country country);
    }
}