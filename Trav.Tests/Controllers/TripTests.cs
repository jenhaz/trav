using AutoFixture;
using NUnit.Framework;
using System;
using Trav.Controllers;
using Trav.Models;

namespace Trav.Tests.Controllers
{
    [TestFixture]
    public class TripTests
    {
        TripsController tripsController = new TripsController();

        [Test]
        public void WrongStartDate_ReturnsEmptyDateTime()
        {
            Fixture fixture = new Fixture();
            Trip trip = fixture.Build<Trip>()
                .With(x => x.Country, new Country())
                .With(x => x.StartDate, "2018/10/03")
                .With(x => x.EndDate, "10/10/2018")
                .Create();

            TripViewModel result = tripsController.GetTripVm(trip);

            Assert.AreEqual(result.StartDate, new DateTime());
        }

        [Test]
        public void WrongEndDate_ReturnsEmptyDateTime()
        {
            Fixture fixture = new Fixture();
            Trip trip = fixture.Build<Trip>()
                .With(x => x.Country, new Country())
                .With(x => x.StartDate, "02/10/2018")
                .With(x => x.EndDate, "484358583")
                .Create();

            TripViewModel result = tripsController.GetTripVm(trip);

            Assert.AreEqual(result.EndDate, new DateTime());
        }

        [Test]
        public void WrongEndDate_ReturnsWrongYear()
        {
            Fixture fixture = new Fixture();
            Trip trip = fixture.Build<Trip>()
                .With(x => x.Country, new Country())
                .With(x => x.StartDate, "02/10/2018")
                .With(x => x.EndDate, "484358583")
                .Create();

            TripViewModel result = tripsController.GetTripVm(trip);

            Assert.AreEqual(result.Year, 1901);
        }
    }
}
