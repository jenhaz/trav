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

        [Test]
        public void WrongStartDate_ReturnsEmptyDateTime()
        {
            // given
            var trip = _fixture.Build<Trip>()
                .With(x => x.StartDate, "2018/10/03")
                .With(x => x.EndDate, "10/10/2018")
                .Create();

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

        [Test]
        public void WrongEndDate_ReturnsEmptyDateTime()
        {
            // given
            var trip = _fixture.Build<Trip>()
                .With(x => x.StartDate, "02/10/2018")
                .With(x => x.EndDate, "484358583")
                .Create();

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
        }

        [Test]
        public void WrongEndDate_ReturnsWrongYear()
        {
            // given
            var trip = _fixture.Build<Trip>()
                .With(x => x.StartDate, "02/10/2018")
                .With(x => x.EndDate, "484358583")
                .Create();

            _tripsRepository.Get()
                .Returns(new List<Trip>
                {
                    trip
                });

            // when
            var results = _subject.GetTrips(_fixture.Create<string>());

            // then
            var result = results.FirstOrDefault();
            Assert.AreEqual(result.Year, 1901);
        }

        [Test]
        public void GetTrips_OrderedByCountry()
        {
            // given
            var trips = GetList();
            _tripsRepository.Get().Returns(trips);

            // when
            var result = _subject.GetTrips("country");

            // then
            Assert.That(result.First().Country, Is.EqualTo("a-name"));
        }

        [Test]
        public void GetTrips_OrderedByCity()
        {
            // given
            var trips = GetList();
            _tripsRepository.Get().Returns(trips);

            // when
            var result = _subject.GetTrips("city");

            // then
            Assert.That(result.First().City, Is.EqualTo("a-city"));
        }

        [Test]
        public void GetTrips_OrderedByYear()
        {
            // given
            var trips = GetList();
            _tripsRepository.Get().Returns(trips);

            // when
            var result = _subject.GetTrips("year");

            // then
            Assert.That(result.First().City, Is.EqualTo("c-city"));
        }

        [Test]
        public void GetTrips_OrderedByStartDate()
        {
            // given
            var trips = GetList();
            _tripsRepository.Get().Returns(trips);

            // when
            var result = _subject.GetTrips("startdate");

            // then
            Assert.That(result.First().City, Is.EqualTo("c-city"));
        }

        [Test]
        public void GetTrips_OrderedByEndDate()
        {
            // given
            var trips = GetList();
            _tripsRepository.Get().Returns(trips);

            // when
            var result = _subject.GetTrips("enddate");

            // then
            Assert.That(result.First().City, Is.EqualTo("c-city"));
        }

        [Test]
        public void GetTrips_DefaultOrdering()
        {
            // given
            var trips = GetList();
            _tripsRepository.Get().Returns(trips);

            // when
            var result = _subject.GetTrips();

            // then
            Assert.That(result.First().City, Is.EqualTo("c-city"));
        }

        private IEnumerable<Trip> GetList()
        {
            return new List<Trip>
            {
                new Trip(1, 1, "b-city", "01/01/2018", "01/01/2018", "a-name"),
                new Trip(1, 1, "a-city", "01/01/2018", "01/01/2018", "b-name"),
                new Trip(1, 1, "c-city", "01/01/2017", "01/01/2017", "c-name")
            };
        }
    }
}
