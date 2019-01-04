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
            var fromStopId = "1000144"; //PromptForStopId(); - EastFinchley
            var toStopId = "1000336"; //PromptForStopId(); - MarbleArch

            var directionsAsJson = new TflApi().GetJourneyDirections(fromStopId, toStopId); //returns api json as string
            Returned directions = JsonConvert.DeserializeObject<Returned>(directionsAsJson); //puts json into objects
            DisplayDirections(directions); //displays result

            var stationsAsJson = new TflApi().GetAllStationNames(); //returns api json as string
            Stations[] stations = JsonConvert.DeserializeObject<Stations[]>(stationsAsJson); //puts json into objects
            Console.Write(stations[0].CommonName);          
            Console.ReadLine();
        }

        private static string PromptForStopId()
        {
            Console.Write("Enter stop ID: ");
            return Console.ReadLine();
        }

        private static void DisplayDirections(Returned directions)
        {
            Console.WriteLine($"{directions.Journeys[0].Duration} mins"); //length of entire journey
            Console.WriteLine();
            Console.WriteLine(directions.Journeys[0].Legs[0].DeparturePoint.CommonName);

            foreach (var i in directions.Journeys[0].Legs)
            {
                Console.WriteLine("█");
                Console.WriteLine("█");
                Console.WriteLine($"█ {i.Duration} mins ({i.Instruction.Detailed})");
                Console.WriteLine("█");
                Console.WriteLine("█");
                Console.WriteLine(i.ArrivalPoint.CommonName);
            }
        }
    }
}