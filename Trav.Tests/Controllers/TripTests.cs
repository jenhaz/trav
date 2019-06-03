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
        private TripsController _tripsController;
        private Fixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _tripsController = new TripsController();
            _fixture = new Fixture();
        }

        [Test]
        public void WrongStartDate_ReturnsEmptyDateTime()
        {
            var trip = _fixture.Build<Trip>()
                .With(x => x.Country, new Country())
                .With(x => x.StartDate, "2018/10/03")
                .With(x => x.EndDate, "10/10/2018")
                .Create();

            var result = _tripsController.GetTripVm(trip);

            Assert.AreEqual(result.StartDate, new DateTime());
        }

        [Test]
        public void WrongEndDate_ReturnsEmptyDateTime()
        {
            var trip = _fixture.Build<Trip>()
                .With(x => x.Country, new Country())
                .With(x => x.StartDate, "02/10/2018")
                .With(x => x.EndDate, "484358583")
                .Create();

            var result = _tripsController.GetTripVm(trip);

            Assert.AreEqual(result.EndDate, new DateTime());
        }

        [Test]
        public void WrongEndDate_ReturnsWrongYear()
        {
            var trip = _fixture.Build<Trip>()
                .With(x => x.Country, new Country())
                .With(x => x.StartDate, "02/10/2018")
                .With(x => x.EndDate, "484358583")
                .Create();

            var result = _tripsController.GetTripVm(trip);

            Assert.AreEqual(result.Year, 1901);
        }
    }
}
