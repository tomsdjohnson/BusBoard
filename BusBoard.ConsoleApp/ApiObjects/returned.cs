using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusBoard.ConsoleApp.ApiObjects
{
    class Returned
    {
      //private string[] journeys;
      private string journeyVector;

        public Returned(string journeyVector)
      {
          //this.journeys = journeys;
          this.journeyVector = journeyVector;
      }

      //public string[] getJourneys()
      //{
          //return journeys;
      //}

      public string getJourneyVector()
      {
          return journeyVector;
      }

    }
}
