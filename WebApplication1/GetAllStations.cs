using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using WebApplication1.Models;


namespace WebApplication1
{
    public class GetAllStations
    {
        public static ListOfStations Get()
        {
            List<string> lines = CvsReader();
            List<Station> allStations = new List<Station>();

            foreach (var line in lines)
            {
                var stationsAsJson = new TflApi().GetAllStationNames(line); //returns api json as string
                Station[] stations = JsonConvert.DeserializeObject<Station[]>(stationsAsJson); //puts json into objects
                foreach (var station in stations)
                {
                    allStations.Add(station);
                }
            }
            ListOfStations allStationsList = new ListOfStations();
            allStationsList.listStation = allStations;

            return allStationsList;
        }

        private static List<string> CvsReader()
        {
            var reader = new StreamReader(File.OpenRead("C:\\Work\\C# Training\\JournyBoard\\BusBoard.ConsoleApp\\bin\\Debug"));
            List<string> searchList = new List<string>();
            while (!reader.EndOfStream)
            {
                var line = reader.ReadLine();
                searchList.Add(line);
            }
            return searchList;
        }
    }
}
