using System.Collections.Generic;
using Trav.Models;

namespace Trav.Services
{
    public interface ICountriesService
    {
        IEnumerable<Country> GetAll();
        IEnumerable<Country> GetVisited();
    }
}