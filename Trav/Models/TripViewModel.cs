using System;

namespace Trav.Models
{
    public class TripViewModel
    {
        public int TripId { get; set; }
        public int Year { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
    }
}