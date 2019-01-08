using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class StationsContext
    {
        public ListOfStations Stations { get; set; }

        public StationsContext()
        {
            Stations = GetAllStations.Get();
        }
    }
}
