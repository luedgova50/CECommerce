namespace CECommerce.Classes
{
    using CECommerce.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class ComBoxHelpers : IDisposable
    {
        private static CECommerceContext db = new CECommerceContext();

        public static List<State> GetStates()
        {
            var states = db.States.ToList();

            states.Add(new State
            {
                StateId = 0,
                NameState = "[---Select a State...---]"
            });

            return states =
                     states.
                     OrderBy(
                     d => d.NameState).
                     ToList();
        }

        public static List<City> GetCities()
        {
            var cities = db.Cities.ToList();

            cities.Add(new City
            {
                CityId = 0,
                NameCity = "[---Select a City...---]"
            });

            return cities =
                     cities.
                     OrderBy(
                     c => c.NameCity).
                     ToList();
        }

        public static List<Company> GetCompanies()
        {
            var companies = db.Companies.ToList();

            companies.Add(new Company
            {
                CompanyId = 0,
                NameCompany = "[---Select a Company...---]"
            });

            return companies =
                     companies.
                     OrderBy(
                     c => c.NameCompany).
                     ToList();
        }

        public void Dispose()
        {
            db.Dispose();
        }
    

    }
}