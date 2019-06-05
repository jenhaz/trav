using System.Collections.Generic;

namespace Trav.Domain.Countries
{
    public interface ICountriesRepository
    {
        IEnumerable<Country> Get();
    }
}