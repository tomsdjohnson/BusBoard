using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Route("api/stations")]
    [ApiController]
    public class StationController : ControllerBase
    {
        public ListOfStations Stations { get; set; }

        public StationController()
        {
            this.Stations = new StationsContext().Stations;
        }

        // GET: api/stations
        [HttpGet]
        public async Task<ActionResult<ListOfStations>> GetStations()
        {
            return Stations;
        }
    }
}



