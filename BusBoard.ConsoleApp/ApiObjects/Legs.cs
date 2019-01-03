using System.Collections.Generic;
using System.IO;

namespace BusBoard.ConsoleApp.ApiObjects
{
    class Legs
    {
        public Instruction Instruction { get; set; }
        public string ArrivalDateTime { get; set; }
        public string StartDateTime { get; set; }
        public int Duration { get; set; }
        public DeparturePoint DeparturePoint { get; set; }
        public ArrivalPoint ArrivalPoint { get; set; }
        public Path Path { get; set; }
    }
}