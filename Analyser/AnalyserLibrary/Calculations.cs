using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalyserLibrary
{
    public class Calculations
    {
        private static Calculations instance;

        private Calculations() { }

        public static Calculations Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Calculations();
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

        public List<XY> CalcMinMaxCoords(List<XY> coords)
        {
            List<XY> output = new List<XY>();

            double minX = coords[0].X;
            double minY = coords[0].Y;
            double maxX = coords[0].X;
            double maxY = coords[0].Y;

            foreach (var c in coords)
            {
                //find minimum and maximum values to scale pitch.
                minX = Math.Min(c.X, minX);
                minY = Math.Min(c.Y, minY);
                maxX = Math.Max(c.X, maxX);
                maxY = Math.Max(c.Y, maxY);
            }

            XY minXY = new XY(minX, minY);
            XY maxXY = new XY(maxX, maxY);
            output.Add(minXY);
            output.Add(maxXY);

            return output;
        }
    }
}
