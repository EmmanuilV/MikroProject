using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace MyAirport.Models
{
    public class MyAirportContext : DbContext
    {
        public DbSet<Flight> Flights { get; set; }
        public DbSet<Airport> Airports { get; set; }

        public MyAirportContext(DbContextOptions<MyAirportContext> options) : base(options) { }

    }
}

