using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using BusBoard.ConsoleApp.ApiObjects;
using Newtonsoft.Json;

namespace BusBoard.ConsoleApp
{
  class Program
  {
    static void Main(string[] args)
    {
      ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

      //gets stop inputs
      var fromStopId = "1000067"; //PromptForStopId();
      var toStopId = "1000013"; //PromptForStopId();

      var predictions = new TflApi().GetArrivalPredictions(fromStopId, toStopId); //returns api json as string
      Returned iHopeThisFuckingWorks = JsonConvert.DeserializeObject<Returned>(predictions); //puts json into object "Returned"

      Console.WriteLine(iHopeThisFuckingWorks.Journeys[0].Legs[0].Duration); //spoiler it doesn't work

      //displays result
      DisplayPredictions(predictions);
      Console.ReadLine();
    }

    private static string PromptForStopId()
    {
      Console.Write("Enter stop ID: ");
      return Console.ReadLine();
    }

    private static void DisplayPredictions(string predictionsToDisplay)
    { 
     //Console.WriteLine($"Json: {predictionsToDisplay}"); 
    }
  }
}
