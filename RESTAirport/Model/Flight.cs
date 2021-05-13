using System;

namespace MyAirport.Models
{
    public class Flight
    {
        public int ID { get; set; }
        public Airport Departure { get; set; }
        public Airport Arrival { get; set; }
        public DateTime? Date { get; set; }
        public int PlacesCount { get; set; }
        public int ReservedPlaces { get; set; }

    }
}