using System.Collections.Generic;

namespace BusBoard.ConsoleApp.models.JourneyApi
{
    class Journeys
    {
        public string StartDateTime { get; set; }
        public string ArrivalDateTime { get; set; }
        public int Duration { get; set; }
        public Legs[] Legs { get; set; }
    }
}
 