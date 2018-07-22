using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class CalcTotals
    {
        private static CalcTotals instance;

        private CalcTotals() { }

        public static CalcTotals Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new CalcTotals();
                }
                return instance;
            }
        }

        /// <summary>
        /// Method to calculate the sum of distances for an activity
        /// </summary>
        public double CalcTotalDistance(List<TimeLine> timeLines)
        {
            double totalDistance = 0.0;

            //calculate sum of distance covered
            for (int i = 0; i < timeLines.Count() - 1; i++)
            {
                double p1Lat = timeLines[i].Latitude;
                double p1Lon = timeLines[i].Longitude;
                double p2Lat = timeLines[i + 1].Latitude;
                double p2Lon = timeLines[i + 1].Longitude;

                Distance d = new Distance(p1Lat, p1Lon, p2Lat, p2Lon);

                double distance = d.DistanceInMtrRnd();

                totalDistance = totalDistance + distance;
            }

            return totalDistance;
        }
    }
}
