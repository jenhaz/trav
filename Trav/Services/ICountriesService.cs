using System.Collections.Generic;
using Trav.Domain.Countries;

namespace Trav.Web.Services
{
    public interface ICountriesService
    {
        IEnumerable<Country> GetAll();
        IEnumerable<Country> GetVisited();
        Country For(int id);
        void Delete(Country country);
    }
}