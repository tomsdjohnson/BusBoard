using System.Collections.Generic;

namespace BusBoard.ConsoleApp.ApiObjects
{
  public class Journeys
    {
    public string startDateTime { get; set; }
    public string arrivalDateTime { get; set; }
    public int duration { get; set; }
    public List<Legs> legs { get; set; }
    }
}