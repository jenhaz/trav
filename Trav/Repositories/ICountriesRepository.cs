using System.Collections.Generic;
using Trav.Models;

namespace Trav.Repositories
{
    public interface ICountriesRepository
    {
        IEnumerable<Country> Get();
    }
}