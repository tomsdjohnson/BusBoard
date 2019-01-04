using System.Collections.Generic;
using System.IO;

namespace BusBoard.ConsoleApp.models.JourneyApi
{
    class Legs
    {
        public Instruction Instruction { get; set; }
        public string ArrivalDateTime { get; set; }
        public string StartDateTime { get; set; }
        public int Duration { get; set; }
        public DepartureAndArrivalPoint DeparturePoint { get; set; }
        public DepartureAndArrivalPoint ArrivalPoint { get; set; }
        public Path Path { get; set; }
    }
}