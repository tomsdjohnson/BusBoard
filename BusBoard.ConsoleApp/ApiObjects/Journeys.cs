using System.Collections.Generic;

namespace BusBoard.ConsoleApp.ApiObjects
{
    class Journeys
    {
        private string startDateTime;
        private string arrivalDateTime;
        private int duration;
        private Legs[] legs;

        public Journeys(string startDateTime, string arrivalDateTime, int duration, Legs[] legs)
        {
            this.startDateTime = startDateTime;
            this.arrivalDateTime = arrivalDateTime;
            this.duration = duration;
            this.legs = legs;
        }

        public string GetStartDateTime()
        {
            return startDateTime;
        }

        public string GetArrivalDateTime()
        {
            return arrivalDateTime;
        }

        public int GetDuration()
        {
            return duration;
        }

        public Legs[] GetLegs()
        {
            return legs;
        }

    }
}
