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
            // .Where(f => f.Departure.Code == depCode && f.Arrival.Code == arrCode)
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

            Console.WriteLine("Departure.Code: {0}, Arrival.Code: {1}, Date: {2}", currentFlights[0].Departure.Code, currentFlights[0].Arrival.Code, currentFlights[0].Date);
            // dateList.ForEach(d => Console.WriteLine("dateList: ", d));
            Console.WriteLine("dateList.FirstOrDefault(): {0}", dateList.FirstOrDefault());
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
            // Flight flight = currentFlights.FirstOrDefault(f => f.Date == dateList.FirstOrDefault());
            // Console.WriteLine("FLIGHT: {0}", flight);

            return flight;
        }
    }
}

