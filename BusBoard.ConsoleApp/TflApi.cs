using System;
using System.Collections.Generic;
using RestSharp;

namespace BusBoard.ConsoleApp
{
  public class TflApi
  {
    public List<journeys> GetArrivalPredictions(string fromStopId, string toStopId)
    {
      var client = new RestClient(@"https://api.tfl.gov.uk");
      var request = new RestRequest("/Journey/JourneyResults/{from}/to/{to}", Method.GET);
      request.AddUrlSegment("from", fromStopId);
      request.AddUrlSegment("to", toStopId);

      var predictions2 = client.Execute(request);
      Console.WriteLine(predictions2.Content);
     
      var predictions = client.Execute<List<journeys>>(request).Data;
      Console.WriteLine(predictions);
      return predictions;
    }
  }
}