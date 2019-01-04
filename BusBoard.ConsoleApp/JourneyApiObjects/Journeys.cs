using System.Collections.Generic;

namespace BusBoard.ConsoleApp.JourneyApiObjects
{
    class Journeys
    {
        public string StartDateTime { get; set; }
        public string ArrivalDateTime { get; set; }
        public int Duration { get; set; }
        public Legs[] Legs { get; set; }
    }
}
 