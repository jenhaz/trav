using AutoFixture;
using NSubstitute;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using Trav.Domain.Trips;
using Trav.Web.Services;

namespace Trav.Tests.Unit.Services
{
    public class TripServiceTests
    {
        private ITripsRepository _tripsRepository;
        private TripsService _subject;
        private Fixture _fixture;

        [SetUp]
        public void SetUp()
        {
            _tripsRepository = Substitute.For<ITripsRepository>();
            _subject = new TripsService(_tripsRepository);
            _fixture = new Fixture();
        }

        [TestCase("484358583")]
        [TestCase("2018/p/4")]
        [TestCase("potato")]
        public void WrongStartDate_ReturnsEmptyDateTime(
            string startDate)
        {
            // given
            var trip = new Trip(
                _fixture.Create<int>(),
                _fixture.Create<int>(),
                _fixture.Create<string>(),
                startDate,
                "10/10/2018",
                _fixture.Create<string>());

            _tripsRepository.Get()
                .Returns(new List<Trip>
            {
                trip
            });

            // when
            var results = _subject.GetTrips(_fixture.Create<string>());

            // then
            var result = results.FirstOrDefault();
            Assert.AreEqual(result.StartDate, new DateTime());
        }

        [TestCase("484358583")]
        [TestCase("2018/p/4")]
        [TestCase("potato")]
        public void WrongEndDate_ReturnsEmptyDateTime_AndWrongYear(
            string endDate)
        {
            // given
            var trip = new Trip(
                _fixture.Create<int>(),
                _fixture.Create<int>(),
                _fixture.Create<string>(),
                "02/10/2018",
                endDate,
                _fixture.Create<string>());

            _tripsRepository.Get()
                .Returns(new List<Trip>
                {
                    trip
                });

            // when
            var results = _subject.GetTrips(_fixture.Create<string>());

            // then
            var result = results.FirstOrDefault();
            Assert.AreEqual(result.EndDate, new DateTime());
            Assert.AreEqual(result.Year, 1901);
        }

        [TestCase("country", "country1", "city2")]
        [TestCase("city", "country2", "city1")]
        [TestCase("year", "country3", "city3")]
        [TestCase("startdate", "country3", "city3")]
        [TestCase("enddate", "country3", "city3")]
        [TestCase("", "country3", "city3")]
        public void GetTrips_OrderedByCountry(
            string sortOrder,
            string expectedCountryName,
            string expectedCityName)
        {
            // given
            var trips = GetList();
            _tripsRepository.Get().Returns(trips);

            // when
            var result = _subject.GetTrips(sortOrder);

            // then
            Assert.That(result.First().Country, Is.EqualTo(expectedCountryName));
            Assert.That(result.First().City, Is.EqualTo(expectedCityName));
        }

        private IEnumerable<Trip> GetList()
        {
            return new List<Trip>
            {
                new Trip(1, 1, "city2", "01/01/2018", "01/01/2018", "country1"),
                new Trip(1, 1, "city1", "01/01/2018", "01/01/2018", "country2"),
                new Trip(1, 1, "city3", "01/01/2017", "01/01/2017", "country3")
            };
        }
    }
}
