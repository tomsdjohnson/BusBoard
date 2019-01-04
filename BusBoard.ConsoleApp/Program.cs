using System;
using System.Net;
using System.Collections.Generic;
using System.IO;
using BusBoard.ConsoleApp.models.JourneyApi;
using BusBoard.ConsoleApp.models.StationsApi;
using Newtonsoft.Json;

namespace BusBoard.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            bool getDirections = PromptForResponse();
            if (getDirections)
            {
                var fromStopId = "1000067"; //example stations - East Finchley
                var toStopId = "1000144"; //example stations - Marble Arch

                var directionsAsJson = new TflApi().GetJourneyDirections(fromStopId, toStopId); //returns api json as string
                Returned directions = JsonConvert.DeserializeObject<Returned>(directionsAsJson); //puts json into objects
                DisplayDirections(directions); //displays result
            }
            else
            {
                List<string> lines = CvsReader();
                List<Stations> allStations = new List<Stations>();

                Console.WriteLine("Downloading all stations:");
                Console.Write("[");

                foreach (var line in lines)
                {
                    var stationsAsJson = new TflApi().GetAllStationNames(line); //returns api json as string
                    Stations[] stations = JsonConvert.DeserializeObject<Stations[]>(stationsAsJson); //puts json into objects
                    foreach (var station in stations)
                    {
                       allStations.Add(station);
                    }
                 Console.Write("#");
                }
                Console.WriteLine("]");
            }                   
            Console.ReadLine();
        }

        private static bool PromptForResponse()
        {
            while (1.Equals(1))
            {
                Console.WriteLine("Plan a journey [1]");
                Console.WriteLine("Import station names [2]");
                string ans = Console.ReadLine();
                Console.WriteLine();
                if (ans.Equals("1"))
                {
                    return true;
                }
                if (ans.Equals("2"))
                {
                    return false;
                }              
                Console.WriteLine("Please enter a valid response");
                Console.WriteLine();                
            }
            return true;
        }

        private static List<string> CvsReader()
        {
            var reader = new StreamReader(File.OpenRead("TrainLines.csv"));
            List<string> searchList = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            return searchList;
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