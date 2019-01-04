using System;
using System.Collections.Generic;
using RestSharp;

namespace BusBoard.ConsoleApp
{
    public class TflApi
    {
        public string GetJourneyDirections(string fromStopId, string toStopId)
        {
            var client = new RestClient(@"https://api.tfl.gov.uk");
            var request = new RestRequest("/Journey/JourneyResults/{from}/to/{to}", Method.GET);
            request.AddUrlSegment("from", fromStopId);
            request.AddUrlSegment("to", toStopId);

            var predictions = (client.Execute(request)).Content;

            return predictions;
        }

        public string GetAllStationNames(string line)
        {
            var client = new RestClient(@"https://api.tfl.gov.uk");
            var request = new RestRequest("/Line/{line}/StopPoints", Method.GET);
            request.AddUrlSegment("line", line);

            var stations = (client.Execute(request)).Content;

            return stations;
        }
    }
}