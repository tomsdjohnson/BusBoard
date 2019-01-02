using System.Collections.Generic;

namespace BusBoard.ConsoleApp.ApiObjects
{
    public class Legs
    {
        public Instruction instruction { get; set; }
        public string arrivalDateTime { get; set; }
        public int duration { get; set; }
        public string startDateTime { get; set; }
        public List<StopPoints> stopPoints { get; set; }
    }
}
