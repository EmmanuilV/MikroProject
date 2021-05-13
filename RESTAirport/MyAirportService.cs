using System;
using System.Collections.Generic;
using System.Linq;

namespace MyAirport.Models
{
    public class MyAirportService
    {
        private MyAirportContext db;

        public MyAirportService(MyAirportContext context)
        {
            this.db = context;
        }
        public List<Airport> GetAllAirports() 
        {
            List<Airport> airports = db.Airports.ToList();

            return airports;
        }
        public Flight GetFlight(Airport depCode, Airport arrCode, DateTime date) 
        {
            Flight flight = db.Flights
            .Where(f => f.Departure == depCode && f.Arrival == arrCode)
            .Single();

            return flight;
        }
    }
}

