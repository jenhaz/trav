namespace Trav.Domain.Trips
{
    public class Trip
    {
        public Trip(
            int id, 
            int countryId, 
            string city, 
            string startDate,
            string endDate, 
            string country)
        {
            Id = id;
            CountryId = countryId;
            City = city;
            StartDate = startDate;
            EndDate = endDate;
            Country = country;
        }

        public int Id { get; }
        public int CountryId { get; }
        public string City { get; }
        public string StartDate { get; }
        public string EndDate { get;}
        public string Country { get; }
    }
}