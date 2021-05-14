using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAirport.Models;

namespace MyAirport.Controllers
{
    [Route("api/airports")]
    public class MyAirportController : ControllerBase
    {
        private MyAirportService airportService;
        public MyAirportController(MyAirportService service1)
        {
            this.airportService = service1;
        }

        [HttpGet]
        public List<Airport> GetFlights()
        {
            return airportService.GetAllAirports();
        }

        [HttpGet("flight/{depCode}/{arrCode}/{date}")]
        public Flight GetFlightById(Airport depCode, Airport arrCode, DateTime date)
        {
            return airportService.GetFlight(depCode.Code, arrCode.Code, date);
        }

        [HttpPost("")]
        public async Task<ActionResult<Flight>> PostFlight(Flight model)
        {
            // TODO: Your code here
            await Task.Yield();

            return null;
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> PutFlight(int id, Flight model)
        {
            // TODO: Your code here
            await Task.Yield();

            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult<Flight>> DeleteFlightById(int id)
        {
            // TODO: Your code here
            await Task.Yield();

            return null;
        }
    }
}