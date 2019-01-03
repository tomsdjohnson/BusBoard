using System.Collections.Generic;
using System.IO;

namespace BusBoard.ConsoleApp.ApiObjects
{
    class Legs
    {
        private Instruction instruction;
        private string arrivalDateTime;
        private string startDateTime;
        private int duration;
        private DeparturePoint departurePoint;
        private ArrivalPoint arrivalPoint;
        private Path path;

        private StopPoints[] stopPoints;

        public Legs(string startDateTime, string arrivalDateTime, int duration, Instruction instruction, DeparturePoint departurePoint, ArrivalPoint arrivalPoint, Path path)
        {
            this.startDateTime = startDateTime;
            this.arrivalDateTime = arrivalDateTime;
            this.duration = duration;
            this.instruction = instruction;
            this.departurePoint = departurePoint;
            this.arrivalPoint = arrivalPoint;
            this.path = path;
        }


        public int Foo { get; set; }


    }
}