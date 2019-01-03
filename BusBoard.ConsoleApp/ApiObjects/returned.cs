using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.ConsoleApp.ApiObjects
{
    class Returned
    {
      private string[] journeys;

        public Returned(string[] journeys)
      {
          this.journeys = journeys;
      }

      public string[] getJourneys()
      {
       return journeys;
      }
    }
}
