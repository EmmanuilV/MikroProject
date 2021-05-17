using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;

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
        public Flight GetFlight(string depCode, string arrCode, DateTime curDate)
        {
            List<Flight> currentFlights = db.Flights
            .Include(f => f.Arrival)
            .Include(f => f.Departure)
            .ToList();

            List<DateTime> dateList = new List<DateTime>();
            for (int i = 0; i < currentFlights.Count; i++)
            {
                if (dateList.Count == 0)
                {
                    dateList.Add(currentFlights[i].Date);
                    System.Console.WriteLine("dateList after first append: {0}", dateList.FirstOrDefault());
                }
                else
                {
                    if (curDate <= dateList[0])
                    {
                        if (dateList[0] > currentFlights[i].Date)
                        {
                            dateList.RemoveAt(0);
                            dateList.Append(currentFlights[i].Date);
                            System.Console.WriteLine("dateList append: {0}", dateList.FirstOrDefault());

                        }
                    }
                }
            }

            Flight flight = new Flight();
            for (int i = 0; i < currentFlights.Count; i++)
            {
                if (currentFlights[i].Date == dateList.FirstOrDefault())
                {
                    flight = currentFlights.FirstOrDefault(f => f.Date == dateList.FirstOrDefault());
                }
                else
                {
                    System.Console.WriteLine("IT'S NOT WORK");
                }
            }
            return flight;
        }
        
    }
}

