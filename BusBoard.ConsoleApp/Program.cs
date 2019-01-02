﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

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

      //calls api
      var predictions = new TflApi().GetArrivalPredictions(fromStopId, toStopId);

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
     Console.WriteLine($"Json: {predictionsToDisplay}"); 
    }
  }
}
