namespace Trav.Models
{
    public class Trip
    {
        public int TripId { get; set; }
        public int CountryId { get; set; }
        public string City { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }


        public virtual Country Country { get; set; }
    }
}