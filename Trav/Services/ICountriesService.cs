﻿using System.Collections.Generic;
using Trav.Domain.Countries;

namespace Trav.Web.Services
{
    public interface ICountriesService
    {
        IEnumerable<Country> GetAll(bool visited = false);
        Country For(int id);
        void Delete(Country country);
        void Insert(Country country);
        void Edit(Country country);
    }
}